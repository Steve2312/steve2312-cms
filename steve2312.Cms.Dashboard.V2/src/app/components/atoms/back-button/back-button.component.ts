import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-back-button',
  standalone: true,
  imports: [],
  templateUrl: './back-button.component.html',
})
export class BackButtonComponent {
  constructor(
    private router: Router,
    private route: ActivatedRoute,
  ) {}

  public async previousPage(): Promise<void> {
    await this.router.navigate(['../'], { relativeTo: this.route });
  }
}
