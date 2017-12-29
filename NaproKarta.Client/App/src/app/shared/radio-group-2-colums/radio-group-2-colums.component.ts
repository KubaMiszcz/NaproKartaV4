import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-radio-group-2-colums',
  templateUrl: './radio-group-2-colums.component.html',
  styleUrls: ['./radio-group-2-colums.component.css']
})
export class RadioGroup2ColumsComponent implements OnInit {
  @Input() labels: string[];
  constructor() { }

  ngOnInit() {
  }
}