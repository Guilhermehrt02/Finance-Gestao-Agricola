import { Component, EventEmitter, Output, OnInit } from '@angular/core';
import {
  FormControl,
  FormGroup,
  Validators,
  AbstractControl,
  ValidationErrors,
} from '@angular/forms';
import {
  subMonths,
  startOfMonth,
  endOfMonth,
  startOfYear,
  endOfYear,
  format,
} from 'date-fns';
import { CommonModule } from '@angular/common';
import {
  SelectComponent,
  SelectOption,
} from '../../components/select/select.component';
import { ButtonComponent } from '../../components/button/button.component';
import { InputComponent } from '../../components/input/input.component';
import { ExpenseCategoryLabels } from '@farm/core';
import { RevenueSourceLabels } from '@farm/core';

const expenseCategoryOptions: SelectOption[] = Object.entries(
  ExpenseCategoryLabels,
).map(([value, label]) => ({ value, label }));

const revenueSourceOptions: SelectOption[] = Object.entries(
  RevenueSourceLabels,
).map(([value, label]) => ({ value, label }));

@Component({
  selector: 'lib-date-range-filter',
  imports: [CommonModule, SelectComponent, ButtonComponent, InputComponent],
  templateUrl: './date-range-filter.component.html',
  styleUrls: ['./date-range-filter.component.css'],
  standalone: true,
})
export class DateRangeFilterComponent implements OnInit {
  @Output() dateRangeChange = new EventEmitter<{
    startDate: string;
    endDate: string;
    category?: string[];
    source?: string[];
  }>();

  expenseCategories = expenseCategoryOptions;
  revenueSources = revenueSourceOptions;

  form: FormGroup;
  selectedOption = 'thisMonth';
  showCustomPicker = false;

  constructor() {
    this.form = new FormGroup(
      {
        startDate: new FormControl('', {
          validators: [Validators.required],
          updateOn: 'blur',
        }),
        endDate: new FormControl('', {
          validators: [Validators.required, this.dateRangeValidator],
          updateOn: 'blur',
        }),
        category: new FormControl([], { validators: [], updateOn: 'blur' }),
        source: new FormControl([], { validators: [], updateOn: 'blur' }),
      },
      {
        validators: this.dateRangeValidator.bind(this),
      },
    );
  }

  get startDate(): FormControl {
    return this.form.get('startDate') as FormControl;
  }
  get endDate(): FormControl {
    return this.form.get('endDate') as FormControl;
  }
  get category(): FormControl {
    return this.form.get('category') as FormControl;
  }
  get source(): FormControl {
    return this.form.get('source') as FormControl;
  }
  get startDatePlaceholder(): string {
    return this.form.get('startDate')?.value
      ? format(this.form.get('startDate')?.value, 'yyyy/MM/dd')
      : 'Data Inicial';
  }

  get endDatePlaceholder(): string {
    return this.form.get('endDate')?.value
      ? format(this.form.get('endDate')?.value, 'yyyy/MM/dd')
      : 'Data Final';
  }

  ngOnInit() {
    this.selectPredefined(this.selectedOption);
    this.updateDataRange();
  }

  updateDataRange() {
    this.form.patchValue({
      startDate: this.formatDate(this.startDate.value) ?? '',
      endDate: this.formatDate(this.endDate.value) ?? '',
      category: this.category.value ?? [],
      source: this.source.value ?? [],
    });

    this.emitFormValues();
  }

  selectPredefined(option: string) {
    this.selectedOption = option;
    this.showCustomPicker = false;

    const today = new Date();
    const formatDate = (date: Date) => format(date, 'yyyy-MM-dd');

    this.endDate.setValue(formatDate(today));

    switch (option) {
      case 'thisMonth':
        this.startDate.setValue(formatDate(startOfMonth(today)));
        this.endDate.setValue(formatDate(endOfMonth(today)));
        break;
      case 'lastMonth':
        this.startDate.setValue(formatDate(startOfMonth(subMonths(today, 1))));
        this.endDate.setValue(formatDate(endOfMonth(subMonths(today, 1))));
        break;
      case 'thisYear':
        this.startDate.setValue(formatDate(startOfYear(today)));
        this.endDate.setValue(formatDate(endOfYear(today)));
        break;
      case 'last12Months':
        this.startDate.setValue(formatDate(subMonths(today, 12)));
        break;
      default:
        return;
    }

    this.updateDataRange();
  }

  toggleCustomPicker() {
    this.selectedOption = '';
    this.showCustomPicker = !this.showCustomPicker;
  }

  onCustomDateChange() {
    this.updateDataRange();
  }

  private emitFormValues() {
    const { startDate, endDate, category, source } = this.form.value;
    this.dateRangeChange.emit({
      startDate,
      endDate,
      category: category?.map((c: SelectOption) => c.value),
      source: source?.map((s: SelectOption) => s.value),
    });
  }

  private formatDate(date: string | Date): string {
    if (!date) return '';
    if (typeof date === 'string') return date;
    return date.toISOString().split('T')[0];
  }

  dateRangeValidator(group: AbstractControl): ValidationErrors | null {
    const start = group.get('startDate')?.value;
    const end = group.get('endDate')?.value;
  
    if (start && end && new Date(end) < new Date(start)) {
      group.get('endDate')?.setErrors({ dateRangeInvalid: true });
      return { dateRangeInvalid: true };
    }
  
    if (group.get('endDate')?.hasError('dateRangeInvalid')) {
      const errors = { ...group.get('endDate')?.errors };
      delete errors['dateRangeInvalid'];
      const hasOtherErrors = Object.keys(errors).length > 0;
  
      group.get('endDate')?.setErrors(hasOtherErrors ? errors : null);
    }
  
    return null;
  }
  
}
