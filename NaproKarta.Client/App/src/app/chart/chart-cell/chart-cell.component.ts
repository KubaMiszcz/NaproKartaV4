import { GlobalVariables } from './../../global-variables';
import { IObservation, Observation } from './../../models/iobservation';
import { ObservationEditDialogComponent } from './../../observation/observation-edit-dialog/observation-edit-dialog.component';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-chart-cell',
  templateUrl: './chart-cell.component.html',
  styleUrls: ['./chart-cell.component.css']
})
export class ChartCellComponent implements OnInit {
  @Input() cycleId: number;
  @Input() numberInCycle: number;
  @Input() observation: IObservation;

  id: number;
  marker: string;
  markerUrl: string;
  date: string; //Date;
  letter: string;
  isB: boolean;
  numTimes: string;
  cipher: string;
  cipherCd: string;
  comments: string;
  noteMarks: string;

  assetsUrl: string = GlobalVariables.BASE_ASSETS_URL;
  observationEditDialogRef: MatDialogRef<ObservationEditDialogComponent>;

  constructor(private dialog: MatDialog) {
    // this.numberInCycle = 0;
    this.marker = 'none';
    this.markerUrl = this.assetsUrl + '/img/markers/marker-' + 'none' + '.jpg';
    // this.date = '12-12';
    // this.letter = 'VVL';
    // this.numTimes = 'AD';
    // this.cipher = '10';
    // this.cipherCd = 'C/K';
    // this.comments = 'W W W';
    // this.noteMarks = 'W W W';
  }

  ngOnInit() {
    if (this.observation !== undefined) {
      this.markerUrl = this.assetsUrl + '/img/markers/marker-' + this.observation.marker + '.jpg';
      // this.numberInCycle = this.observation.numberInCycle;
      // this.marker = this.observation.marker;
    } else {
      // this.marker = 'none';
      // this.markerUrl = this.assetsUrl + '/img/markers/marker-' + 'none' + '.jpg';
    }
    //console.log(this.observation);
  }

  onCellClicked() {
    //console.log('from cell: ' + this.row + ',' + this.col);
    this.observationEditDialogRef = this.dialog.open(ObservationEditDialogComponent, {
      hasBackdrop: true
    });
    //this.observationEditDialogRef.componentInstance.chart = this.chart;
  }

  convertArrayToString(array: string[]): string {
    let arr = '';
    array.forEach(element => {
      arr += (element.toUpperCase() + ' ');
      arr.slice(0, -1);
    });
    return arr;
  }

  //EditObservation(row: number, col: number) {


}
