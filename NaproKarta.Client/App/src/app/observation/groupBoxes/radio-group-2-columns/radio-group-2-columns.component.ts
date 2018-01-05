import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-radio-group-2-columns',
  templateUrl: './radio-group-2-columns.component.html',
  styleUrls: ['./radio-group-2-columns.component.css']
})
export class RadioGroup2ColumnsComponent implements OnInit {
  @Input() labels: string[];
  constructor() {
    this.labels = ['XX1', 'XX2', 'XX3', 'XX4', 'XX5', 'XX6', 'XX7'];
  }

  ngOnInit() {
  }
}
