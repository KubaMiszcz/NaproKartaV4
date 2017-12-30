import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MaterialsModule } from './../materials/materials.module';

@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    CommonModule
    , FormsModule
    , MaterialsModule
    // , NavBarComponent
  ]
  // declarations: [
  //   NavBarComponent
  //   ,
  // ],
})
export class SharedModule { }
