import { Injectable } from '@angular/core';
import { catchError } from 'rxjs';
import { RequestService } from '../request/request.service';
import { User } from '../../models';

@Injectable({
  providedIn: 'root',
})
export class UserService extends RequestService {
  me() {
    return this.httpClient
      .get<{
        user: User;
      }>(`${this.authApiUrl}/me`, this.httpOptions)
      .pipe(catchError(this.handleError));
  }

  getAllUsers() {
    return this.httpClient
      .get<{
        users: User[];
      }>(`${this.authApiUrl}/users`, this.httpOptions)
      .pipe(catchError(this.handleError));
  }

  getUserById(id: string) {
    return this.httpClient
      .get<{
        user: User;
      }>(`${this.authApiUrl}/users/${id}`, this.httpOptions)
      .pipe(catchError(this.handleError));
  }

  createUser(user: User) {
    return this.httpClient
      .post<{
        user: User;
      }>(`${this.authApiUrl}/users`, JSON.stringify(user), this.httpOptions)
      .pipe(catchError(this.handleError));
  }

  updateUser(user: User) {
    return this.httpClient
      .put<{
        user: User;
      }>(
        `${this.authApiUrl}/users/${user.id}`,
        JSON.stringify(user),
        this.httpOptions
      )
      .pipe(catchError(this.handleError));
  }

  updateMe(user: User) {
    return this.httpClient
      .put<{
        user: User;
      }>(`${this.authApiUrl}`, JSON.stringify(user), this.httpOptions)
      .pipe(catchError(this.handleError));
  }

  deleteUser(id: string) {
    return this.httpClient
      .delete(`${this.authApiUrl}/users/${id}`, this.httpOptions)
      .pipe(catchError(this.handleError));
  }
}
