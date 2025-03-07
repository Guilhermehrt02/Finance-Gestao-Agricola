import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChangeEmailComponent } from './lib/change-email/change-email.component';
import { PasswordResetComponent } from './lib/password-reset/password-reset.component';

@Component({
  selector: 'lib-security',
  imports: [CommonModule, ChangeEmailComponent, PasswordResetComponent],
  templateUrl: './security.component.html',
  styleUrl: './security.component.css',
})
export class SecurityComponent {}
