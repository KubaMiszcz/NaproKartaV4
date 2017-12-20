import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-chart-cell',
  templateUrl: './chart-cell.component.html',
  styleUrls: ['./chart-cell.component.css']
})
export class ChartCellComponent implements OnInit {
  @Input() row: number;
  @Input() col: number;
  markerUrl: string;
  markerAltText: string;
  date: string;
  letter: string;
  numTimes: string;
  cipherAndCipherCD: string;
  comments: string;
  noteMarks: string;

  constructor() {
    this.markerUrl = '../../../assets/img/markers/markerGreyxxx.jpg';
    this.markerAltText = 'altext';
    this.date = '12-12';
    this.letter = 'H B';
    this.numTimes = 'XD';
    this.cipherAndCipherCD = '10CD';
    this.comments = this.convertArrayToString(['B', 'W', 'I']);
    this.noteMarks = this.convertArrayToString(['W', 'W', 'W']);
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
    console.log('from cell: ' + this.row + ',' + this.col);
  }

}
