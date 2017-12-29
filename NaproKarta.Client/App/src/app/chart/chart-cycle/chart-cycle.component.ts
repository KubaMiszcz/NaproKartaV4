import { Component, OnInit, Input } from '@angular/core';
import { IObservation, Observation } from '../../models/iobservation';
import { Router } from '@angular/router';

const maxObservations = 35;

@Component({
  selector: 'app-chart-cycle',
  templateUrl: './chart-cycle.component.html',
  styleUrls: ['./chart-cycle.component.css']
})
export class ChartCycleComponent implements OnInit {
  observations: IObservation[];
  note: string;
  @Input() numberInChart: number;

  constructor(private router: Router) { }

  ngOnInit() {
    this.observations = new Array<Observation>(maxObservations);
  }
}
