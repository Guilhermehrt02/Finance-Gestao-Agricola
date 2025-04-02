import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'lib-finance',
  imports: [CommonModule, RouterModule],
  templateUrl: './finance.component.html',
  styleUrl: './finance.component.css',
})
export class FinanceComponent {}
