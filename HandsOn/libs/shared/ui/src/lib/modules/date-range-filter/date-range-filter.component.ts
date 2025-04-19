import { Component, EventEmitter, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { subMonths, startOfMonth, endOfMonth, startOfYear, endOfYear } from 'date-fns';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'lib-date-range-filter',
  imports: [CommonModule],
  templateUrl: './date-range-filter.component.html',
  styleUrls: ['./date-range-filter.component.css'],
  standalone: true,
})
export class DateRangeFilterComponent {
  @Output() dateRangeChange = new EventEmitter<{ startDate: string; endDate: string }>();

  form: FormGroup;
  selectedOption = 'thisMonth';
  showCustomPicker = false;

  constructor(/*private fb: FormBuilder*/) {
    // const today = new Date();
    // this.form = this.fb.group({
    //   startDate: [this.formatDate(startOfMonth(today))],
    //   endDate: [this.formatDate(endOfMonth(today))],
    // });

    // this.emitFormValues();

    this.form = new FormGroup({
      startDate: new FormBuilder().control(this.formatDate(startOfMonth(new Date()))),
      endDate: new FormBuilder().control(this.formatDate(endOfMonth(new Date()))),
    });

    this.emitFormValues();
  }

  selectPredefined(option: string) {
    this.selectedOption = option;
    this.showCustomPicker = false;

    const today = new Date();
    let startDate: Date;
    let endDate: Date = today;

    switch (option) {
      case 'thisMonth':
        startDate = startOfMonth(today);
        endDate = endOfMonth(today);
        break;
      case 'lastMonth':
        startDate = startOfMonth(subMonths(today, 1));
        endDate = endOfMonth(subMonths(today, 1));
        break;
      case 'thisYear':
        startDate = startOfYear(today);
        endDate = endOfYear(today);
        break;
      case 'last12Months':
        startDate = subMonths(today, 12);
        break;
      default:
        return;
    }

    this.form.patchValue({
      startDate: this.formatDate(startDate),
      endDate: this.formatDate(endDate),
    });

    this.emitFormValues();
  }

  toggleCustomPicker() {
    this.selectedOption = '';
    this.showCustomPicker = !this.showCustomPicker;
  }

  onCustomDateChange() {
    this.emitFormValues();
  }

  private emitFormValues() {
    const { startDate, endDate } = this.form.value;
    this.dateRangeChange.emit({
      startDate,
      endDate,
    });
  }

  private formatDate(date: Date): string {
    return date.toISOString().split('T')[0];
  }
}
