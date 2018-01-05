import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MyOwnMaterialsModule } from './../my-own-materials/my-own-materials.module';

import { ErrorDialogComponent } from './error-dialog/error-dialog.component';

@NgModule({
  imports: [
    CommonModule
    , FormsModule
    , MyOwnMaterialsModule
    // , RouterModule.forChild([
    //   { path: 'st', component: ObservationNoteComponent }
    // ])
  ],
  declarations: [
    ErrorDialogComponent
  ],
  entryComponents: [ //dialogs components only
    ErrorDialogComponent
  ],
  exports: [
    FormsModule
    , MyOwnMaterialsModule
    , ErrorDialogComponent
  ]
})
export class SharedModule { }
