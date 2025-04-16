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
        color: '#374151',
      },
    };

    const commonScales = {
      x: {
        ticks: { color: '#374151' },
        grid: { color: '#E5E7EB' },
      },
      y: {
        ticks: { color: '#374151' },
        grid: { color: '#E5E7EB' },
      },
    };

    switch (type) {
      case 'pie':
      case 'doughnut':
      case 'polarArea':
        return {
          plugins: { legend: commonLegend },
          responsive: true,
        };

      case 'bar':
      case 'line':
      case 'radar':
        return {
          responsive: true,
          plugins: { legend: commonLegend },
          scales: commonScales,
        };

      default:
        return {
          responsive: true,
        };
    }
  }
}
