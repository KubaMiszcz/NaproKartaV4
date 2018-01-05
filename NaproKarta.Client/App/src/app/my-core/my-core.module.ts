import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from './../shared/shared.module';
import { RouterModule } from '@angular/router';
// import { MyOwnMaterialsModule } from './../my-own-materials/my-own-materials.module';

import { NavBarComponent } from './nav-bar/nav-bar.component';
import { WelcomeComponent } from './welcome/welcome.component';

@NgModule({
  imports: [
    CommonModule
    , SharedModule
    // , MyOwnMaterialsModule
    , RouterModule.forChild([
      { path: 'welcome', component: WelcomeComponent }
    ])
  ],
  declarations: [
    NavBarComponent
    , WelcomeComponent
  ]
  , exports: [
    NavBarComponent
  ]
})
export class MyCoreModule { }
