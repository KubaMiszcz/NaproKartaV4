import { GlobalVariables } from './../../global-variables';
import { IObservation, Observation } from './../../models/iobservation';
// import { ObservationEditDialogComponent } from './../../observation/observation-edit-dialog/observation-edit-dialog.component';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
// import { MatDialog, MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-chart-cell',
  templateUrl: './chart-cell.component.html',
  styleUrls: ['./chart-cell.component.css']
})
export class ChartCellComponent implements OnInit {
  @Input() cycleId: number;
  @Input() numberInCycle: number;
  @Input() observation: IObservation;

  markerUrl: string;
  noteMarks: string[];

  // id: number;
  // marker: string;
  // date: Date;
  // letter: string;
  // isB: boolean;
  // numTimes: string;
  // cipher: string;
  // cipherCd: string;
  // comments: string;

  assetsUrl: string = GlobalVariables.BASE_ASSETS_URL;
  // observationEditDialogRef: MatDialogRef<ObservationEditDialogComponent>;

  // constructor(private dialog: MatDialog) { }
  constructor() { }

  ngOnInit() {
    if (this.observation !== undefined) {
      this.markerUrl = this.assetsUrl + '/img/markers/marker-' + this.observation.marker + '.jpg';
      if (this.observation.notes !== undefined) {
        this.noteMarks = new Array();
        this.observation.notes.forEach(element => {
          this.noteMarks.push(element.content.substr(0, 1).toUpperCase());
        });
      }
    }
  }
  // onCellClicked() {
  //   //console.log('from cell: ' + this.row + ',' + this.col);
  //   // this.observationEditDialogRef = this.dialog.open(ObservationEditDialogComponent, {
  //   //   hasBackdrop: true
  //   // });
  //   //this.observationEditDialogRef.componentInstance.chart = this.chart;
  // }

  // convertArrayToString(array: string[]): string {
  //   let arr = '';
  //   array.forEach(element => {
  //     arr += (element.toUpperCase() + ' ');
  //     arr.slice(0, -1);
  //   });
  //   return arr;
  // }

  //EditObservation(row: number, col: number) {



}
