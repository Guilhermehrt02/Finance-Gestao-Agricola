import { Component, OnInit, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChartModule } from 'primeng/chart';
import { ChartData, ChartOptions } from 'chart.js';

@Component({
  selector: 'lib-expense-chart',
  imports: [CommonModule, ChartModule],
  templateUrl: './expense-chart.component.html',
  styleUrl: './expense-chart.component.css',
})
export class ExpenseChartComponent implements OnInit {
  @Input() data: ChartData<'pie', number[], unknown> | null = null;
  @Input() options: ChartOptions = {};
  @Input() type: 'pie' | 'doughnut' | 'bar' | 'line' | 'polarArea' | 'radar' = 'pie';
  @Input() label = '';
  @Input() loading = false;
  @Input() className = 'w-full max-w-xl h-80 mx-auto';

  ngOnInit(): void {
    if (this.type === 'pie' || this.type === 'doughnut') {
      this.options = {
        ...this.options,
        plugins: {
          ...this.options.plugins,
          legend: {
            position: 'bottom',
            labels: {
              color: '#374151', 
            },
          },
        },
        scales: {
          x: { display: false },
          y: { display: false },
        },
      };
    }
  }
}
