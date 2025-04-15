import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ExpenseChartComponent } from '@farm/ui';
import { ExpenseData } from '@farm/core';
import { ReportComponentFacade } from './reports.facade.component';
import { ChartData } from 'chart.js';

@Component({
  selector: 'lib-reports',
  imports: [CommonModule, ExpenseChartComponent],
  templateUrl: './reports.component.html',
  styleUrl: './reports.component.css',
})
export class ReportsComponent implements OnInit{
  loading = false;
  
  expenseChartData: ChartData<'pie', number[], unknown> | null = {
    labels: [],
    datasets: [{ data: [], backgroundColor: [] }],
  };

  constructor(private facade: ReportComponentFacade) 
  {}

  ngOnInit(): void {
    this.facade.loading$.subscribe((loading) => {
      this.loading = loading;
    });

    this.facade.expenseChart$.subscribe((chartData) => {
      const data = chartData ?? [];
      this.expenseChartData = this.transformToChartData(data);
    });

    this.facade.load({
      startDate: new Date('2025-01-01'),  
      endDate: new Date()
    });  
  }

  transformToChartData(data: ExpenseData[]): ChartData<'pie', number[], unknown> {
    return {
      labels: data.map(d => d.category),
      datasets: [
        {
          data: data.map(d => d.amount),
          backgroundColor: ['#42A5F5', '#66BB6A', '#FFA726', '#AB47BC', '#FF7043'],
        },
      ],
    };
  }
}
  