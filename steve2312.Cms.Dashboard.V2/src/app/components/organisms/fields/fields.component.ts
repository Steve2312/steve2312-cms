import { Component, Input } from '@angular/core';
import { FieldCardComponent } from '../../atoms/field-card/field-card.component';
import { CreateModelForm } from '../../../interfaces/create-model-form.interface';
import { CreateKeyFieldForm } from '../../../interfaces/create-key-field-form.interface';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { duplicateKeyValidator } from '../../../validators/duplicate-key.validator';

@Component({
  selector: 'app-fields',
  standalone: true,
  imports: [FieldCardComponent],
  templateUrl: './fields.component.html',
})
export class FieldsComponent {
  @Input() formGroup!: FormGroup<CreateModelForm>;

  constructor(private formBuilder: FormBuilder) {}

  public addStringKeyField(): void {
    this.formGroup.controls.stringKeyFields.push(this.createKeyFieldForm());
  }

  public addIntegerKeyField(): void {
    this.formGroup.controls.integerKeyFields.push(this.createKeyFieldForm());
  }

  private createKeyFieldForm(): FormGroup<CreateKeyFieldForm> {
    return this.formBuilder.group<CreateKeyFieldForm>({
      key: new FormControl('', [
        Validators.required,
        Validators.maxLength(30),
        duplicateKeyValidator(this.formGroup),
      ]),
      required: new FormControl(true, Validators.required),
    });
  }
}
