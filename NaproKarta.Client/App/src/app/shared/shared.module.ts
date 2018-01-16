import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MyOwnMaterialsModule } from './../my-own-materials/my-own-materials.module';

import { ErrorDialogComponent } from './error-dialog/error-dialog.component';
import { DateMmDdPipe } from './date-mm-dd.pipe';
import { OnlyFirstUpperLetter } from './only-first-upper-letter.pipe';


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
    , DateMmDdPipe
    , OnlyFirstUpperLetter
  ],
  entryComponents: [ //dialogs components only
    ErrorDialogComponent
  ],
  exports: [
    FormsModule
    , MyOwnMaterialsModule
    , ErrorDialogComponent
    , DateMmDdPipe
    , OnlyFirstUpperLetter
  ]
})
export class SharedModule { }
