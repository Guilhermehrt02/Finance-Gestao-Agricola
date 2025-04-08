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
  Revenue,
} from '@farm/core';

@Component({
  selector: 'lib-revenue-form',
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    InputComponent,
    ButtonComponent,
    SelectComponent
  ],
  templateUrl: './revenue-form.component.html',
  styleUrl: './revenue-form.component.css',
})
export class RevenueFormComponent implements OnInit, OnChanges {
  @Input() revenue: Revenue | undefined;
  @Input() loading = false;
  @Input() submitLabel = 'Cadastrar';

  @Output() revenueSubmit = new EventEmitter<Revenue>();

  revenueForm: FormGroup;

  sourceOptions: SelectOption[] = [
    { label: 'Salário', value: 'Salary' },
    { label: 'Bônus', value: 'Bonus' },
    { label: 'Investimento', value: 'Investment' },
    { label: 'Renda de Aluguel', value: 'RentalIncome' },
    { label: 'Outros', value: 'Other' }
  ];

  constructor() {
    this.revenueForm = new FormGroup({
      description: new FormControl('', { validators: [Validators.maxLength(300)], updateOn: 'blur' }),
      source: new FormControl('', {
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
      receiptUrl: new FormControl('', { validators: [Validators.maxLength(500)], updateOn: 'blur' }),
    });
  }

  ngOnInit(): void {
    if (this.revenue) this.updateRevenueData();
  }

  ngOnChanges(): void {
    if (this.revenue) this.updateRevenueData();

    if (this.loading) {
      this.revenueForm.disable();
    }    else {
      this.revenueForm.enable();
    }
  }

  get description(): FormControl {
    return this.revenueForm.get('description') as FormControl;
  }

  get source(): FormControl {
    return this.revenueForm.get('source') as FormControl;
  }

  get amount(): FormControl {
    return this.revenueForm.get('amount') as FormControl;
  }

  get date(): FormControl {
    return this.revenueForm.get('date') as FormControl;
  }

  get receiptUrl(): FormControl {
    return this.revenueForm.get('receiptUrl') as FormControl;
  }

  updateRevenueData(): void {
    if (!this.revenue) return;

    const selectedSource = this.sourceOptions.find(
      (option) => this.revenue && option.value === this.revenue.source
    );

    const formattedDate = this.formatDateToInput(this.revenue.date);

    this.revenueForm.patchValue({
      description: this.revenue.description ?? '',
      source: selectedSource ?? '',
      amount: this.revenue.amount ?? 0,
      date: formattedDate,
      receiptUrl: this.revenue.receiptUrl ?? '',
    });
  }

  onSubmit(){
    if (this.revenueForm.invalid) {
      return this.revenueForm.markAllAsTouched();
    }

    const revenue: Revenue = {
      id: this.revenue?.id || '',
      description: this.description.value,
      source: this.source.value.value,
      amount: this.amount.value,
      date: this.date.value,
      receiptUrl: this.receiptUrl.value,
      userId: this.revenue?.userId || '',
      createdAt: this.revenue?.createdAt || new Date(),
      updatedAt: new Date(),
    };
    
    this.revenueSubmit.emit(revenue);
  }

  private formatDateToInput(date: string | Date): string {
    const d = new Date(date);
    const year = d.getFullYear();
    const month = String(d.getMonth() + 1).padStart(2, '0');
    const day = String(d.getDate()).padStart(2, '0');
    return `${year}-${month}-${day}`;
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
}
