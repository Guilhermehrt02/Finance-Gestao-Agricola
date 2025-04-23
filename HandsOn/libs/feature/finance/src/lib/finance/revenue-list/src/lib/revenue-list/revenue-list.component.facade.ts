import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import {
    ConfirmationService,
    RevenueFacade,
    AuthFacade,
    RevenueSourceLabels,
} from '@farm/core';
import { Router } from '@angular/router';
import { Row, Action } from '@farm/ui';

@Injectable({
    providedIn: 'root',
})

export class RevenueListComponentFacade {
    private revenuesSubject = new BehaviorSubject<Row[]>([]);
    private loadingSubject = new BehaviorSubject<boolean>(false);

    userId: string | undefined;
    loading$: Observable<boolean> = this.loadingSubject.asObservable();
    revenues$: Observable<Row[]> = this.revenuesSubject.asObservable();

    constructor(
        private revenueFacade: RevenueFacade,
        private authFacade: AuthFacade,
        private confirmationService: ConfirmationService,
        private router: Router,
    ) {}

    load() {
        const data = this.authFacade.decodedToken;

        this.userId = data.nameid;
        
        this.loadingSubject.next(true);

        this.revenueFacade
            .getAllRevenues()
            .pipe(
                tap(
                    (revenues) => {
                        this.revenuesSubject.next(
                            revenues.map((revenue) => this.mapRevenueToRow(revenue)),
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

    private mapRevenueToRow(revenue: any): Row {
        return {
            ...revenue,
            source: RevenueSourceLabels[revenue.source as keyof typeof RevenueSourceLabels] || revenue.source,
            actions: [
                {
                    tooltip: 'Editar',
                    icon: 'pi pi-fw pi-pencil',
                    iconClass: 'primary',
                    routerLink: `/app/finance/revenues/${revenue.id}`,
                },
                {
                    tooltip: 'Excluir',
                    icon: 'pi pi-fw pi-trash',
                    iconClass: 'danger',
                    command: () => {
                        this.confirmationService.confirm({
                            header: "Excluir Receita",
                            message: 'Você tem certeza que deseja excluir esta receita?',
                            accept: () => {
                                this.revenueFacade.deleteRevenue(revenue.id).subscribe(() => {
                                    this.load();
                                });
                            },
                        });
                    },
                }
            ] as Action[],
        };
    }

    navegateToCreateRevenue(): void {
        this.router.navigate(['/app/finance/revenues/create']);
    }
}

    
