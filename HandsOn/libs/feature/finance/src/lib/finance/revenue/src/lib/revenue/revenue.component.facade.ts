import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import {
  Revenue,
  RevenueFacade,
  ConfirmationService,
  AuthenticationService,
} from '@farm/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})

export class RevenueComponentFacade {
    private revenueSubject = new BehaviorSubject<Revenue | null>(null);
    private loadingSubject = new BehaviorSubject<boolean>(false);

    id: string | undefined;
    revenue$: Observable<Revenue | null> = this.revenueSubject.asObservable();
    loading$: Observable<boolean> = this.loadingSubject.asObservable();

    constructor(
        private authenticationService: AuthenticationService,
        private revenueFacade: RevenueFacade,
        private confirmationService: ConfirmationService,
        private router: Router,
    ) {}

    load(id: string) {
        this.id = id;

        this.loadingSubject.next(true);

        this.revenueFacade
            .getRevenueById(id)
            .pipe(
                tap(
                    (revenue) => {
                        this.revenueSubject.next(revenue);
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
        this.revenueSubject.next(null);
    }

    submit(revenue: Revenue) {
        this.loadingSubject.next(true);

        if (this.id) {
            this.revenueFacade.updateRevenue(revenue).subscribe(() => {
                this.loadingSubject.next(false);
            });
        } else {
            this.revenueFacade.createRevenue(revenue).subscribe(() => {
                this.loadingSubject.next(false);
            });
        }
    }

    addRevenue(revenue: Revenue) {
        this.loadingSubject.next(true);

        this.revenueFacade.createRevenue(revenue).subscribe(() => {
            this.router.navigate(['/app/finance/revenues']);
        });
    }

    updateRevenue(revenue: Revenue) {
        this.loadingSubject.next(true);

        this.revenueFacade.updateRevenue(revenue).subscribe(() => {
            this.router.navigate(['/app/finance/revenues']);
        });
    }

    deleteRevenue(id: string) {
        this.confirmationService.confirm({
            message: 'Você tem certeza que deseja excluir essa receita?',
            accept: () => {
                this.loadingSubject.next(true);
                this.revenueFacade.deleteRevenue(id).subscribe(() => {
                    this.router.navigate(['/app/finance/revenues']);
                    this.loadingSubject.next(false);
                });
            },
        });
    }
}