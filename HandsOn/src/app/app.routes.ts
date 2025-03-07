import { Route } from '@angular/router';

export const appRoutes: Route[] = [
  {
    path: '',
    loadChildren: () => import('@hands-on/home').then((m) => m.homeRoutes),
  },
  {
    path: 'sign-in',
    loadChildren: () => import('@hands-on/sign-in').then((m) => m.signInRoutes),
  },
  {
    path: 'sign-up',
    loadChildren: () => import('@hands-on/sign-up').then((m) => m.signUpRoutes),
  },
  {
    path: 'change-password',
    loadChildren: () =>
      import('@hands-on/change-password').then((m) => m.changePasswordRoutes),
  },
  {
    path: 'farm',
    loadChildren: () =>
      import('lib/ui/template/master-page/src/').then(
        (m) => m.masterPageRoutes
      ),
  },
];
