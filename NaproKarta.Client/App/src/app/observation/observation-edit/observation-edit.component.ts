import { LabelsValues } from './../../models/auxmodels/labels-values';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-observation-edit',
  templateUrl: './observation-edit.component.html',
  styleUrls: ['./observation-edit.component.css']
})
export class ObservationEditComponent implements OnInit {
  markerBaseUrl: string;
  labelValues: LabelsValues = new LabelsValues;

  constructor() { }

  ngOnInit() {
  }

}
