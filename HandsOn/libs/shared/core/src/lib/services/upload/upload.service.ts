import { Injectable } from '@angular/core';
import { catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';
import { RequestService } from '../request/request.service';

@Injectable({
  providedIn: 'root',
})
/// This service handles the upload of files to the server.
export class UploadService extends RequestService {  
    uploadFile(file: File) {
        const formData = new FormData();
        formData.append('file', file);

        return this.httpClient
          .post<{ FileUrl : string }>(`${this.apiUrl}/upload/file`, formData)
          .pipe(
            catchError((error) => {
              return throwError(() => error);
            })
          );
    }
}
