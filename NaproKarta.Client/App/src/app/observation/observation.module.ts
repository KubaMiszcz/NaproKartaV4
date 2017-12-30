import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ObservationComponent } from './observation.component';
import { ObservationEditDialogComponent } from './observation-edit-dialog/observation-edit-dialog.component';
import { RouterModule } from '@angular/router';


@NgModule({
  imports: [
    CommonModule
    , RouterModule.forChild([
      { path: 'observation/:id', component: ObservationEditDialogComponent }
    ])
  ],
  declarations: [ObservationComponent
    , ObservationEditDialogComponent],
  entryComponents: [
    ObservationEditDialogComponent
  ]
})
export class ObservationModule { }
