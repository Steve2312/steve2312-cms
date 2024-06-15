import { Component } from '@angular/core';
import { HeadingComponent } from '../../components/atoms/heading/heading.component';
import { ButtonComponent } from '../../components/atoms/button/button.component';
import { TableComponent } from '../../components/molecules/table/table.component';
import { TableHeaderComponent } from '../../components/atoms/table-header/table-header.component';
import { TableRowComponent } from '../../components/atoms/table-row/table-row.component';

@Component({
  selector: 'app-entities',
  standalone: true,
  imports: [
    HeadingComponent,
    ButtonComponent,
    TableComponent,
    TableHeaderComponent,
    TableRowComponent,
  ],
  templateUrl: './entities.page.html',
})
export class EntitiesPage {}
