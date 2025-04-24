import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportChartComponent, ReportSummaryComponent, DateRangeFilterComponent } from '@farm/ui';
import { ReportComponentFacade } from './reports.facade.component';
import { ChartData } from 'chart.js';
import { startOfMonth, endOfMonth } from 'date-fns';

@Component({
  selector: 'lib-reports',
  imports: [
    CommonModule, 
    ReportChartComponent, 
    ReportSummaryComponent, 
    DateRangeFilterComponent
  ],
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

    this.facade.load({
      startDate: startOfMonth(new Date()),
      endDate: endOfMonth(new Date())
    });  

    this.facade.expenseAndRevenueData$.subscribe((data) => {
      this.expenseChartData = this.transformToChartData(data?.expenses || []);
      this.revenueChartData = this.transformToChartData(data?.revenues || []); 
      this.barChartData = this.transformToBarChartData(data?.revenueAndExpenseByPeriod || []);
      this.totalRevenues = data?.totalRevenues || 0;
      this.totalExpenses = data?.totalExpenses || 0;
      this.totalBalance = data?.totalBalance || 0;
    });

  }

  onSubmit(filters: { startDate: string; endDate: string; category?: string[]; source?: string[] }) {
    this.facade.submit({
      startDate: new Date(filters.startDate),
      endDate: new Date(filters.endDate),
      category: filters.category,
      source: filters.source,
    });
  }  

  transformToChartData(data: any[]): ChartData<'pie', number[], unknown> {
    return {
      labels: data.map(d => d.label),
      datasets: [ 
        {
          data: data.map(d => d.amount),
          backgroundColor: [
            '#6BA368', // verde folha
            '#C9D6B8', // verde claro oliva
            '#FFD56B', // amarelo sol
            '#D98555', // laranja terroso
            '#A16E83', // vinho seco (remete à uva)
            '#8C6A5D', // marrom rústico
            '#B6C867', // verde trigo
            '#FFE6A7', // bege palha
            '#88AB75', // verde musgo
            '#DAA06D', // cor de barro
          ],
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
          backgroundColor: '#42A5F5', 
        },
        {
          label: 'Despesa',
          data: expenseData,
          backgroundColor: '#FF7043', 
        },
      ],
    };
  }
}
  