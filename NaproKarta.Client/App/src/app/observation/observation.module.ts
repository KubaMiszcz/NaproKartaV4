import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { SharedModule } from './../shared/shared.module';

import { ObservationEditComponent } from './observation-edit/observation-edit.component';
import { ObservationEditDialogComponent } from './observation-edit-dialog/observation-edit-dialog.component';

import { DateNavBarComponent } from './groupBoxes/date-nav-bar/date-nav-bar.component';
import { MarkersGroupBoxComponent } from './groupBoxes/markers-group-box/markers-group-box.component';
import { RadioGroup1ColumnComponent } from './groupBoxes/radio-group-1-column/radio-group-1-column.component';
import { RadioGroup2ColumnsComponent } from './groupBoxes/radio-group-2-columns/radio-group-2-columns.component';
import { ObservationNoteComponent } from './groupBoxes/observation-note/observation-note.component';

@NgModule({
  imports: [
    CommonModule
    , SharedModule
    , RouterModule.forChild([
      { path: 'observation/:id', component: ObservationEditComponent }
    ])
  ],
  declarations: [
    ObservationEditComponent
    , ObservationEditDialogComponent
    , DateNavBarComponent
    , MarkersGroupBoxComponent
    , RadioGroup1ColumnComponent
    , RadioGroup2ColumnsComponent
    , ObservationNoteComponent
  ],
  entryComponents: [
    ObservationEditDialogComponent
  ]
  // , exports: [
  //   ObscomComponent
  // ]
})
export class ObservationModule { }
