import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MenuComponent } from '@hands-on/ui';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'lib-settings',
  imports: [CommonModule, RouterModule, MenuComponent],
  templateUrl: './settings.component.html',
  styleUrl: './settings.component.css',
})
export class SettingsComponent {
  menuItems: MenuItem[] = [
    {
      label: 'Conta',
      icon: 'pi pi-fw pi-user',
      routerLink: '/farm/settings/account',
      styleClass: 'description',
    },
    {
      label: 'Segurança',
      icon: 'pi pi-fw pi-lock',
      routerLink: '/farm/settings/security',
      styleClass: 'description',
    },
  ];
}
