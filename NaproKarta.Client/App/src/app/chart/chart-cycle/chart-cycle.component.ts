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
  @Input()cycle: ICycle;
  @Input() numberInChart: number;

  constructor() { }

  ngOnInit() {
    //console.log(this.note + '\n');
    this.observations = new Array<Observation>(maxObservations);
  }
}
