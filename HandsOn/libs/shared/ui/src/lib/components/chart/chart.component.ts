import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChartModule } from 'primeng/chart';
import { FloatLabel } from 'primeng/floatlabel';

@Component({
  selector: 'lib-chart',
  imports: [
    CommonModule, 
    ChartModule,
    FloatLabel],
  templateUrl: './chart.component.html',
  styleUrl: './chart.component.css',
})
export class ChartComponent {
  @Input() type: "bar" | "line" | "scatter" | "bubble" | "pie" | "doughnut" | "polarArea" | "radar" | undefined = "bar";
  @Input() data: any;
  @Input() options: any;
  @Input() loading = false;
  @Input() floatLabel = false;
  @Input() label = '';
  @Input() floatLabelType: 'in' | 'over' | 'on' = 'in';
  @Input() className = '';
}