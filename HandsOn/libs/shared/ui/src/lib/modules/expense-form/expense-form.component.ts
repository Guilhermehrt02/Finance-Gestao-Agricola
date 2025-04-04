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
} from '@angular/forms';
import { ButtonComponent } from '../../components/button/button.component';
import { InputComponent } from '../../components/input/input.component';
import {
  SelectComponent,
  SelectOption,
} from '../../components/select/select.component';
import {
  Expense,
  ExpenseFacade
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

  @Output() expenseSubmit = new EventEmitter<Expense>();

  expenseForm: FormGroup;

  paymentMethods: SelectOption[] = [
    { label: 'Dinheiro', value: 'Cash' },
    { label: 'Cartão de Crédito', value: 'CreditCard' },
    { label: 'Cartão de Débito', value: 'DebitCard' },
    { label: 'Pix', value: 'Pix' },
    { label: 'Boleto', value: 'Boleto' }
  ];

  categoryOptions: SelectOption[] = [
    { label: 'Infraestrutura', value: 'Infraestruture' },
    { label: 'Máquina', value: 'Machine' },
    { label: 'Insumo', value: 'Input' },
    { label: 'Defensivo', value: 'Defensive' },
    { label: 'Outros - Longo Prazo', value: 'othersLongTerm' },
    { label: 'Outros - Curto Prazo', value: 'othersShortTerm' },
  ];

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
      date: new FormControl('', { validators: [Validators.required], updateOn: 'blur' }),
      paymentMethod: new FormControl('', { validators: [], updateOn: 'blur' }),
      receiptUrl: new FormControl('', { validators: [Validators.maxLength(500)], updateOn: 'blur' }),
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

    this.expenseForm.patchValue({
      description: this.expense.description ?? '',
      category: this.expense.category ?? '',
      amount: this.expense.amount ?? 0,
      date: this.expense.date ?? '',
      paymentMethod: this.expense.paymentMethod ?? '',
      receiptUrl: this.expense.receiptUrl ?? '',
    });
  }

  onSubmit() {
    if (this.expenseForm.invalid) {
      return this.expenseForm.markAllAsTouched();
    }

    const expense: Expense = {
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
    };

    this.expenseSubmit.emit(expense);
  }
}