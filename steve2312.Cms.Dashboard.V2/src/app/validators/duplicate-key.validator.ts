import {
  AbstractControl,
  FormGroup,
  ValidationErrors,
  ValidatorFn,
} from '@angular/forms';
import { CreateModelForm } from '../interfaces/create-model-form.interface';

export const duplicateKeyValidator = (
  formGroup: FormGroup<CreateModelForm>,
): ValidatorFn => {
  return (control: AbstractControl): ValidationErrors | null => {
    const key = control.value;
    const keys = [
      formGroup.controls.stringKeyFields.controls
        .filter((c) => c.controls.key != control)
        .map((form) => form.value.key),
      formGroup.controls.integerKeyFields.controls
        .filter((c) => c.controls.key != control)
        .map((form) => form.value.key),
    ].flat();

    if (!key) return null;
    if (!keys.includes(key)) return null;

    return {
      duplicateKey: true,
    };
  };
};
