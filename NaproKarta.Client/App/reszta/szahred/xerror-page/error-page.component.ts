import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-error-page',
  templateUrl: './error-page.component.html',
  styleUrls: ['./error-page.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class ErrorPageComponent implements OnInit {
  title: string = 'error';
  content: string = 'content';

  constructor() { }

  ngOnInit() {
  }

}
