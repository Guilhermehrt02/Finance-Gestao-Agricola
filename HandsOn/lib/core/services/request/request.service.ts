import { Injectable } from '@angular/core';
import { HttpContext, HttpErrorResponse } from '@angular/common/http';
import { throwError } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { HttpHeaders } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';
import { environments } from 'src/app/environments/environments';

@Injectable({
  providedIn: 'root',
})
export class RequestService {
  authApiUrl = environments.authenticationApi;
  usersApiUrl = environments.usersApi;

  public constructor(
    public httpClient: HttpClient,
    public router: Router,
    public jwtHelper: JwtHelperService
  ) {}

  public httpOptions: {
    headers?: HttpHeaders;
    context?: HttpContext;
  } = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'Cache-Control': 'no-cache',
    }),
  };

  public handleError(error: HttpErrorResponse) {
    const errorMessage = {
      code: error.status,
      message: '',
      errors: [],
    };

    if (error.status === 404 || error.status === 403) {
      window.location.href = '/404';
    }

    if (error.error instanceof ErrorEvent) {
      errorMessage.message = error.error.message;
    } else {
      errorMessage.message = error.message;
      errorMessage.errors = error.error.errors;
    }

    return throwError(errorMessage);
  }
}
