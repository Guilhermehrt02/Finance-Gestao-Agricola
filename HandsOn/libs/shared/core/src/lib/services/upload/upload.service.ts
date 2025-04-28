import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { RequestService } from '../request/request.service';

@Injectable({
  providedIn: 'root',
})
export class UploadService extends RequestService {  
    uploadFile(file: File) {
        const formData = new FormData();
        formData.append('file', file);

        return this.httpClient
            .post<string>(`${this.apiUrl}/upload/file`, formData, this.httpOptions)
            .pipe(catchError(this.handleError));
    }
//   uploadFile(file: File): Observable<{ path: string }> {
//     const formData = new FormData();
//     formData.append('file', file);

//     return this.httpClient
//       .post<{ path: string }>(`${this.apiUrl}/upload/file`, formData)
//       .pipe(catchError(this.handleError));
//   }
}
