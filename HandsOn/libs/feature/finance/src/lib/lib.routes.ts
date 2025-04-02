import { Route } from '@angular/router';

export const financeRoutes: Route[] = [
  { 
    path: '',
    loadComponent: () =>
    import('./finance/finance.component').then((m) => m.FinanceComponent),
    children: [
      {
        path: '',
        loadChildren: () =>
          import('@farm/expenses-list').then((m) => m.expensesListRoutes),
      }
    ],
  },
];
