import { Injectable } from '@angular/core';
import { RequestService } from '../request/request.service';
import { HttpContext } from '@angular/common/http';
import { BYPASS_INTERCEPTORS } from '../../interceptors/authentication/authentication.interceptor';
import { catchError } from 'rxjs';
import { Observable } from 'rxjs';
import { ReportSummary } from '../../models/report-summary.model'; 
import { ReportFilters } from '../../models/report-filters.model';

@Injectable({
  providedIn: 'root',
})
export class ReportsService extends RequestService {
    httpOptionsBypassInterceptor = {
      ...this.httpOptions,
      context: new HttpContext().set(BYPASS_INTERCEPTORS, false),
    };
  
    fetchReportData(filters: ReportFilters): Observable<ReportSummary> {
      return this.httpClient
        .post<ReportSummary>(`${this.apiUrl}/reports`, filters, this.httpOptionsBypassInterceptor)
        .pipe(catchError(this.handleError));
    }
  }
