import { INote, Note } from './../../models/inote';
import { Observation, IObservation } from './../../models/iobservation';
import { ActivatedRoute, Router } from '@angular/router';
import { LabelsValues } from './../../models/auxmodels/labels-values';
import { Component, OnInit } from '@angular/core';
import { ObservationService } from '../../services/observation.service';

const numberOfNotes = 3;

@Component({
  selector: 'app-observation-edit',
  templateUrl: './observation-edit.component.html',
  styleUrls: ['./observation-edit.component.css']
})
export class ObservationEditComponent implements OnInit {
  observation: IObservation;
  notes: INote[];
  parentChartId: number;
  numberOfParentCycleInChart: number;
  numberInCycle: number;
  labelValues: LabelsValues = new LabelsValues;
  //date: Date;

  // markerBaseUrl: string;
  queryParams: any;
  params: any;
  response: any;
  // currentObservationId: number;

  constructor(private observationService: ObservationService, private route: ActivatedRoute, private router: Router) {
    this.observation = new Observation();
  }

  ngOnInit() {
    //this.date = new Date();
    this.notes = new Array(numberOfNotes);
    for (let i = 0; i < numberOfNotes; i++) {
      this.notes[i] = new Note();
    }

    this.queryParams = this.route
      .queryParams
      .subscribe(params => {   // Defaults to 0 if no query param provided.
        this.parentChartId = +params['chartId'] || 0;
        this.numberOfParentCycleInChart = +params['cycleNumber'] || 0;
        this.numberInCycle = +params['numberInCycle'] || 0;
      }
      , error => console.log(error)
      );

    this.params = this.route.paramMap
      .subscribe(params => this.observation.id = +params.get('id')
      , error => console.log(error)
      , () => {
      });
    this.RefreshObservation(this.observation.id);
  }

  RefreshObservation(id: number) {
    console.log('yyy' + JSON.stringify(this.observation));
    if (this.observation.id === 0) {
      this.observation.date = new Date();
      console.log('addobs' + JSON.stringify(this.observation));
      // console.log('addobsexistforminit cyclenum ' + JSON.stringify(this.observation.cycleNumberInChart));
    } else {
      this.observationService.GetObservation(id)
        .subscribe(observation => this.observation = observation
        , error => console.log(error)
        , () => {
          console.log('obsexist' + JSON.stringify(this.observation));
          // console.log('obsexistforminit cyclenum ' + JSON.stringify(this.observation.cycleNumberInChart));
          // console.log('obsexistforminit chartid ' + JSON.stringify(this.chartId));
        });
    }
  }

  saveObservation() {
    this.observation.parentChartId = this.parentChartId;
    this.observation.numberOfParentCycleInChart = this.numberOfParentCycleInChart;
    this.observation.numberInCycle = this.numberInCycle;
    if (this.observation.id === 0) {
      console.log('obsFormsaveAdd: ' + JSON.stringify(this.observation));
      this.observationService.AddObservation(this.observation)
        .subscribe(response => this.response = response
        , error => console.log(error)
        , () => {
          this.router.navigate(['/chart', this.parentChartId]);
          console.log(JSON.stringify(this.response));
        });
    } else {
      console.log('obsFormsaveUpdate: ' + JSON.stringify(this.observation));
      this.observationService.UpdateObservation(this.observation)
        .subscribe(response => this.response = response
        , error => console.log(error)
        , () => {
          this.router.navigate(['/chart', this.parentChartId]);
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
        this.router.navigate(['/chart', this.parentChartId]);
        console.log(JSON.stringify(this.response));
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

