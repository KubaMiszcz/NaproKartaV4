import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-date-nav-bar',
  templateUrl: './date-nav-bar.component.html',
  styleUrls: ['./date-nav-bar.component.css']
})
export class DateNavBarComponent implements OnInit {
  @Input() date: Date;
  constructor() { }

  ngOnInit() {
  }

}
