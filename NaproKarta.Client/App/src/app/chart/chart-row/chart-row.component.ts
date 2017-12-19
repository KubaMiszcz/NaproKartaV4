import { element } from 'protractor';
import { Component, OnInit, Input } from '@angular/core';
import { IObservation, Observation } from '../../models/iobservation';
import { Router } from '@angular/router';

@Component({
  selector: 'app-chart-cycle',
  templateUrl: './chart-row.component.html',
  styleUrls: ['./chart-row.component.css']
})
export class ChartCycleComponent implements OnInit {
  observations: IObservation[];
  note: string;
  maxObservations = 35;

  constructor(private router: Router) { }

  ngOnInit() {
    this.observations = new Array<Observation>(this.maxObservations);
    //let i = 0;
    // this.observations.forEach(element => {
    //   element.col = i;
    //   i++;
    // });
  }

  EditObservation(row: number, col: number) {
    let id = 1;
    alert('aa' + row + ' x ' + col);
    //this.router.navigate(['/observation', id]);
  }
}
