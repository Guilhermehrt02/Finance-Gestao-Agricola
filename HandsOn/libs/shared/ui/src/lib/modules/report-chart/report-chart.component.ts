import { Component, OnInit, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChartModule } from 'primeng/chart';
import {
  ChartData,
  ChartOptions,
  ChartType,
  registerables,
  Chart,
} from 'chart.js';

@Component({
  selector: 'lib-report-chart',
  standalone: true,
  imports: [CommonModule, ChartModule],
  templateUrl: './report-chart.component.html',
  styleUrl: './report-chart.component.css',
})
export class ReportChartComponent implements OnInit {
  @Input() data: ChartData | null = null;
  @Input() options: ChartOptions = {};
  @Input() type: ChartType = 'pie';
  @Input() label = '';
  @Input() loading = false;
  @Input() className = 'w-full max-w-xl h-80 mx-auto';

  ngOnInit(): void {
    Chart.register(...registerables);

    this.options = this.getChartOptions(this.type);
  }

  private getChartOptions(type: ChartType): ChartOptions {
    const commonLegend = {
      position: 'bottom' as const,
      labels: {
        color: '#ffffff',
        font: {
          size: 14,
          weight: 'bold' as const,
        },
      },
    };

    const commonTitle = {
      display: !!this.label,
      text: this.label,
      color: '#ffffff',
      font: {
        size: 18,
        weight: 'bold' as const,
      },
      padding: {
        top: 10,
        bottom: 20,
      },
    };

    const commonTooltip = {
      callbacks: {
        label: (ctx: any) => {
          const label = ctx.dataset?.label || ctx.label || '';
          const value = ctx.raw;
          return `${label}: R$ ${(+value).toLocaleString('pt-BR')}`;
        },
      },
    };

    const commonScales = {
      x: {
        ticks: { color: '#ffffff' },
        grid: { color: 'rgba(255, 255, 255, 0.1)' },
      },
      y: {
        ticks: {
          color: '#ffffff',
          callback: (value: any) => `R$ ${(+value).toLocaleString('pt-BR')}`,
        },
        grid: { color: 'rgba(255, 255, 255, 0.1)' },
      },
    };

    if (type === 'pie' || type === 'doughnut' || type === 'polarArea') {
      return {
        responsive: true,
        plugins: {
          legend: commonLegend,
          title: commonTitle,
          tooltip: commonTooltip,
        },
      };
    }

    if (type === 'bar' || type === 'line' || type === 'radar') {
      return {
        responsive: true,
        plugins: {
          legend: commonLegend,
          title: commonTitle,
          tooltip: commonTooltip,
        },
        scales: commonScales,
      };
    }

    return {
      responsive: true,
      plugins: {
        legend: commonLegend,
        title: commonTitle,
      },
    };
  }

  hasData(): boolean {
    return (
      this.data !== null &&
      this.data.datasets &&
      this.data.datasets[0]?.data?.some((value) => typeof value === 'number' && value > 0)
    );
  }
}
