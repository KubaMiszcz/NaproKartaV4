import { Component, OnInit, Input } from '@angular/core';
import { IObservation, Observation } from '../../models/iobservation';
import { ICycle } from './../../models/icycle';

const maxObservations = 35;

@Component({
  selector: 'app-chart-cycle',
  templateUrl: './chart-cycle.component.html',
  styleUrls: ['./chart-cycle.component.css']
})
export class ChartCycleComponent implements OnInit {
  observations: IObservation[];
  note: string;
  @Input() cycle: ICycle;
  @Input() numberInChart: number;

  constructor() { }

  ngOnInit() {
    this.observations = new Array(maxObservations);
    for (let i = 0; i < maxObservations; i++) {
      this.observations[i] = new Observation();
    }

    // for (let i = 0; i < maxCycles; i++) {
    //   this.cycles[i] = new Cycle();
    // }

    this.cycle.observations.forEach(e => {
      this.observations[e.col] = e;
     // console.log(e);
    });
  }
}
