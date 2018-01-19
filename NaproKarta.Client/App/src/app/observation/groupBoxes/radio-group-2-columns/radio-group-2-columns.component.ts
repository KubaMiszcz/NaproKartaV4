import { IObservation } from './../../../models/iobservation';
import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { StringifyOptions } from 'querystring';

@Component({
  selector: 'app-radio-group-2-columns',
  templateUrl: './radio-group-2-columns.component.html',
  styleUrls: ['./radio-group-2-columns.component.css']
})
export class RadioGroup2ColumnsComponent implements OnInit {
  @Input() labels: string[];
  @Input() radioGroupValue: string;
  @Output() notify: EventEmitter<string> = new EventEmitter<string>();

  constructor() { }

  ngOnInit() {
    //console.log(' ' + this.labels);
    console.log('radioGroupValue ' + this.radioGroupValue);
  }

  emitValue(val: string) {
    this.notify.emit(val);
  }
}
