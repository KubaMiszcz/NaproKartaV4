import { Router } from '@angular/router';
import { GlobalVariables } from './../../global-variables';
import { IObservation, Observation } from './../../models/iobservation';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-chart-cell',
  templateUrl: './chart-cell.component.html',
  styleUrls: ['./chart-cell.component.css']
})
export class ChartCellComponent implements OnInit {
  @Input() observation: IObservation;
  @Input() chartId: number;

  markerUrl: string;
  assetsUrl: string = GlobalVariables.BASE_URL_APP;

  constructor(private router: Router) {
    this.observation = new Observation();
  }

  ngOnInit() {
    this.markerUrl = this.assetsUrl + '/assets/img/markers/marker-' + this.observation.marker + '.jpg';

  }
}
