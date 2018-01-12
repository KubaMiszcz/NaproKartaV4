//before material, and only once, in submodules use CommonModule instead
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import 'hammerjs';
import { SharedModule } from './shared/shared.module';
import { MyCoreModule } from './my-core/my-core.module';

import { AppComponent } from './app.component';

import { AppService } from './services/app.service';
import { UserService } from './services/user.service';
import { ChartService } from './services/chart.service';
import { ObservationService } from './services/observation.service';

import { ChartModule } from './chart/chart.module';
import { ObservationModule } from './observation/observation.module';

@NgModule({
  declarations: [
    AppComponent
    // , NavBarComponent
    // , WelcomeComponent
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
      , { path: '', redirectTo: 'welcome', pathMatch: 'full' }
      , { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
    ])
    , BrowserModule
    , HttpClientModule
    , BrowserAnimationsModule
    , SharedModule
    , MyCoreModule
    , ChartModule
    , ObservationModule
  ],
  providers: [AppService, UserService, ChartService, ObservationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
