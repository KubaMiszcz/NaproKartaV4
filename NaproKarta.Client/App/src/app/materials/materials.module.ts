import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  MatSlideToggleModule
  , MatCheckboxModule
  , MatButtonModule
  , MatButtonToggleModule
  , MatSelectModule
  , MatCardModule
  , MatGridListModule
  , MatSnackBarModule
  , MatDialogModule
  // , MatDialogRef
  , MatDatepickerModule
  , MatNativeDateModule
  , MatProgressSpinnerModule
  , MatFormFieldModule
  , MatInputModule
  , MatIconModule
  , MatRadioModule
} from '@angular/material';

@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    MatSlideToggleModule
    , MatCheckboxModule
    , MatButtonModule
    , MatButtonToggleModule
    , MatSelectModule
    , MatCardModule
    , MatGridListModule
    , MatSnackBarModule
    , MatDialogModule
    // , MatDialogRef
    , MatDatepickerModule
    , MatNativeDateModule
    , MatProgressSpinnerModule
    , MatFormFieldModule
    , MatInputModule
    , MatIconModule
    , MatRadioModule
  ]
  // , declarations: [
  //   MatDialog
  // ]
})
export class MaterialsModule { }
