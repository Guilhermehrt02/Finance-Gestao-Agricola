import { Injectable } from '@angular/core';
import { HttpContext, HttpErrorResponse } from '@angular/common/http';
import { throwError } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { HttpHeaders } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root',
})
export class RequestService {
  authApiUrl = '';
  usersApiUrl = '';

  public constructor(
    public httpClient: HttpClient,
    public router: Router,
    public jwtHelper: JwtHelperService,
  ) {
    this.authApiUrl = 'http://localhost:5143/api/users';
    this.usersApiUrl = 'http://localhost:5143/api/users';
  }

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

    if (error.status === 404 || error.status === 403)
      this.router.navigate(['/404']);

    if (error.error instanceof ErrorEvent) {
      errorMessage.message = error.error.message;
    } else {
      errorMessage.message = error.message;
      errorMessage.errors = error.error.errors;
    }

    return throwError(errorMessage);
  }
}
