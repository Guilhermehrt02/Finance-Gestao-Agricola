import { Injectable } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class MenuFacade {
  private menuStateSubject = new BehaviorSubject<boolean>(false);
  private menuItemsSubject = new BehaviorSubject<MenuItem[]>([]);

  menuState$: Observable<boolean> = this.menuStateSubject.asObservable();
  menuItems$: Observable<MenuItem[]> = this.menuItemsSubject.asObservable();

  constructor() {
    this.menuItemsSubject.next([
      {
        label: 'Home',
        icon: 'pi pi-fw pi-home',
        routerLink: '/farm',
        style: {
          border: 'none',
          'background-color': 'transparent',
        },
      },
      {
        label: 'Usuários',
        icon: 'pi pi-fw pi-user',
        style: {
          border: 'none',
          'background-color': 'transparent',
        },
        items: [
          {
            label: 'Cadastrar',
            icon: 'pi pi-fw pi-user-plus',
            routerLink: '/farm/users/create',
            styleClass: 'description',
          },
          {
            label: 'Gerenciar',
            icon: 'pi pi-fw pi-users',
            routerLink: '/farm/users',
            styleClass: 'description',
          },
        ],
      },
    ]);
  }

  openMenu(): void {
    this.menuStateSubject.next(true);
  }

  closeMenu(): void {
    this.menuStateSubject.next(false);
  }

  toggleMenu(): void {
    this.menuStateSubject.next(!this.menuStateSubject.value);
  }
}
