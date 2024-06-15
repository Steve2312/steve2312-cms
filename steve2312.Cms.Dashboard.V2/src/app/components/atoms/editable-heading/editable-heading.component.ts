import { Component, Input } from '@angular/core';
import { FormGroup, ReactiveFormsModule } from '@angular/forms';
import { CreateModelForm } from '../../../interfaces/create-model-form.interface';

@Component({
  selector: 'app-editable-heading',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './editable-heading.component.html',
})
export class EditableHeadingComponent {
  @Input() formGroup!: FormGroup<CreateModelForm>;
}
