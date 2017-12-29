import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MycompComponent } from './mycomp/mycomp.component';
import { RouterModule } from '@angular/router';

@NgModule({
  imports: [
    CommonModule
    , RouterModule.forChild([
      { path: 'test2', component: MycompComponent }
    ])
  ],
  declarations: [MycompComponent],
  // exports: [
  //   MycompComponent
  // ]
})
export class MymoduleModule { }
