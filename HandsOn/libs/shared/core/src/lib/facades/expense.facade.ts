import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Expense} from '../models/expense.model';
import { NotificationService } from '../services/notification/notification.service';
import { ExpenseService } from '../services/expense/expense.service';

@Injectable({
    providedIn: 'root',
})

export class ExpenseFacade {
    private expenseSubject = new BehaviorSubject<Expense[] | null>(null);
    private loadingSubject = new BehaviorSubject<boolean>(true);

    expense$: Observable<Expense[] | null> = this.expenseSubject.asObservable();
    loading$: Observable<boolean> = this.loadingSubject.asObservable();

    constructor(
        private expenseService: ExpenseService,
        private notificationService: NotificationService,
    ) {}

    getAllExpenses(): Observable<Expense[]> {
        return this.expenseService.getAllExpenses().pipe(
            tap({
                next: (expenses) => {
                    this.expenseSubject.next(expenses);
                    this.loadingSubject.next(false);
                },
                error: () => {
                    this.notificationService.error(
                        'Erro!',
                        'Não foi possível carregar as despesas!'
                    );
                    this.loadingSubject.next(false);
                }
            })
        )
    }

    getExpenseById(id: string): Observable<Expense> {
        return this.expenseService.getExpenseById(id).pipe(
            tap({
                error: () => {
                    this.notificationService.error(
                        'Erro!',
                        'Não foi possível carregar a despesa!'
                    );
                }
            })
        );
    }
    
    createExpense(expense: Expense): Observable<Expense> {
        return this.expenseService.createExpense(expense).pipe(
            tap({
                next: () => {
                    this.notificationService.success(
                        'Sucesso!',
                        'Despesa criada com sucesso!'
                    );
                },
                error: () => {
                    this.notificationService.error(
                        'Erro!',
                        'Não foi possível criar a despesa!'
                    );
                }
            })
        );
    }

    updateExpense(expense: Expense): Observable<Expense> {
        return this.expenseService.updateExpense(expense).pipe(
            tap({
                next: () => {
                    this.notificationService.success(
                        'Sucesso!',
                        'Despesa atualizada com sucesso!'
                    );
                },
                error: () => {
                    this.notificationService.error(
                        'Erro!',
                        'Não foi possível atualizar a despesa!'
                    );
                }
            })
        );
    }
    
    deleteExpense(id: string): Observable<void> {
        return this.expenseService.deleteExpense(id).pipe(
            tap({
                next: () => {
                    this.notificationService.success(
                        'Sucesso!',
                        'Despesa excluída com sucesso!'
                    );
                    this.getAllExpenses();
                },
                error: () => {
                    this.notificationService.error(
                        'Erro!',
                        'Não foi possível excluir a despesa!'
                    );
                }
            })
        );
    }
}