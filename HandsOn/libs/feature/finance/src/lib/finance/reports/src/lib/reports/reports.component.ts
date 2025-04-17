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

    // this.facade.expenseChart$.subscribe((chartData) => {
    //   const expenseData = chartData ?? [];
    //   this.expenseChartData = this.transformToChartData(expenseData);
    //   this.updateBarChartData(); 
    // });

    // this.facade.revenueChart$.subscribe((chartData) => {
    //   const revenueData = chartData ?? [];
    //   this.revenueChartData = this.transformToChartData(revenueData);
    //   this.updateBarChartData();
    // });

    this.facade.expenseAndRevenueData$.subscribe((data) => {
      this.expenseChartData = this.transformToChartData(data?.expenses || []);
      this.revenueChartData = this.transformToChartData(data?.revenues || []);
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
  
  // updateBarChartData(): void {
  //   const expenseLabels = this.expenseChartData?.labels ?? [];
  //   const revenueLabels = this.revenueChartData?.labels ?? [];
  //   const labels = [...new Set([...expenseLabels, ...revenueLabels])];

  //   const expenseData = labels.map((label) => {
  //     const expense = this.expenseChartData?.datasets[0].data.find(
  //       (d: any, index: number) => (this.expenseChartData?.labels ?? [])[index] === label
  //     );
  //     return expense ?? 0; 
  //   });

  //   const revenueData = labels.map((label) => {
  //     const revenue = this.revenueChartData?.datasets[0].data.find(
  //       (d: any, index: number) => (this.revenueChartData?.labels ?? [])[index] === label
  //     );
  //     return revenue ?? 0; 
  //   });

  //   this.barChartData = {
  //     labels,
  //     datasets: [
  //       {
  //         label: 'Revenue',
  //         data: revenueData,
  //         backgroundColor: '#42A5F5', // Cor para barras de receita
  //       },
  //       {
  //         label: 'Expense',
  //         data: expenseData,
  //         backgroundColor: '#FF7043', // Cor para barras de despesa
  //       },
  //     ],
  //   };
  // }
}
  