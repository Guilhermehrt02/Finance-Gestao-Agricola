import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonComponent } from '@hands-on/ui';
import { AuthFacade, UserFacade } from '@hands-on/facades';
import { User } from '@hands-on/models';

@Component({
  selector: 'lib-password-reset',
  imports: [CommonModule, ButtonComponent],
  templateUrl: './password-reset.component.html',
  styleUrl: './password-reset.component.css',
})
export class PasswordResetComponent implements OnInit {
  user: User | null = null;
  loading = false;

  constructor(private authFacade: AuthFacade, private userFacade: UserFacade) {}

  ngOnInit(): void {
    this.userFacade.user$.subscribe((user) => {
      this.user = user;
    });
  }

  onResetPassword() {
    if (!this.user) return;

    this.loading = true;

    this.authFacade.sendPasswordResetEmail(this.user.email).subscribe(() => {
      this.loading = false;
    });
  }
}
