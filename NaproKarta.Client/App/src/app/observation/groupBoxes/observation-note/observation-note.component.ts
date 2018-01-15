import { Component, OnInit } from '@angular/core';
import { INote } from './../../../models/inote';

@Component({
  selector: 'app-observation-note',
  templateUrl: './observation-note.component.html',
  styleUrls: ['./observation-note.component.css']
})
export class ObservationNoteComponent implements OnInit {
  note: INote;
  noteMark: string;

  constructor() {
    this.note = new INote();
    this.note.content = 'dssdsds';
    this.note.isImportant = true;
    this.noteMarkUpdate();
  }

  ngOnInit() {
  }

  noteMarkUpdate() {
    this.noteMark = this.note.content.slice(0, 1).toUpperCase();
    console.log('obs note');
  }
}
