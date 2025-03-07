import { Injectable } from '@angular/core';
import {
  HttpInterceptor,
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpErrorResponse,
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { AuthenticationService } from '../../services';
import { BYPASS_INTERCEPTORS } from '@hands-on/interceptors';

@Injectable()
export class AuthenticationInterceptor implements HttpInterceptor {
  constructor(private authenticationService: AuthenticationService) {}

  intercept(
    request: HttpRequest<unknown>,
    next: HttpHandler
  ): Observable<HttpEvent<unknown>> {
    const token = this.authenticationService.token;
    const tokenExpired = this.authenticationService.tokenExpired;
    const bypassInterceptor = request.context.get(BYPASS_INTERCEPTORS);

    if (tokenExpired) this.authenticationService.logout();

    if (token && !bypassInterceptor) {
      request = request.clone({
        setHeaders: {
          Authorization: `Bearer ${token}`,
        },
      });
    }

    return next.handle(request).pipe(
      catchError((error: HttpErrorResponse) => {
        return throwError(error);
      })
    );
  }
}
