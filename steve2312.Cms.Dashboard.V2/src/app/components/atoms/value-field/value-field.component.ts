import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-value-field',
  standalone: true,
  imports: [],
  templateUrl: './value-field.component.html',
})
export class ValueFieldComponent {
  @Input() type: string = '';
  @Input() key: string = '';
  @Input() error: string = '';

  @Input() value!: string | number;
  @Output() valueChange = new EventEmitter<string | number>();

  public valueHandler(event: Event) {
    var element = event.target as HTMLInputElement;

    this.valueChange.emit(element.value);
  }
}
