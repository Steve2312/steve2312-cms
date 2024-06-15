import { FormArray, FormControl, FormGroup } from '@angular/forms';
import { CreateKeyFieldForm } from './create-key-field-form.interface';

export interface CreateModelForm {
  name: FormControl<string | null>;
  stringKeyFields: FormArray<FormGroup<CreateKeyFieldForm>>;
  integerKeyFields: FormArray<FormGroup<CreateKeyFieldForm>>;
}
