import { Observation, IObservation } from './../../models/iobservation';
import { ActivatedRoute } from '@angular/router';
import { LabelsValues } from './../../models/auxmodels/labels-values';
import { Component, OnInit } from '@angular/core';
import { ObservationService } from '../../services/observation.service';


@Component({
  selector: 'app-observation-edit',
  templateUrl: './observation-edit.component.html',
  styleUrls: ['./observation-edit.component.css']
})
export class ObservationEditComponent implements OnInit {
  currentObservationId: number;
  observation: IObservation;

  markerBaseUrl: string;
  labelValues: LabelsValues = new LabelsValues;
  sub: any;

  constructor(private observationService: ObservationService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.sub = this.route.paramMap
      .subscribe(v => this.UpdateObservation(+v.get('id'))
      , error => console.log(error));
  }

  UpdateObservation(id: number) {
    this.currentObservationId = id;
    this.observationService.GetObservation(this.currentObservationId)
      .subscribe(observation => this.observation = observation
      , error => console.log(error)
      , () => {
        // this.chart.cycles.forEach(element => {
        //   console.log(element);
        //   this.cycles[element.numberInChart] = element;
        //console.log(this.cycles[element.numberInChart]);
        // });
        // this.cycles.forEach(e => {
        //   console.log(e);
        // });
        //console.log(this.cycles);
      });
  }
}
