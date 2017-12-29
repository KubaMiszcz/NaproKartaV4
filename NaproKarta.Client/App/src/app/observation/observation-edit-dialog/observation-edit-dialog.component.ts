import { LabelsValues } from './../../models/auxmodels/labels-values';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-observation-edit-dialog',
  templateUrl: './observation-edit-dialog.component.html',
  styleUrls: ['./observation-edit-dialog.component.css']
})
export class ObservationEditDialogComponent implements OnInit {
  markerBaseUrl: string;
  labelValues: LabelsValues = new LabelsValues;

  constructor() {
  }

  ngOnInit() {
  }
}
