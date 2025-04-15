import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { 
    ExpenseData,
    ReportInput,
    ReportFacade,
    RevenueData,
    // RevenueSourceSummary, 
    // Summary 
} from '@farm/core';
import { Router } from '@angular/router';

@Injectable({ providedIn: 'root' })
export class ReportComponentFacade {
    private loadingSubject = new BehaviorSubject<boolean>(false);

    private expenseChartSubject = new BehaviorSubject<ExpenseData[]>([]);
    private revenueChartSubject = new BehaviorSubject<RevenueData[]>([]);
//   private summarySubject = new BehaviorSubject<Summary | null>(null);

    loading$: Observable<boolean> = this.loadingSubject.asObservable();
    expenseChart$: Observable<ExpenseData[] | null> = this.expenseChartSubject.asObservable();
    revenueChart$: Observable<RevenueData[] | null> = this.revenueChartSubject.asObservable();

//   revenueChart$ = this.revenueChartSubject.asObservable();
//   summary$ = this.summarySubject.asObservable();

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
                        this.expenseChartSubject.next(reportData.expenses || []);
                        this.revenueChartSubject.next(reportData.revenues || []);
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
}
