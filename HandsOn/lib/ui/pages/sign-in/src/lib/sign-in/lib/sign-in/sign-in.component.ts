import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';

import {
  FormGroupComponent,
  InputComponent,
  InputPasswordComponent,
  ButtonComponent,
  CheckboxComponent,
} from '@hands-on/ui';
import { AuthFacade } from '@hands-on/facades';
import { environments } from 'src/app/environments/environments';

@Component({
  selector: 'lib-sign-in',
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    FormGroupComponent,
    InputComponent,
    InputPasswordComponent,
    ButtonComponent,
    CheckboxComponent,
  ],
  templateUrl: './sign-in.component.html',
  styleUrl: './sign-in.component.css',
})
export class SignInComponent implements OnInit {
  signInForm: FormGroup;
  loading = false;
  loadingGoogle = false;

  constructor(private authFacade: AuthFacade) {
    this.signInForm = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required]),
      rememberMe: new FormControl(false),
    });
  }

  ngOnInit() {
    this.checkIfEmailSaved();
  }

  get email(): FormControl {
    return this.signInForm.get('email') as FormControl;
  }

  get password(): FormControl {
    return this.signInForm.get('password') as FormControl;
  }

  get rememberMe(): FormControl {
    return this.signInForm.get('rememberMe') as FormControl;
  }

  checkIfEmailSaved() {
    const email = localStorage.getItem('email') || '';

    this.email.setValue(email);

    if (email) this.rememberMe.setValue(true);
  }

  onGoogleSignIn() {
    this.loadingGoogle = true;

    const clientId = environments.googleClientId;
    const redirectUri = encodeURIComponent(environments.googleRedirectUri);

    const authUrl = `https://accounts.google.com/o/oauth2/v2/auth?client_id=${clientId}&redirect_uri=${redirectUri}&scope=openid%20profile%20email&response_type=code&access_type=offline&prompt=consent`;

    window.location.href = authUrl;
  }

  onSubmit() {
    this.signInForm.updateValueAndValidity();

    if (this.signInForm.invalid) {
      for (const key in this.signInForm.controls) {
        this.signInForm.controls[key].markAsDirty();
        this.signInForm.controls[key].updateValueAndValidity();
      }

      return;
    }

    this.loading = true;

    const { email, password, rememberMe } = this.signInForm.value;

    this.authFacade.login(email, password, rememberMe).subscribe(
      () => {
        this.loading = false;
      },
      () => {
        this.loading = false;
      }
    );
  }
}
