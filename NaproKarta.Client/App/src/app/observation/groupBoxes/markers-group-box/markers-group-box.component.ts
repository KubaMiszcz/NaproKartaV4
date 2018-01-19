import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-markers-group-box',
  templateUrl: './markers-group-box.component.html',
  styleUrls: ['./markers-group-box.component.css']
})
export class MarkersGroupBoxComponent implements OnInit {
  @Input() labels: string[];
  @Input() marker: string;
  @Output() notify: EventEmitter<Date> = new EventEmitter<Date>();

  constructor() { }

  ngOnInit() {
    if (this.marker !== undefined) {
      console.log(' ' + this.labels);
      console.log('marker ' + this.marker);
    }
  }

  passValueFromEvent(value: Date) {
    this.notify.emit(value);
  }
}
