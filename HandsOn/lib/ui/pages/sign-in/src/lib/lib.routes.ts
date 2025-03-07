import { Route } from '@angular/router';

export const signInRoutes: Route[] = [
  {
    path: '',
    loadComponent: () =>
      import('./sign-in/sign-in.component').then((m) => m.SignInComponent),
    children: [
      {
        path: '',
        loadComponent: () =>
          import('./sign-in/lib/sign-in/sign-in.component').then(
            (m) => m.SignInComponent
          ),
      },
      {
        path: 'forgot-password',
        loadComponent: () =>
          import(
            './sign-in/lib/forgot-password/forgot-password.component'
          ).then((m) => m.ForgotPasswordComponent),
      },
    ],
  },
];
