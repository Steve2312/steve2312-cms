import { Component } from '@angular/core';
import { ButtonComponent } from '../../components/atoms/button/button.component';
import { EditableHeadingComponent } from '../../components/atoms/editable-heading/editable-heading.component';
import { FieldCardComponent } from '../../components/atoms/field-card/field-card.component';
import { KeyFieldComponent } from '../../components/atoms/key-field/key-field.component';
import { NavigationButtonComponent } from '../../components/atoms/navigation-button/navigation-button.component';
import { NavigationComponent } from '../../components/organisms/navigation/navigation.component';
import { ProfileComponent } from '../../components/atoms/profile/profile.component';
import { StatusComponent } from '../../components/atoms/status/status.component';
import { TableComponent } from '../../components/molecules/table/table.component';
import { TableDataComponent } from '../../components/atoms/table-data/table-data.component';
import { TableHeaderComponent } from '../../components/atoms/table-header/table-header.component';
import { TableRowComponent } from '../../components/atoms/table-row/table-row.component';
import { ValueFieldComponent } from '../../components/atoms/value-field/value-field.component';
import { HeadingComponent } from '../../components/atoms/heading/heading.component';
import { BackButtonComponent } from '../../components/atoms/back-button/back-button.component';

@Component({
  selector: 'app-components',
  standalone: true,
  imports: [
    ButtonComponent,
    EditableHeadingComponent,
    FieldCardComponent,
    KeyFieldComponent,
    NavigationButtonComponent,
    NavigationComponent,
    ProfileComponent,
    StatusComponent,
    TableComponent,
    TableDataComponent,
    TableHeaderComponent,
    TableRowComponent,
    ValueFieldComponent,
    HeadingComponent,
    BackButtonComponent,
  ],
  templateUrl: './components.page.html',
})
export class ComponentsPage {}
