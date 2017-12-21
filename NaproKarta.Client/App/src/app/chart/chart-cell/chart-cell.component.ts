import { IObservation, Observation } from './../../models/iobservation';
import { ObservationEditDialogComponent } from './../../observation/observation-edit-dialog/observation-edit-dialog.component';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { MarkerNames } from '../../models/enum/marker-names.enum';
import { MatDialog, MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-chart-cell',
  templateUrl: './chart-cell.component.html',
  styleUrls: ['./chart-cell.component.css']
})
export class ChartCellComponent implements OnInit {
  @Input() row: number;
  @Input() col: number;
  // markerUrl: string;
  // markerAltText: string;
  // date: string;
  // letter: string;
  // numTimes: string;
  // cipherAndCipherCD: string;
  // comments: string;
  // noteMarks: string;

  observation: IObservation = new Observation();
  observationEditDialogRef: MatDialogRef<ObservationEditDialogComponent>;

  constructor(private dialog: MatDialog) {
    this.row = 0;
    this.col = 0;
    // this.markerUrl = './../../../assets/img/marker' + MarkerNames.markerNone + '.jpg';
    // this.markerAltText = MarkerNames.markerNone;
    // this.date = '"&nbsp"';
    // this.letter = 'x ';
    // this.numTimes = 'x ';
    // this.cipherAndCipherCD = 'x ';
    // this.comments = 'x ';
    // this.noteMarks = 'x ';
  }

  ngOnInit() {
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

  onCellClicked() {
    //console.log('from cell: ' + this.row + ',' + this.col);
    this.observationEditDialogRef = this.dialog.open(ObservationEditDialogComponent, {
      hasBackdrop: true
    });
    //this.observationEditDialogRef.componentInstance.chart = this.chart;
  }

}
