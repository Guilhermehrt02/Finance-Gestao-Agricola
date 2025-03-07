import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { ButtonComponent, InputPasswordComponent } from '@hands-on/ui';
import { AuthFacade } from '@hands-on/facades';
import { NotificationService } from '@hands-on/services';

@Component({
  selector: 'lib-change-password',
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    ButtonComponent,
    InputPasswordComponent,
  ],
  templateUrl: './change-password.component.html',
  styleUrl: './change-password.component.css',
})
export class ChangePasswordComponent implements OnInit {
  key: string | null = null;
  token: string | null = null;

  changePassword: FormGroup;
  loading = false;

  constructor(
    private authFacade: AuthFacade,
    private notificationService: NotificationService
  ) {
    this.changePassword = new FormGroup({
      password: new FormControl('', [Validators.required]), //  TODO: add custom validator for check passwords match
      confirmPassword: new FormControl('', [Validators.required]),
    });
  }

  ngOnInit() {
    this.key = this.getQueryParams('key');
    this.token = this.getQueryParams('token');

    // it's a good idea check if the key and token are valid

    if (!this.key || !this.token) {
      window.location.href = '/sign-in';
    }
  }

  get password(): FormControl {
    return this.changePassword.get('password') as FormControl;
  }

  get confirmPassword(): FormControl {
    return this.changePassword.get('confirmPassword') as FormControl;
  }

  getQueryParams(param: string) {
    const urlParams = new URLSearchParams(window.location.search);
    return urlParams.get(param);
  }

  onSubmit() {
    if (!this.key || !this.token) {
      this.notificationService.error('Erro', 'Chave ou token inválidos');
      return;
    }

    if (this.changePassword.invalid) {
      for (const key in this.changePassword.controls) {
        this.changePassword.controls[key].markAsDirty();
        this.changePassword.controls[key].updateValueAndValidity();
      }

      return;
    }

    const password = this.password.value;
    const confirmPassword = this.confirmPassword.value;

    this.authFacade
      .changePassword(this.key, this.token, password, confirmPassword)
      .subscribe(() => {
        this.loading = false;
        window.location.href = '/sign-in';
      });
  }
}
