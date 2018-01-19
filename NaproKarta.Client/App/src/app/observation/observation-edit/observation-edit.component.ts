import { Observation, IObservation } from './../../models/iobservation';
import { ActivatedRoute, Router } from '@angular/router';
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
  response: any;
  fromChartId: number;

  constructor(private observationService: ObservationService, private route: ActivatedRoute, private router: Router) {
    this.observation = new Observation();
  }

  ngOnInit() {
    this.sub = this.route
      .queryParams
      .subscribe(params => this.fromChartId = +params['chartId'] || 0     // Defaults to 0 if no query param provided.
      , error => console.log(error)
      );

    this.sub = this.route.paramMap
      .subscribe(v =>
        this.UpdateObservation(+v.get('id'))
      , error => console.log(error));
  }

  UpdateObservation(id: number) {
    this.currentObservationId = id;
    this.observationService.GetObservation(this.currentObservationId)
      .subscribe(observation => this.observation = observation
      , error => console.log(error)
      , () => {
        console.log('obsforminit  ' + JSON.stringify(this.observation));
        console.log('pictureUrl  ' + JSON.stringify(this.observation.pictureUrl));

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

  onDateChanged(value: Date) {
    this.observation.date = value;
    console.log('val ' + value);
    console.log('date ' + this.observation.date);
  }
  onMarkerChanged(value: string) {
    this.observation.marker = value;
    console.log('val ' + value);
  }
  onLetterChanged(value: string) {
    this.observation.letter = value;
    console.log('val ' + value);
  }
  onCipherChanged(value: string) {
    this.observation.cipher = value;
    console.log('val ' + value);
  }
  onCipherCdChanged(value: string) {
    this.observation.cipherCd = value;
    console.log('val ' + value);
  }
  onNumTimesChanged(value: string) {
    this.observation.numTimes = value;
    console.log('val ' + value);
  }
  onNoteChanged(value: string) {
    console.log('val ' + value);
  }

  saveObservation() {
    console.log('obsFormsave: ' + JSON.stringify(this.observation));
    this.observationService.UpdateObservation(this.observation)
      .subscribe(response => this.response
      , error => console.log(error)
      , () => {
        console.log(JSON.stringify(this.response));
      });
  }



  // if (this.chart.title !== null && this.chart.title !== '') {
  //   this.chartService.UpdateChart(this.chart)
  //     .subscribe(msg => this.response = msg, error => console.log(error), () => {
  //       console.log(this.response);
  //       alert('zmieniono' + this.response[0]);
  //       this.router.navigate(['/chart', this.response[0]]);
  //     });
  //   //todo: check other repsonse: not logged, wrong model etc
  // } else {
  //   alert('title pusty nie zmieniono');
  //   // this.errorDialogRef = this.dialog.open(ErrorDialogComponent, {
  //   //   hasBackdrop: true, data: { title: 'titleeee', content: 'coontent' }
  //   // });
}

