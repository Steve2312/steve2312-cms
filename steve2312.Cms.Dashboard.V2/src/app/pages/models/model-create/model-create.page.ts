import { Component, OnInit } from '@angular/core';
import { ButtonComponent } from '../../../components/atoms/button/button.component';
import { HeadingComponent } from '../../../components/atoms/heading/heading.component';
import { EditableHeadingComponent } from '../../../components/atoms/editable-heading/editable-heading.component';
import { BackButtonComponent } from '../../../components/atoms/back-button/back-button.component';
import { FieldCardComponent } from '../../../components/atoms/field-card/field-card.component';
import { FieldsComponent } from '../../../components/organisms/fields/fields.component';
import { KeyFieldComponent } from '../../../components/atoms/key-field/key-field.component';
import { ModelService } from '../../../services/model.service';
import { ActivatedRoute, Router } from '@angular/router';
import { CreateModelForm } from '../../../interfaces/create-model-form.interface';
import { CreateKeyFieldForm } from '../../../interfaces/create-key-field-form.interface';
import { CreateModel } from '../../../interfaces/create-model.interface';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';

@Component({
  selector: 'app-model-create',
  standalone: true,
  imports: [
    ButtonComponent,
    HeadingComponent,
    EditableHeadingComponent,
    BackButtonComponent,
    FieldCardComponent,
    FieldsComponent,
    KeyFieldComponent,
    ReactiveFormsModule,
  ],
  templateUrl: './model-create.page.html',
})
export class ModelCreatePage {
  public createModelForm: FormGroup<CreateModelForm> =
    this.formBuilder.group<CreateModelForm>({
      name: new FormControl('', [
        Validators.required,
        Validators.maxLength(30),
      ]),
      stringKeyFields: this.formBuilder.array<FormGroup<CreateKeyFieldForm>>(
        [],
      ),
      integerKeyFields: this.formBuilder.array<FormGroup<CreateKeyFieldForm>>(
        [],
      ),
    });

  constructor(
    private service: ModelService,
    private router: Router,
    private route: ActivatedRoute,
    private formBuilder: FormBuilder,
  ) {}

  public triggerValidation(): void {
    this.createModelForm.controls.stringKeyFields.controls.forEach((form) => {
      form.controls.key.updateValueAndValidity();
    });

    this.createModelForm.controls.integerKeyFields.controls.forEach((form) => {
      form.controls.key.updateValueAndValidity();
    });
  }

  public submit(): void {
    if (!this.createModelForm.valid) {
      return this.createModelForm.markAllAsTouched();
    }

    this.service
      .createModel(this.createModelForm.value as CreateModel)
      .subscribe(async () => {
        await this.router.navigate(['../'], { relativeTo: this.route });
      });
  }
}
