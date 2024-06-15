import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-table-row',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './table-row.component.html',
})
export class TableRowComponent {
  @Input() header: boolean = false;
}
