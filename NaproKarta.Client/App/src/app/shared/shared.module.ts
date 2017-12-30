import { NavBarComponent } from './nav-bar/nav-bar.component';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';



@NgModule({
  imports: [
    CommonModule
  ],
  // declarations: [
  //   NavBarComponent
  //   ,
  // ],
  exports: [
    CommonModule,
    , FormsModule
    // , NavBarComponent
  ]
})
export class SharedModule { }
