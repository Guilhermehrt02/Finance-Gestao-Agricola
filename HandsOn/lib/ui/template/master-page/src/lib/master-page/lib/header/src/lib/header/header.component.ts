import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AvatarComponent, ButtonComponent, MenuComponent } from '@hands-on/ui';
import { MenuItem } from 'primeng/api';
import { RouterModule } from '@angular/router';
import { AuthFacade, MenuFacade, UserFacade } from '@hands-on/facades';
import { User } from '@hands-on/models';

@Component({
  selector: 'lib-header',
  imports: [
    CommonModule,
    RouterModule,
    AvatarComponent,
    ButtonComponent,
    MenuComponent,
  ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
})
export class HeaderComponent implements OnInit {
  user: User | null = null;
  avatarItems: MenuItem[] = [
    {
      label: 'Perfil',
      items: [
        {
          label: 'Configurações',
          icon: 'pi pi-fw pi-cog',
          routerLink: '/farm/settings',
          styleClass: 'description',
        },
        {
          label: 'Sair',
          icon: 'pi pi-fw pi-sign-out',
          styleClass: 'description',
          iconClass: 'error',
          command: () => this.logout(),
        },
      ],
    },
  ];

  constructor(
    private authFacade: AuthFacade,
    private menuFacade: MenuFacade,
    private userFacade: UserFacade
  ) {}

  ngOnInit(): void {
    this.userFacade.user$.subscribe((user) => {
      this.user = user;
    });
  }

  menuToggle(): void {
    this.menuFacade.toggleMenu();
  }

  logout(): void {
    this.authFacade.logout();
  }
}
