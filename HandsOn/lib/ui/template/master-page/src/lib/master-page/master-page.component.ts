import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { HeaderComponent } from '@hands-on/header';
import { SidebarComponent } from '@hands-on/sidebar';
import { MainComponent } from '@hands-on/main';
import { FooterComponent } from '@hands-on/footer';
import { TieredMenuModule } from 'primeng/tieredmenu';
import { MenuItem } from 'primeng/api';
import { ProgressSpinnerModule } from 'primeng/progressspinner';

@Component({
  selector: 'lib-master-page',
  imports: [
    CommonModule,
    RouterModule,
    HeaderComponent,
    SidebarComponent,
    MainComponent,
    FooterComponent,
    TieredMenuModule,
    ProgressSpinnerModule,
  ],
  templateUrl: './master-page.component.html',
  styleUrl: './master-page.component.css',
})
export class MasterPageComponent {
  menuItems: MenuItem[] = [];
  menuVisible = false;
  loading = true;

  constructor() {
    this.menuItems = [
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
    ];
  }
}
