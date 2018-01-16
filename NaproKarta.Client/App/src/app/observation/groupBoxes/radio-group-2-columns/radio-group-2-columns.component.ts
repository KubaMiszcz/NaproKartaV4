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
    console.log(' ' + this.labels);
    console.log('ss ' + this.radioGroupValue);
  }

  onClick(item: any) {
    console.log('ss ' + item);
    // console.log('ss ' + this.value);
  }

  passValue(val: string) {
    this.notify.emit(val);
  }
}
