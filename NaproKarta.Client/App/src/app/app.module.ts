//before material, and only once, in submodules use CommonModule instead
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import 'hammerjs';
import { SharedModule } from './shared/shared.module';
import { AppComponent } from './app.component';

import { AppService } from './services/app.service';
import { UserService } from './services/user.service';
import { ChartService } from './services/chart.service';

import { NavBarComponent } from './shared/nav-bar/nav-bar.component';
import { WelcomeComponent } from './shared/welcome/welcome.component';

import { ChartModule } from './chart/chart.module';
import { MymoduleModule } from './mymodule/mymodule.module';

//import { ObservationModule } from './observation/observation.module';
//import { ObservationEditDialogComponent } from './observation/observation-edit-dialog/observation-edit-dialog.component';

@NgModule({
  declarations: [
    AppComponent
    , NavBarComponent
    , WelcomeComponent
    // , DateMmDdPipe
    // , ErrorPageComponent
    // , ErrorDialogComponent
    // , ObservationEditDialogComponent
    // , ProgressSpinnerOverviewComponent
    // , RadioGroup2ColumsComponent
  ],
  entryComponents: [
    //dialogs components only
    // ErrorDialogComponent
  ],
  imports: [
    RouterModule.forRoot([
      { path: 'settings', redirectTo: 'http://localhost/NaproKarta/Manage' }
      //  , { path: 'observation/:id', component: ObservationEditDialogComponent }
      , { path: 'welcome', component: WelcomeComponent }
      , { path: '', redirectTo: 'welcome', pathMatch: 'full' }
      , { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
    ])
    , BrowserModule
    , HttpClientModule
    , BrowserAnimationsModule
    , SharedModule
    , ChartModule
    // , ObservationModule
    , MymoduleModule
  ],
  providers: [AppService, UserService, ChartService],
  bootstrap: [AppComponent]
})
export class AppModule { }
