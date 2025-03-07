import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CardComponent, UserFormComponent } from '@hands-on/ui';

@Component({
  selector: 'lib-sign-up',
  imports: [CommonModule, RouterModule, UserFormComponent, CardComponent],
  templateUrl: './sign-up.component.html',
  styleUrl: './sign-up.component.css',
})
export class SignUpComponent {
  loading = false;

  onSubmit() {
    this.loading = true;
    setTimeout(() => {
      this.loading = false;
    }, 3000);
  }
}
