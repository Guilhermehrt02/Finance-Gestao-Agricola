import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportChartComponent, ReportSummaryComponent } from '@farm/ui';
import { ReportComponentFacade } from './reports.facade.component';
import { ChartData } from 'chart.js';

@Component({
  selector: 'lib-reports',
  imports: [CommonModule, ReportChartComponent, ReportSummaryComponent],
  templateUrl: './reports.component.html',
  styleUrl: './reports.component.css',
})
export class ReportsComponent implements OnInit{
  loading = false;
  totalRevenues = 0;
  totalExpenses = 0;
  totalBalance = 0;
  
  expenseChartData: ChartData<'pie', number[], unknown> | null = {
    labels: [],
    datasets: [{ data: [], backgroundColor: [] }],
  };

  revenueChartData: ChartData<'pie', number[], unknown> | null = {
    labels: [],
    datasets: [{ data: [], backgroundColor: [] }],
  };

  barChartData: ChartData<'bar', number[], unknown> | null = {
    labels: [],
    datasets: [
      {
        label: 'Receita',
        data: [],
        backgroundColor: '#42A5F5', 
      },
      {
        label: 'Despesa',
        data: [],
        backgroundColor: '#FF7043',
      },
    ],
  };

  constructor(private facade: ReportComponentFacade) 
  {}

  ngOnInit(): void {
    this.facade.loading$.subscribe((loading) => {
      this.loading = loading;
    });

    this.facade.expenseAndRevenueData$.subscribe((data) => {
      this.expenseChartData = this.transformToChartData(data?.expenses || []);
      this.revenueChartData = this.transformToChartData(data?.revenues || []); 
      this.barChartData = this.transformToBarChartData(data?.revenueAndExpenseByPeriod || []);
      this.totalRevenues = data?.totalRevenues || 0;
      this.totalExpenses = data?.totalExpenses || 0;
      this.totalBalance = data?.totalBalance || 0;
    });

    this.facade.load({
      startDate: new Date('2024-01-01'),  
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
  
  transformToBarChartData(data: any[]): ChartData<'bar', number[], unknown> {
    const labels: string[] = [];
    const revenueData: number[] = [];
    const expenseData: number[] = [];

    data.forEach((item: any) => {
      const period = item.period; 
      const amount = item.amount;

      if (item.type === 'Receita') {
        revenueData.push(amount);
      } else if (item.type === 'Despesa') {
        expenseData.push(amount);
      }

      if (!labels.includes(period)) {
        labels.push(period);
      }
    });

    return {
      labels,
      datasets: [
        {
          label: 'Receita',
          data: revenueData,
          backgroundColor: '#42A5F5', // Cor para barras de receita
        },
        {
          label: 'Despesa',
          data: expenseData,
          backgroundColor: '#FF7043', // Cor para barras de despesa
        },
      ],
    };
  }
}
  