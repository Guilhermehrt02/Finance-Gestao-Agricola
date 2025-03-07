import { Component, EventEmitter, Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { InputComponent } from '../../components/input/input.component';
import { InputMaskComponent } from '../../components/input-mask/input-mask.component';
import { InputPasswordComponent } from '../../components/input-password/input-password.component';
import { ButtonComponent } from '../../components/button/button.component';

@Component({
  selector: 'app-user-form',
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    InputComponent,
    InputMaskComponent,
    InputPasswordComponent,
    ButtonComponent,
  ],
  templateUrl: './user-form.component.html',
  styleUrl: './user-form.component.css',
})
export class UserFormComponent {
  @Input() loading = false;
  @Output() userSubmit = new EventEmitter<any>();

  userForm: FormGroup;

  constructor() {
    this.userForm = new FormGroup({
      firstName: new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
      ]),
      lastName: new FormControl('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
      ]),
      email: new FormControl('', [Validators.required, Validators.email]),
      phone: new FormControl('', [
        Validators.required,
        Validators.maxLength(15),
      ]),
      password: new FormControl('', [Validators.required]),
    });
  }

  get firstName(): FormControl {
    return this.userForm.get('firstName') as FormControl;
  }

  get lastName(): FormControl {
    return this.userForm.get('lastName') as FormControl;
  }

  get email(): FormControl {
    return this.userForm.get('email') as FormControl;
  }

  get phone(): FormControl {
    return this.userForm.get('phone') as FormControl;
  }

  get password(): FormControl {
    return this.userForm.get('password') as FormControl;
  }

  onSubmit() {
    this.userForm.updateValueAndValidity();

    if (this.userForm.invalid) {
      for (const key in this.userForm.controls) {
        this.userForm.controls[key].markAsDirty();
        this.userForm.controls[key].updateValueAndValidity();
      }
      return;
    }

    this.userSubmit.emit(this.userForm.value);
  }
}
