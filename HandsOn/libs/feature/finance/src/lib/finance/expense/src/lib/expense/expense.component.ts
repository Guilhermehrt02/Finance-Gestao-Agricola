import { Component, OnDestroy, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { CardComponent, ExpenseFormComponent } from '@farm/ui';
import { ExpenseComponentFacade } from './expense.component.facade';
import { Expense } from '@farm/core';
@Component({
  selector: 'lib-expense',
  imports: [CommonModule, CardComponent, ExpenseFormComponent, RouterModule],
  templateUrl: './expense.component.html',
  styleUrl: './expense.component.css',
})
export class ExpenseComponent implements OnInit, OnDestroy {
  id: string | undefined;
  expense: Expense | undefined;
  loading = false;

  title = 'Criar Despesa';
  description = 'Preencha os campos abaixo para criar uma nova despesa';
  submitLabel = 'Cadastrar';

  constructor(
    private route: ActivatedRoute,
    private facade: ExpenseComponentFacade
  ) {}

  ngOnInit() {

    this.facade.expense$.subscribe((expense) => {
      if (!expense) return;

      this.expense = expense;
    });

    this.facade.loading$.subscribe((loading) => {
      this.loading = loading;
    });
  }

  ngOnDestroy() {
    this.facade.reset();
  }

  onSubmit(expense: Expense) {
    this.facade.submit(expense);
  }

}
