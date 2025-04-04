import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import {
  ConfirmationService,
  ExpenseFacade,
  AuthFacade
} from '@farm/core';
import { Row, Action } from '@farm/ui';

@Injectable({
    providedIn: 'root',
})
export class ExpensesListComponentFacade {
    private expensesSubject = new BehaviorSubject<Row[]>([]);
    private loadingSubject = new BehaviorSubject<boolean>(false);

    userId: string | undefined;
    loading$: Observable<boolean> = this.loadingSubject.asObservable();
    expenses$: Observable<Row[]> = this.expensesSubject.asObservable();

    constructor(
        private expenseFacade: ExpenseFacade,
        private authFacade: AuthFacade,
        private confirmationService: ConfirmationService,
    ) {}

    load() {
        const data = this.authFacade.decodedToken;

        this.userId = data.nameid;
        
        this.loadingSubject.next(true);

        this.expenseFacade
            .getAllExpenses()
            .pipe(
                tap(
                    (expenses) => {
                        this.expensesSubject.next(
                            expenses.map((expense) => this.mapExpenseToRow(expense)),
                        );
                        this.loadingSubject.next(false);
                    },
                    () => {
                        this.loadingSubject.next(false);
                    },
                ),
            )
            .subscribe();
        }

    private mapExpenseToRow(expense: any): Row {
        return {
            ...expense,
            actions: [
                {
                    tooltip: 'Editar',
                    icon: 'pi pi-fw pi-pencil',
                    iconClass: 'primary',
                    routerLink: `/app/finance/expenses/${expense.id}`,
                },
                {
                    tooltip: 'Excluir',
                    icon: 'pi pi-fw pi-trash',
                    iconClass: 'danger',
                    action: () => {
                        console.log('Botão de excluir clicado!', expense.id); 
                        
                        this.confirmationService.confirm({
                            message: 'Você tem certeza que deseja excluir esta despesa?',
                            accept: () => {
                                this.expenseFacade.deleteExpense(expense.id).subscribe(() => {
                                    this.expensesSubject.next(
                                        this.expensesSubject.value.filter((e) => e['id'] !== expense.id),
                                    );
                                });
                            },
                        });
                    },
                }
            ] as Action[],
        };
    }
}