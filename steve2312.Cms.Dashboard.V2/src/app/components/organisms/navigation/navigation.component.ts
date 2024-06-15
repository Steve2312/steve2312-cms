import { Component } from '@angular/core';
import { ProfileComponent } from '../../atoms/profile/profile.component';
import { NavigationButtonComponent } from '../../atoms/navigation-button/navigation-button.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navigation',
  standalone: true,
  imports: [ProfileComponent, NavigationButtonComponent],
  templateUrl: './navigation.component.html',
})
export class NavigationComponent {
  constructor(public router: Router) {}
}
