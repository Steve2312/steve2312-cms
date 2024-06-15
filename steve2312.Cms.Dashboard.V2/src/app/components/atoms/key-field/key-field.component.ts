import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormGroup, ReactiveFormsModule } from '@angular/forms';
import { CreateKeyFieldForm } from '../../../interfaces/create-key-field-form.interface';

@Component({
  selector: 'app-key-field',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './key-field.component.html',
})
export class KeyFieldComponent {
  @Input() type: string = '';
  @Input() formGroup!: FormGroup<CreateKeyFieldForm>;

  @Output() delete = new EventEmitter<void>();
  @Output() input = new EventEmitter<void>();

  public deleteHandler(): void {
    this.delete.emit();
  }

  public inputHandler(): void {
    this.input.emit();
  }
}
