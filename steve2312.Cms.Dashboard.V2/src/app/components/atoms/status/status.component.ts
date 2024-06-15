import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-status',
  standalone: true,
  imports: [],
  templateUrl: './status.component.html',
})
export class StatusComponent {
  @Input() style: 'in-use' | 'unused' | 'draft' = 'in-use';
}
