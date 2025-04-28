import { Injectable } from '@angular/core';
import { catchError } from 'rxjs';
import { RequestService } from '../request/request.service';
import { Expense } from '../../models/expense.model'; 
import { HttpContext } from '@angular/common/http';
import { BYPASS_INTERCEPTORS } from '../../interceptors/authentication/authentication.interceptor';

@Injectable({
    providedIn: 'root',
})
export class ExpenseService extends RequestService {
    httpOptionsBypassInterceptor = {
        ...this.httpOptions,
        context: new HttpContext().set(BYPASS_INTERCEPTORS, false),
    };
    
    getAllExpenses() {
        return this.httpClient
            .get<Expense[]>(`${this.apiUrl}/expense`, this.httpOptionsBypassInterceptor)
            .pipe(catchError(this.handleError));
    }

    getExpenseById(id: string) {
        return this.httpClient
            .get<Expense>(`${this.apiUrl}/expense/${id}`, this.httpOptions)
            .pipe(catchError(this.handleError));
    }
    
    createExpense(expense: Expense) {
        return this.httpClient
            .post<Expense>(`${this.apiUrl}/expense`, JSON.stringify(expense), this.httpOptions)
            .pipe(catchError(this.handleError));
    }

    updateExpense(expense: Expense) {
        return this.httpClient
            .put<Expense>(`${this.apiUrl}/expense/${expense.id}`, JSON.stringify(expense), this.httpOptions)
            .pipe(catchError(this.handleError));
    }

    deleteExpense(id: string) {
        return this.httpClient
            .delete<void>(`${this.apiUrl}/expense/${id}`, this.httpOptions)
            .pipe(catchError(this.handleError));
    }

}