import { Route } from '@angular/router';

export const reportsRoutes: Route[] = [
  { 
    path: '', 
    loadComponent: () => import('@farm/report-dashboard').then(m => m.ReportDashboardComponent)
  },
];
