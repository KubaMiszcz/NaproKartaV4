import { Component, OnInit, Input } from '@angular/core';
import { IObservation, Observation } from '../../models/iobservation';
import { ICycle } from './../../models/icycle';
// import { Observable } from 'rxjs/Observable';

const maxObservations = 35;

@Component({
  selector: 'app-chart-cycle',
  templateUrl: './chart-cycle.component.html',
  styleUrls: ['./chart-cycle.component.css']
})
export class ChartCycleComponent implements OnInit {
  observations: IObservation[];
  @Input() cycle: ICycle;
  @Input() numberInChart: number;

  constructor() {
    //this.note = 'none';
    this.observations = new Array(maxObservations);
    for (let i = 0; i < maxObservations; i++) {
      this.observations[i] = new Observation();
      this.observations[i].marker = 'none';
    }
  }

  ngOnInit() {
    //this.note = this.cycle.note;
    if (this.cycle.observations !== undefined) {
      this.cycle.observations.forEach(element => {
        this.observations[element.numberInCycle] = element;
      });
    }
  }
}
