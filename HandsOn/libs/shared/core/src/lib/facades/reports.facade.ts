import { Injectable } from '@angular/core';
import { ReportsService } from '../services/reports/reports.service';
import { ReportSummary } from '../models/report-summary.model';
import { ReportFilters } from '../models/report-filters.model';
import { NotificationService } from '../services/notification/notification.service';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';

@Injectable({ 
    providedIn: 'root' 
})
export class ReportsFacade {
    private reportDataSubject = new BehaviorSubject<ReportSummary | null>(null);
    private loadingSubject = new BehaviorSubject<boolean>(true);
  
    reportData$: Observable<ReportSummary | null> = this.reportDataSubject.asObservable();
    loading$: Observable<boolean> = this.loadingSubject.asObservable();
  
    constructor(
      private reportsService: ReportsService,
      private notificationService: NotificationService
    ) {}
  
    getReportData(filters: ReportFilters): Observable<ReportSummary> {
      this.loadingSubject.next(true);
      return this.reportsService.fetchReportData(filters).pipe(
        tap({
          next: (data) => {
            this.reportDataSubject.next(data);
            this.loadingSubject.next(false);
          },
          error: () => {
            this.notificationService.error(
              'Erro!',
              'Não foi possível carregar os dados do relatório!'
            );
            this.loadingSubject.next(false);
          },
        })
      );
    }
  }