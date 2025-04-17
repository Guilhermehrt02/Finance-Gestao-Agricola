import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardModule } from 'primeng/card';

@Component({
  selector: 'lib-report-summary',
  imports: [CommonModule, CardModule],
  templateUrl: './report-summary.component.html',
  styleUrl: './report-summary.component.css',
})
export class ReportSummaryComponent {
  @Input() loading = false;
  @Input() title = '';
  @Input() totalExpenses = 0;
  @Input() totalRevenues = 0;
  @Input() totalBalance = 0;
}
