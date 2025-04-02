import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import {
  Expense,
  ExpenseFacade,
  ConfirmationService,
  AuthenticationService,
} from '@farm/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class ExpenseComponentFacade {
    private expenseSubject = new BehaviorSubject<Expense | null>(null);
    private loadingSubject = new BehaviorSubject<boolean>(false);

    id: string | undefined;
    isOwnProfile = false;
    expense$: Observable<Expense | null> = this.expenseSubject.asObservable();
    loading$: Observable<boolean> = this.loadingSubject.asObservable();

    constructor(
        private authenticationService: AuthenticationService,
        private expenseFacade: ExpenseFacade,
        private confirmationService: ConfirmationService,
        private router: Router,
    ) {}

    load(id: string) {
        const data = this.authenticationService.decodedToken;

        this.id = id;
        this.isOwnProfile = data.nameid === id;

        this.loadingSubject.next(true);

        this.expenseFacade
            .getExpenseById(id)
            .pipe(
                tap(
                    (expense) => {
                        this.expenseSubject.next(expense);
                        this.loadingSubject.next(false);
                    },
                    (error) => {
                        const code = error.code;
                        if (code === 400 || code === 404) this.router.navigate(['/404']);
                    },
                ),
            )
            .subscribe();
    }

    reset() {
        this.expenseSubject.next(null);
    }

    submit(expense: Expense) {
        this.loadingSubject.next(true);

        if (this.id) {
            this.expenseFacade.updateExpense(expense).subscribe(() => {
                this.loadingSubject.next(false);
            });
        } else {
            this.expenseFacade.createExpense(expense).subscribe(() => {
                this.loadingSubject.next(false);
            });
        }
    }

    addExpense(expense: Expense) {
        this.loadingSubject.next(true);

        this.expenseFacade.createExpense(expense).subscribe(() => {
            this.router.navigate(['/app/finance/expenses']);
        });
    }

    updateExpense(expense: Expense) {
        this.loadingSubject.next(true);

        this.expenseFacade.updateExpense(expense).subscribe(() => {
            this.router.navigate(['/app/finance/expenses']);
        });
    }

    deleteExpense(id: string) {
        this.confirmationService.confirm({
            message: 'Você tem certeza que deseja excluir essa despesa?',
            accept: () => {
                this.expenseFacade.deleteExpense(id).subscribe(() => {
                    this.router.navigate(['/app/finance/expenses']);
                });
            },
        });
    } 
}