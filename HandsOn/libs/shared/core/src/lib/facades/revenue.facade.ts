import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Revenue} from '../models/revenue.model';
import { NotificationService } from '../services/notification/notification.service';
import { RevenueService } from '../services/revenue/revenue.service';

@Injectable({
    providedIn: 'root',
})

export class RevenueFacade {
    private revenueSubject = new BehaviorSubject<Revenue[] | null>(null);
    private loadingSubject = new BehaviorSubject<boolean>(true);

    revenue$: Observable<Revenue[] | null> = this.revenueSubject.asObservable();
    loading$: Observable<boolean> = this.loadingSubject.asObservable();

    constructor(
        private revenueService: RevenueService,
        private notificationService: NotificationService,
    ) {}

    getAllRevenues(): Observable<Revenue[]> {
        return this.revenueService.getAllRevenues().pipe(
            tap({
                next: (revenues) => {
                    this.revenueSubject.next(revenues);
                    this.loadingSubject.next(false);
                },
                error: () => {
                    this.notificationService.error(
                        'Erro!',
                        'Não foi possível carregar as receitas!'
                    );
                    this.loadingSubject.next(false);
                }
            })
        )
    }

    getRevenueById(id: string): Observable<Revenue> {
        return this.revenueService.getRevenueById(id).pipe(
            tap({
                error: () => {
                    this.notificationService.error(
                        'Erro!',
                        'Não foi possível carregar a receita!'
                    );
                }
            })
        );
    }

    createRevenue(revenue: Revenue): Observable<Revenue> {
        return this.revenueService.createRevenue(revenue).pipe(
            tap({
                next: () => {
                    this.notificationService.success(
                        'Sucesso!',
                        'Receita criada com sucesso!'
                    );
                },
                error: () => {
                    this.notificationService.error(
                        'Erro!',
                        'Não foi possível criar a receita!'
                    );
                }
            })
        );
    }

    updateRevenue(revenue: Revenue): Observable<Revenue> {
        return this.revenueService.updateRevenue(revenue).pipe(
            tap({
                next: () => {
                    this.notificationService.success(
                        'Sucesso!',
                        'Receita atualizada com sucesso!'
                    );
                },
                error: () => {
                    this.notificationService.error(
                        'Erro!',
                        'Não foi possível atualizar a receita!'
                    );
                }
            })
        );
    }

    deleteRevenue(id: string): Observable<void> {
        return this.revenueService.deleteRevenue(id).pipe(
            tap({
                next: () => {
                    this.notificationService.success(
                        'Sucesso!',
                        'Receita deletada com sucesso!'
                    );
                },
                error: () => {
                    this.notificationService.error(
                        'Erro!',
                        'Não foi possível deletar a receita!'
                    );
                }
            })
        );
    }
}
