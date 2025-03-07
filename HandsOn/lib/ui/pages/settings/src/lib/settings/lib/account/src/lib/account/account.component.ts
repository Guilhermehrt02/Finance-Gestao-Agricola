import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import {
  ButtonComponent,
  InputComponent,
  InputMaskComponent,
} from '@hands-on/ui';
import { UserFacade } from '@hands-on/facades';
import { User } from '@hands-on/models';

@Component({
  selector: 'lib-account',
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    ButtonComponent,
    InputComponent,
    InputMaskComponent,
  ],
  templateUrl: './account.component.html',
  styleUrl: './account.component.css',
})
export class AccountComponent implements OnInit {
  user: User | null = null;
  accountForm: FormGroup;
  loading = false;

  constructor(private userFacade: UserFacade) {
    this.accountForm = new FormGroup({
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
      phone: new FormControl('', [
        Validators.required,
        Validators.maxLength(15),
      ]),
    });
  }

  ngOnInit() {
    this.userFacade.user$.subscribe((user) => {
      this.firstName.setValue(user?.firstName);
      this.lastName.setValue(user?.lastName);
      this.phone.setValue(user?.phoneNumber);

      this.user = user;
    });
  }

  get firstName(): FormControl {
    return this.accountForm.get('firstName') as FormControl;
  }

  get lastName(): FormControl {
    return this.accountForm.get('lastName') as FormControl;
  }

  get phone(): FormControl {
    return this.accountForm.get('phone') as FormControl;
  }

  onSubmit() {
    this.accountForm.updateValueAndValidity();

    if (this.accountForm.invalid) {
      for (const key in this.accountForm.controls) {
        this.accountForm.controls[key].markAsDirty();
        this.accountForm.controls[key].updateValueAndValidity();
      }

      return;
    }

    if (!this.user) return;

    this.loading = true;

    const userUpdated: User = {
      ...this.user,
      firstName: this.firstName.value,
      lastName: this.lastName.value,
      phoneNumber: this.phone.value,
    };

    this.userFacade.updateMe(userUpdated).subscribe(
      () => {
        this.loading = false;
      },
      () => {
        this.loading = false;
      }
    );
  }
}
