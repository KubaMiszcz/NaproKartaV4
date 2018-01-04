import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MyOwnMaterialsModule } from './../my-own-materials/my-own-materials.module';


@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    CommonModule
    , FormsModule
    , MyOwnMaterialsModule
    // , NavBarComponent
  ]
  // declarations: [
  //   NavBarComponent
  //   ,
  // ],
})
export class SharedModule { }
