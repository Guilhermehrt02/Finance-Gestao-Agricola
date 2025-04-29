import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  OnInit,
  Output,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
  AbstractControl,
} from '@angular/forms';
import { ButtonComponent } from '../../components/button/button.component';
import { InputComponent } from '../../components/input/input.component';
import {
  SelectComponent,
  SelectOption,
} from '../../components/select/select.component';
import {
  Expense,
  ExpenseCategoryLabels,
  PaymentMethodLabels
} from '@farm/core';

@Component({
  selector: 'lib-expense-form',
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    InputComponent,
    ButtonComponent,
    SelectComponent,
  ],
  templateUrl: './expense-form.component.html',
  styleUrl: './expense-form.component.css',
})
export class ExpenseFormComponent implements OnInit, OnChanges {
  @Input() expense: Expense | undefined;
  @Input() loading = false;
  @Input() submitLabel = 'Cadastrar';

  @Output() expenseSubmit = new EventEmitter<any>();

  expenseForm: FormGroup;
  receiptFile: File | null = null;

  categoryOptions: SelectOption[] = Object.entries(ExpenseCategoryLabels).map(
    ([value, label]) => ({ value, label })
  );
  
  paymentMethods: SelectOption[] = Object.entries(PaymentMethodLabels).map(
    ([value, label]) => ({ value, label })
  );

  constructor() {
    this.expenseForm = new FormGroup({
      id: new FormControl('', { validators: [], updateOn: 'blur' }),
      description: new FormControl('', { validators: [Validators.maxLength(300)], updateOn: 'blur' }),
      category: new FormControl('', {
        validators: [
          Validators.required,
          Validators.minLength(1),
          Validators.maxLength(50),
        ],
        updateOn: 'blur',     
      }),
      amount: new FormControl('', { 
        validators: [
          Validators.required,
          Validators.min(0.01),
        ],
        updateOn: 'blur',
      }),
      date: new FormControl('', { 
        validators: [
          Validators.required, 
          this.dateNotInFutureValidator()
        ], 
        updateOn: 'blur' 
      }),
      paymentMethod: new FormControl(''),
      receiptUrl: new FormControl('')
    });
  }

  ngOnInit(): void {
    if (this.expense) this.updateExpenseData();
  }

  ngOnChanges(): void {
    if (this.expense) this.updateExpenseData();

    if (this.loading) {
      this.expenseForm.disable();
    } else {
      this.expenseForm.enable();
    }
  }

  get description(): FormControl {
    return this.expenseForm.get('description') as FormControl;
  }

  get category(): FormControl {
    return this.expenseForm.get('category') as FormControl;
  }

  get amount(): FormControl {
    return this.expenseForm.get('amount') as FormControl;
  }

  get date(): FormControl {
    return this.expenseForm.get('date') as FormControl;
  }

  get paymentMethod(): FormControl {
    return this.expenseForm.get('paymentMethod') as FormControl;
  }

  get receiptUrl(): FormControl {
    return this.expenseForm.get('receiptUrl') as FormControl;
  }

  updateExpenseData(): void {
    if (!this.expense) return;
  
    const selectedCategory = this.categoryOptions.find(
      (option) => this.expense && option.value === this.expense.category
    );
  
    const selectedPaymentMethod = this.paymentMethods.find(
      (option) => option.value === this.expense?.paymentMethod
    );
    
    const formattedDate = this.formatDateToInput(this.expense.date);

    this.expenseForm.patchValue({
      description: this.expense.description ?? '',
      category: selectedCategory ?? '',
      amount: this.expense.amount ?? 0,
      date: formattedDate,
      paymentMethod: selectedPaymentMethod ?? '',
      receiptUrl: this.expense.receiptUrl ?? ''
    });
  }

  onSubmit() {
    if (this.expenseForm.invalid) {
      return this.expenseForm.markAllAsTouched();
    }

    const formData = {
      id: this.expense?.id || '',
      description: this.description.value,
      category: this.category.value.value,
      amount: this.amount.value,
      date: this.date.value,
      paymentMethod: this.paymentMethod.value.value,
      receiptUrl: this.receiptUrl.value,
      userId: this.expense?.userId || '', 
      createdAt: this.expense?.createdAt || new Date(), 
      updatedAt: new Date(), 
      receiptFile: this.receiptFile || null,
    };

    this.expenseSubmit.emit(formData);
  }

  onFileSelected(file: File | null) {
    this.receiptFile = file;
  }

  getAmountErrorMessage(): string {
    if (this.amount.hasError('required')) {
      return 'Valor é obrigatório.';
    }
    if (this.amount.hasError('min')) {
      return 'Valor deve ser maior que 0.';
    }
    return '';
  }
  
  getDateErrorMessage(): string {
    if (this.date.hasError('required')) {
      return 'Data é obrigatória.';
    }
    return '';
  }

  dateNotInFutureValidator() {
    return (control: AbstractControl) => {
      const today = new Date();
      const value = new Date(control.value);
      if (value > today) {
        return { futureDate: true };
      }
      return null;
    };
  }
  
  private formatDateToInput(date: string | Date): string {
    const d = new Date(date);
    const year = d.getFullYear();
    const month = String(d.getMonth() + 1).padStart(2, '0');
    const day = String(d.getDate()).padStart(2, '0');
    return `${year}-${month}-${day}`;
  }
  
}