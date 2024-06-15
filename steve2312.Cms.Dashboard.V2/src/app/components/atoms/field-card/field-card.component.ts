import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-field-card',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './field-card.component.html',
})
export class FieldCardComponent {
  @Input() title: string = '';
  @Input() description: string = '';
  @Input() icon:
    | 'string'
    | 'integer'
    | 'double'
    | 'array-string'
    | 'array-integer'
    | 'array-double'
    | 'array-entity'
    | 'link'
    | 'media' = 'string';
}
