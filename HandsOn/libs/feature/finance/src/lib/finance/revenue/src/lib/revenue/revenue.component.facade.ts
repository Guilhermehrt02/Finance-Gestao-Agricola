import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import {
  Revenue,
  RevenueFacade,
  ConfirmationService,
  AuthenticationService,
  UploadFacade,
} from '@farm/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class RevenueComponentFacade {
  private revenueSubject = new BehaviorSubject<Revenue | null>(null);
  private loadingSubject = new BehaviorSubject<boolean>(false);

  id: string | undefined;
  isOwnProfile = false;
  revenue$: Observable<Revenue | null> = this.revenueSubject.asObservable();
  loading$: Observable<boolean> = this.loadingSubject.asObservable();

  constructor(
    private authenticationService: AuthenticationService,
    private revenueFacade: RevenueFacade,
    private confirmationService: ConfirmationService,
    private uploadFacade: UploadFacade,
    private router: Router,
  ) {}

  load(id: string) {
    const data = this.authenticationService.decodedToken;

    this.id = id;
    this.isOwnProfile = data.nameid === id;

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

  submit(revenue: any) {
    this.loadingSubject.next(true);
    
    const receiptFile = revenue.receiptFile;

    const finalizeSubmit = (updatedRevenue: any) => {
      if (this.id) {
        this.revenueFacade.updateRevenue(updatedRevenue).subscribe(() => {
          this.loadingSubject.next(false);
          this.router.navigate(['/app/finance/revenues']);
        });
      } else {
        this.revenueFacade.createRevenue(updatedRevenue).subscribe(() => {
          this.loadingSubject.next(false);
          this.router.navigate(['/app/finance/revenues']);
        });
      }
    };

    if (receiptFile) {
      this.uploadFacade.uploadFile(receiptFile).subscribe({
        next: (uploadResponse) => {
          const receiptUrl = uploadResponse.fileUrl;

          const updatedRevenue = {
            ...revenue,
            receiptUrl,
            receiptFile: null,
          };

          finalizeSubmit(updatedRevenue);
        },
        error: () => {
          this.loadingSubject.next(false);
        },
      });
    } else {
      finalizeSubmit(revenue);
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
