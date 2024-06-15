import { KeyField } from './key-field.interface';

export interface Model {
  id: string;
  name: string;
  lastUpdated: Date;
  stringKeyFields: KeyField[];
  integerKeyFields: KeyField[];
  entityCount: number;
}
