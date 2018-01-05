import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-radio-group-1-column',
  templateUrl: './radio-group-1-column.component.html',
  styleUrls: ['./radio-group-1-column.component.css']
})
export class RadioGroup1ColumnComponent implements OnInit {
  @Input() labels: string[];
  constructor() {
    this.labels = ['XX1', 'XX2', 'XX3', 'XX4', 'XX5', 'XX6', 'XX7'];
  }

  ngOnInit() {
  }
}
