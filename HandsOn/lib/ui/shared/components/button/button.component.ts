import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'app-button',
  imports: [CommonModule, ButtonModule],
  templateUrl: './button.component.html',
  styleUrl: './button.component.css',
})
export class ButtonComponent {
  @Input() loading = false;
  @Input() disabled = false;
  @Input() label = '';
  @Input() type: 'button' | 'submit' | 'reset' = 'button';
  @Input() icon = '';
  @Input() iconPosition: 'left' | 'right' = 'left';
  @Input() severity:
    | 'info'
    | 'success'
    | 'warn'
    | 'danger'
    | 'secondary'
    | 'contrast'
    | 'help'
    | 'primary' = 'primary';
  @Input() variant: 'text' | 'outlined' | undefined = undefined;
  @Input() rounded = false;
  @Input() raised = false;
  @Input() link = false;
  @Input() size: 'small' | 'large' = 'small';
  @Input() fluid = false;
}
