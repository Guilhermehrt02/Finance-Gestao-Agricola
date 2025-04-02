import { Route } from '@angular/router';
import { ExpensesListComponent } from './expenses-list/expenses-list.component';

export const expensesListRoutes: Route[] = [
  { path: '', component: ExpensesListComponent },
];
