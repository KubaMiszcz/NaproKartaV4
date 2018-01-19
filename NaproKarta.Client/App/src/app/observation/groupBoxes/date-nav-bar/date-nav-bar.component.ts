import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-date-nav-bar',
  templateUrl: './date-nav-bar.component.html',
  styleUrls: ['./date-nav-bar.component.css']
})
export class DateNavBarComponent implements OnInit {
  @Input() date: Date;
  @Output() notify: EventEmitter<Date> = new EventEmitter<Date>();

  constructor() { }

  ngOnInit() {
  }

  passValueFromEvent(value: any) {
    // let str = value.value.;
    // console.log(' xx' + str);
    // console.log(' xx' + s);
    //this.notify.emit(value.value.clone().tz('Europe/Warsaw'));
    this.notify.emit(value.value);
  }
}
