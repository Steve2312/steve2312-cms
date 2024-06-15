import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-profile',
  standalone: true,
  imports: [],
  templateUrl: './profile.component.html',
})
export class ProfileComponent {
  @Input() role: string = '';
  @Input() name: string = '';
  @Input() imageUrl: string = '';
}
