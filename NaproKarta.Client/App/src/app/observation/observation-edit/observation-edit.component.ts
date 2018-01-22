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
    this.observation.id = 0;
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
      , error => console.log(error))
      , console.log('xxx' + JSON.stringify(this.observation));
  }

  UpdateObservation(id: number) {
    // if (this.observation.id === 0) {
    //   console.log('obsformnew obs  ' + JSON.stringify(this.observation));
    // } else {
    this.currentObservationId = id;
    this.observationService.GetObservation(this.currentObservationId)
      .subscribe(observation => { this.observation.id = 0; this.observation = observation; }
      , error => console.log(error)
      , () => {
        console.log('obsforminit  ' + JSON.stringify(this.observation));
      });
    // }
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
    if (this.observation.id === undefined) {
      console.log('obsFormsaveAdd: ' + JSON.stringify(this.observation));
      this.observationService.AddObservation(this.observation)
        .subscribe(response => this.response
        , error => console.log(error)
        , () => {
          console.log(JSON.stringify(this.response));
        });
    } else {
      console.log('obsFormsaveUpdate: ' + JSON.stringify(this.observation));
      this.observationService.UpdateObservation(this.observation)
        .subscribe(response => this.response
        , error => console.log(error)
        , () => {
          console.log(JSON.stringify(this.response));
        });
    }
  }

  deleteObservation() {
    console.log('obsFormdelete');
    this.observationService.DeleteObservation(this.observation.id)
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

