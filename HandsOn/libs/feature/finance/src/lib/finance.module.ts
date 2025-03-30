import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { financeRoutes } from './lib.routes';

@NgModule({
  imports: [CommonModule, RouterModule.forChild(financeRoutes)],
})
export class FinanceModule {}
