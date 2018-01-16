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
        console.log(' ' + this.observation);

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

  onDateChanged(value: string) {

  }
  onMarkerChanged(value: string) {

  }
  onLetterChanged(value: string) {
    this.observation.letter = value;
  }
  onCipherChanged(value: string) {
    this.observation.cipher = value;
  }
  onCipherCdChanged(value: string) {
    this.observation.cipherCd = value;
  }
  onNumTimesChanged(value: string) {
    this.observation.numTimes = value;
  }
  onNoteChanged(value: string) {

  }
}
