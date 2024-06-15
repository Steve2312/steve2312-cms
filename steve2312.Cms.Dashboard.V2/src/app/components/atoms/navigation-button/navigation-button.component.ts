import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-navigation-button',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './navigation-button.component.html',
})
export class NavigationButtonComponent {
  @Input() title: string = '';
  @Input() icon: 'entities' | 'models' | 'settings' = 'entities';
  @Input() active: boolean = false;
}
