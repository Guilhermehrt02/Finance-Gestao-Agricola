import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { UploadService } from '../services/upload/upload.service';

@Injectable({
  providedIn: 'root',
})
/// This facade handles the upload of files and manages the loading state and file URL.
export class UploadFacade {
  /// The uploadSubject is a BehaviorSubject that holds the URL of the uploaded file.
  private uploadSubject = new BehaviorSubject<string | null>(null);
  /// The loadingSubject is a BehaviorSubject that holds the loading state of the upload process.
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
          
          this.uploadSubject.next(fileUrl);
          this.loadingSubject.next(false);
        },
        error: () => {
          
          this.loadingSubject.next(false);
        },
      })
    );
  }
}