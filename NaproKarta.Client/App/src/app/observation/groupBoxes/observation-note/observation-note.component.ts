import { Component, OnInit, Input } from '@angular/core';
import { INote } from './../../../models/inote';
import { notEqual } from 'assert';

@Component({
  selector: 'app-observation-note',
  templateUrl: './observation-note.component.html',
  styleUrls: ['./observation-note.component.css']
})
export class ObservationNoteComponent implements OnInit {
  noteMark: string;
  @Input() note: INote;

  constructor() {
    // this.note = new INote();
    // this.note.content = 'dssdsds';
    // this.note.isImportant = true;
    // this.noteMarkUpdate();
  }

  ngOnInit() {
    console.log(' ' + JSON.stringify(this.note));
    this.noteMarkUpdate();
  }

  noteMarkUpdate() {
    this.noteMark = this.note.content.substr(0, 1).toUpperCase();
    // console.log('obs note');
  }
}
