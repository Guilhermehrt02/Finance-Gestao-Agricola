import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent, UserFormComponent } from '@hands-on/ui';

@Component({
  selector: 'lib-user',
  imports: [CommonModule, UserFormComponent, CardComponent],
  templateUrl: './user.component.html',
  styleUrl: './user.component.css',
})
export class UserComponent {
  loading = false;

  onSubmit() {
    this.loading = true;
    setTimeout(() => {
      this.loading = false;
    }, 3000);
  }
}
