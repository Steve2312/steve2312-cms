import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-button',
  standalone: true,
  templateUrl: './button.component.html',
  imports: [],
})
export class ButtonComponent {
  @Input() style: 'create' | 'save' | 'delete' = 'create';
  @Input() type: 'button' | 'submit' = 'button';
}
