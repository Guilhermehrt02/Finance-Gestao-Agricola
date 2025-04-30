import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { UploadService } from '../services/upload/upload.service';

@Injectable({
  providedIn: 'root',
})
export class UploadFacade {
  private uploadSubject = new BehaviorSubject<string | null>(null);
  private loadingSubject = new BehaviorSubject<boolean>(false);

  upload$: Observable<string | null> = this.uploadSubject.asObservable();
  loading$: Observable<boolean> = this.loadingSubject.asObservable();

  constructor(private uploadService: UploadService) {}

  uploadFile(file: File): Observable<any> {
    this.loadingSubject.next(true);

    return this.uploadService.uploadFile(file).pipe(
      tap({
        next: (reponse) => {
          const fileUrl = reponse.FileUrl;
          console.log('Upload sucesso:', fileUrl);
          this.uploadSubject.next(fileUrl);
          this.loadingSubject.next(false);
        },
        error: (error) => {
          console.error('Erro no upload:', error);
          this.loadingSubject.next(false);
        },
      })
    );
  }
}