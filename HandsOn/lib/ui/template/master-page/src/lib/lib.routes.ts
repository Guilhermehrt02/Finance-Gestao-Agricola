import { Route } from '@angular/router';

export const masterPageRoutes: Route[] = [
  {
    path: '',
    loadComponent: () =>
      import('./master-page/master-page.component').then(
        (m) => m.MasterPageComponent
      ),
    children: [
      {
        path: 'users',
        loadChildren: () =>
          import('@hands-on/users').then((m) => m.usersRoutes),
      },
      {
        path: 'settings',
        loadChildren: () =>
          import('@hands-on/settings').then((m) => m.settingsRoutes),
      },
    ],
  },
];
