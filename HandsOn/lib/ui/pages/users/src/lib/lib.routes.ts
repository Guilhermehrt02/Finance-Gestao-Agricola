import { Route } from '@angular/router';

export const usersRoutes: Route[] = [
  {
    path: '',
    loadComponent: () =>
      import('./users/users.component').then((m) => m.UsersComponent),
    children: [
      {
        path: '',
        pathMatch: 'full',
        redirectTo: 'list',
      },
      {
        path: 'list',
        loadChildren: () =>
          import('@hands-on/users-list').then((m) => m.usersListRoutes),
      },
      {
        path: '**',
        loadChildren: () => import('@hands-on/user').then((m) => m.userRoutes),
      },
    ],
  },
];
