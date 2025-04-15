import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportChartComponent } from '@farm/ui';
import { ReportComponentFacade } from './reports.facade.component';
import { ChartData } from 'chart.js';

@Component({
  selector: 'lib-reports',
  imports: [CommonModule, ReportChartComponent],
  templateUrl: './reports.component.html',
  styleUrl: './reports.component.css',
})
export class ReportsComponent implements OnInit{
  loading = false;
  
  expenseChartData: ChartData<'pie', number[], unknown> | null = {
    labels: [],
    datasets: [{ data: [], backgroundColor: [] }],
  };

  revenueChartData: ChartData<'pie', number[], unknown> | null = {
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
      const expenseData = chartData ?? [];
      this.expenseChartData = this.transformToChartData(expenseData);
    });

    this.facade.revenueChart$.subscribe((chartData) => {
      const revenueData = chartData ?? [];
      this.revenueChartData = this.transformToChartData(revenueData);
    });

    this.facade.load({
      startDate: new Date('2025-01-01'),  
      endDate: new Date()
    });  
  }

  transformToChartData(data: any[]): ChartData<'pie', number[], unknown> {
    return {
      labels: data.map(d => d.category || d.source),
      datasets: [
        {
          data: data.map(d => d.amount),
          backgroundColor: ['#42A5F5', '#66BB6A', '#FFA726', '#AB47BC', '#FF7043'],
        },
      ],
    };
  }
}
  