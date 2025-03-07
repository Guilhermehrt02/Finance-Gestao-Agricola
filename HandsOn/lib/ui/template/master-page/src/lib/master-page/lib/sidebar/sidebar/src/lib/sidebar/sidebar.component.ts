import {
  Component,
  EventEmitter,
  Input,
  Output,
  ViewChild,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { Drawer, DrawerModule } from 'primeng/drawer';
import { MenuItem } from 'primeng/api';
import { TieredMenuModule } from 'primeng/tieredmenu';

@Component({
  selector: 'lib-sidebar',
  imports: [CommonModule, DrawerModule, TieredMenuModule],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css',
})
export class SidebarComponent {
  @Input() menuItems: MenuItem[] = [];
  @Input() visible = false;
  @Output() visibleChange = new EventEmitter<boolean>();

  @ViewChild('drawer') drawerRef!: Drawer;

  onHide(): void {
    this.visible = false;
    this.visibleChange.emit(this.visible);
  }

  closeCallback(e: Event): void {
    this.drawerRef.close(e);
  }
}
