import { CreateKeyField } from './create-key-field.interface';

export interface CreateModel {
  name: string;
  stringKeyFields: CreateKeyField[];
  integerKeyFields: CreateKeyField[];
}
