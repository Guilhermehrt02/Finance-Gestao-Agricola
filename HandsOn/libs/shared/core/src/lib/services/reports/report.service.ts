import { Injectable } from '@angular/core';
import { RequestService } from '../request/request.service';
import { HttpContext } from '@angular/common/http';
import { BYPASS_INTERCEPTORS } from '../../interceptors/authentication/authentication.interceptor';
import { catchError } from 'rxjs';
import { ReportData } from '../../models/report-data.model'; 
import { ReportInput } from '../../models/report-input.model';
import { HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class ReportService extends RequestService {
    httpOptionsBypassInterceptor = {
      ...this.httpOptions,
      context: new HttpContext().set(BYPASS_INTERCEPTORS, false),
    };
  
    fetchReportData(reportInput: ReportInput) {
      let params = new HttpParams()
        .set('startDate', this.formatDate(reportInput.startDate))
        .set('endDate', this.formatDate(reportInput.endDate));

      if (reportInput.category?.length) {
        reportInput.category.forEach(cat => {
          params = params.append('category', cat);
        });
      }

      if (reportInput.source?.length) {
        reportInput.source.forEach(src => {
          params = params.append('source', src);
        });
      }
    
      return this.httpClient
        .get<ReportData>(`${this.apiUrl}/report`, {
          ...this.httpOptionsBypassInterceptor,
          params,
        })
        .pipe(catchError(this.handleError));
    }

    private formatDate(date: Date): string {
      if (!(date instanceof Date)) return '';
      const year = date.getFullYear();
      const month = `${date.getMonth() + 1}`.padStart(2, '0');
      const day = `${date.getDate()}`.padStart(2, '0');
      return `${year}-${month}-${day}`;
    }
  }
