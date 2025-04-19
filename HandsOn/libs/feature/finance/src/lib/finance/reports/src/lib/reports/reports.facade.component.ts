import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { 
    ReportInput,
    ReportFacade,
    ReportData,
} from '@farm/core';
import { Router } from '@angular/router';

@Injectable({ providedIn: 'root' })
export class ReportComponentFacade {
    private loadingSubject = new BehaviorSubject<boolean>(false);

    private revenueAndExpenseSubject = new BehaviorSubject<ReportData | null>(null);

    loading$: Observable<boolean> = this.loadingSubject.asObservable();
    expenseAndRevenueData$: Observable<ReportData | null> = this.revenueAndExpenseSubject.asObservable();

    constructor(
        private reportFacade: ReportFacade,
        private router: Router,
    ) {}

    load(reportInput: ReportInput) {
        this.loadingSubject.next(true);

        this.reportFacade
            .getReportData(reportInput)
            .pipe(
                tap(
                    (reportData) => {
                        this.revenueAndExpenseSubject.next(reportData || []);
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

    submit(reportInput: ReportInput) {
        this.load(reportInput);
    }
}
