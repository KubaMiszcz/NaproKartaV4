import { GlobalVariables } from './../../../global-variables';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { INote } from './../../../models/inote';
import { notEqual } from 'assert';

@Component({
  selector: 'app-observation-note',
  templateUrl: './observation-note.component.html',
  styleUrls: ['./observation-note.component.css']
})
export class ObservationNoteComponent implements OnInit {
  @Input() note: INote;
  @Output() notify: EventEmitter<INote> = new EventEmitter<INote>();

  constructor() {
    // this.note = new INote();
    // this.note.content = 'dssdsds';
    // this.note.isImportant = true;
    // this.noteMarkUpdate();
  }

  ngOnInit() {
    // console.log(' ' + JSON.stringify(this.note));
    // this.noteMarkUpdate();
  }

  passValueFromEvent() {
    this.notify.emit(this.note);
  }
}
