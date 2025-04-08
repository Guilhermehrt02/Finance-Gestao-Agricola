import { Route } from '@angular/router';

export const financeRoutes: Route[] = [
  {
    path: '',
    loadComponent: () =>
      import('./finance/finance.component').then((m) => m.FinanceComponent),
    children: [
      {
        path: '',
        redirectTo: 'revenues',
        pathMatch: 'full',
      },
      {
        path: 'expenses',
        loadChildren: () =>
          import('@farm/expenses-list').then((m) => m.expensesListRoutes),
      },
      {
        path: 'expenses/create',
        loadChildren: () =>
          import('@farm/expense').then((m) => m.expenseRoutes),
      },
      {
        path: 'expenses/:id',
        loadChildren: () =>
          import('@farm/expense').then((m) => m.expenseRoutes),
      },
      {
        path: 'revenues',
        loadChildren: () =>
          import('@farm/revenue-list').then((m) => m.revenueListRoutes),
      },
      {
        path: 'revenues/create',
        loadChildren: () =>
          import('@farm/revenue').then((m) => m.revenueRoutes),
      },
      {
        path: 'revenues/:id',
        loadChildren: () =>
          import('@farm/revenue').then((m) => m.revenueRoutes),
      }
    ],
  },
];
