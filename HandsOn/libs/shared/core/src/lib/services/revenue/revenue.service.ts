import { Injectable } from '@angular/core';
import { RequestService } from '../request/request.service';
import { HttpContext } from '@angular/common/http';
import { BYPASS_INTERCEPTORS } from '../../interceptors/authentication/authentication.interceptor';
import { Revenue } from '../../models/revenue.model';
import { catchError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RevenueService extends RequestService {
  httpOptionsBypassInterceptor = {
      ...this.httpOptions,
      context: new HttpContext().set(BYPASS_INTERCEPTORS, false),
  };

  getAllRevenues() {
    return this.httpClient
      .get<Revenue[]>(`${this.apiUrl}/revenue`, this.httpOptionsBypassInterceptor) 
      .pipe(catchError(this.handleError));
  }

  getRevenueById(id: string) {
    return this.httpClient
      .get<Revenue>(`${this.apiUrl}/revenue/${id}`, this.httpOptions)
      .pipe(catchError(this.handleError));
  }

  createRevenue(revenue: Revenue) {
    return this.httpClient
      .post<Revenue>(`${this.apiUrl}/revenue`, JSON.stringify(revenue), this.httpOptions)
      .pipe(catchError(this.handleError));
  }

  updateRevenue(revenue: Revenue) {
    return this.httpClient
      .put<Revenue>(`${this.apiUrl}/revenue/${revenue.id}`, JSON.stringify(revenue), this.httpOptions)
      .pipe(catchError(this.handleError));
  }

  deleteRevenue(id: string) {
    return this.httpClient
      .delete<void>(`${this.apiUrl}/revenue/${id}`, this.httpOptions)
      .pipe(catchError(this.handleError));
  }
}
