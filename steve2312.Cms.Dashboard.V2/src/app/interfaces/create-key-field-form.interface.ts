import { FormControl } from '@angular/forms';

export interface CreateKeyFieldForm {
  key: FormControl<string | null>;
  required: FormControl<boolean | null>;
}
