import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-chart-cell',
  templateUrl: './chart-cell.component.html',
  styleUrls: ['./chart-cell.component.css']
})
export class ChartCellComponent implements OnInit {
  row: number;
  col: number;
  markerUrl: string;
  markerAltText: string;
  date: string;
  letter: string;
  numTimes: string;
  cipherAndCipherCD: string;
  comments: string;
  noteMarks: string;

  constructor() { }

  ngOnInit() {
    this.row = 0;
    this.col = 0;
    this.markerUrl = '../../../assets/img/markers/markerGreyxxx.jpg';
    this.markerAltText = 'altext';
    this.date = '12-12';
    this.letter = 'H B';
    this.numTimes = 'XD';
    this.cipherAndCipherCD = '10CD';
    this.comments = this.convertArrayToString(['B', 'W', 'I']);
    this.noteMarks = this.convertArrayToString(['W', 'W', 'W']);

  }

  convertArrayToString(array: string[]): string {
    var arr = '';
    array.forEach(element => {
      arr += (element.toUpperCase() + ' ');
      arr.slice(0, -1);
    });
    return arr;
  }

}
