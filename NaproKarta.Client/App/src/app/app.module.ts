import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule, Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import 'hammerjs';
//==================materials
import {
  MatSlideToggleModule
  , MatCheckboxModule
  , MatButtonModule
  , MatButtonToggleModule
  , MatSelectModule
  , MatCardModule
  , MatGridListModule
} from '@angular/material';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
//=======================end materials

import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';


import { AppService } from './services/app.service';
import { UserService } from './services/user.service';
import { ChartService } from './services/chart.service';

import { DateMmDdPipe } from './shared/pipes/date-mm-dd.pipe';

import { WelcomeComponent } from './shared/welcome/welcome.component';
import { ErrorPageComponent } from './shared/error-page/error-page.component';
import { NavBarComponent } from './shared/nav-bar/nav-bar.component';

import { ChartComponent } from './chart/chart/chart.component';
//vvvvvvvvvvvvvvvvvvvv
import { ChartAddComponent } from './chart/chart-add/chart-add.component';
import { ChartAdd2Component } from './chart/chart-add2/chart-add2.component';
//^^^^^^^^^^^^^^^^^^
import { ChartCellComponent } from './chart/chart-cell/chart-cell.component';
import { ChartRowComponent } from './chart/chart-row/chart-row.component';
import { ObservationComponent } from './observation/observation.component';

import { MyToggleSwitchComponent } from './shared/ZZZmy-toggle-switch/my-toggle-switch.component';
import { ProgressSpinnerOverviewComponent } from './shared/progress-spinner-overview/progress-spinner-overview.component';


@NgModule({
  declarations: [
    AppComponent
    , ErrorPageComponent
    , ChartComponent
    , ChartRowComponent
    , ChartCellComponent
    , ObservationComponent
    , MyToggleSwitchComponent
    , DateMmDdPipe
    , NavBarComponent
    , WelcomeComponent
    , ChartAddComponent
    , ProgressSpinnerOverviewComponent, ChartAdd2Component
  ],
  imports: [
    RouterModule.forRoot([
      { path: 'add-chart', component: ChartAdd2Component }
      , { path: 'chart/:id', component: ChartComponent }
      , { path: 'error', component: ErrorPageComponent }
      , { path: 'welcome', component: WelcomeComponent }
      , { path: 'settings', redirectTo: 'http://localhost/NaproKarta/Manage' }
      , { path: '', redirectTo: 'welcome', pathMatch: 'full' }
      , { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
    ])
    , BrowserModule
    , FormsModule
    , HttpClientModule
    , BrowserAnimationsModule
    //materials
    , MatInputModule
    , MatSlideToggleModule
    , MatButtonModule
    , MatCheckboxModule
    , MatButtonToggleModule
    , MatSelectModule
    , MatFormFieldModule
    , MatCardModule
    , MatProgressSpinnerModule
    , MatGridListModule
    //material end
  ],
  providers: [UserService, AppService, ChartService],
  bootstrap: [AppComponent]
})
export class AppModule { }
