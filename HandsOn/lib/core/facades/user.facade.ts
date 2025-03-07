import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { UserService, NotificationService } from '@hands-on/services';
import { User } from '@hands-on/models';

@Injectable({
  providedIn: 'root',
})
export class UserFacade {
  private userSubject = new BehaviorSubject<User | null>(null);
  private loadingSubject = new BehaviorSubject<boolean>(true);

  user$: Observable<User | null> = this.userSubject.asObservable();
  loading$: Observable<boolean> = this.loadingSubject.asObservable();

  constructor(
    private userService: UserService,
    private notificationService: NotificationService
  ) {}

  me(): Observable<{ user: User }> {
    return this.userService.me().pipe(
      tap((response) => {
        this.userSubject.next(response as unknown as User);
        this.loadingSubject.next(false);
      }),
      tap({
        error: () => {
          this.notificationService.error(
            'Erro!',
            'Não foi possível carregar as informações do usuário!'
          );
        },
      })
    );
  }

  getAllUsers(): Observable<{ users: User[] }> {
    return this.userService.getAllUsers().pipe(
      tap({
        error: () => {
          this.notificationService.error(
            'Erro!',
            'Não foi possível carregar os usuários!'
          );
        },
      })
    );
  }

  getUserById(id: string): Observable<{ user: User }> {
    return this.userService.getUserById(id).pipe(
      tap({
        error: () => {
          this.notificationService.error(
            'Erro!',
            'Não foi possível carregar o usuário!'
          );
        },
      })
    );
  }

  createUser(user: User): Observable<{ user: User }> {
    return this.userService.createUser(user).pipe(
      tap({
        next: () => {
          this.notificationService.success(
            'Sucesso!',
            'Usuário cadastrado com sucesso!'
          );
        },
        error: () => {
          this.notificationService.error(
            'Erro!',
            'Não foi possível criar o usuário!'
          );
        },
      })
    );
  }

  updateUser(user: User): Observable<{ user: User }> {
    return this.userService.updateUser(user).pipe(
      tap({
        next: () => {
          this.notificationService.success(
            'Sucesso!',
            'Usuário atualizado com sucesso!'
          );
        },
        error: () => {
          this.notificationService.error(
            'Erro!',
            'Não foi possível atualizar o usuário!'
          );
        },
      })
    );
  }

  updateMe(user: User): Observable<{ user: User }> {
    return this.userService.updateMe(user).pipe(
      tap({
        next: () => {
          this.userSubject.next(user);
          this.notificationService.success(
            'Sucesso!',
            'Informações atualizadas com sucesso!'
          );
        },
        error: () => {
          this.notificationService.error(
            'Erro!',
            'Não foi possível atualizar o usuário!'
          );
        },
      })
    );
  }
}
