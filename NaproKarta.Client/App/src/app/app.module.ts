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
  , MatSnackBarModule
  , MatDialogModule
} from '@angular/material';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
//=======================end materials

import { AppService } from './services/app.service';
import { UserService } from './services/user.service';
import { ChartService } from './services/chart.service';

import { DateMmDdPipe } from './shared/pipes/date-mm-dd.pipe';

import { WelcomeComponent } from './shared/welcome/welcome.component';
import { ErrorPageComponent } from './shared/error-page/error-page.component';
import { NavBarComponent } from './shared/nav-bar/nav-bar.component';

import { ChartComponent } from './chart/chart/chart.component';
import { ChartAddComponent } from './chart/chart/chart-add/chart-add.component';
import { ChartCellComponent } from './chart/chart-cell/chart-cell.component';
import { ChartCycleComponent } from './chart/chart-row/chart-row.component';
import { ObservationComponent } from './observation/observation.component';

import { MyToggleSwitchComponent } from './shared/ZZZmy-toggle-switch/my-toggle-switch.component';
import { ProgressSpinnerOverviewComponent } from './shared/progress-spinner-overview/progress-spinner-overview.component';
import { ChartAddDialogComponent } from './chart/chart/chart-add-dialog/chart-add-dialog.component';
import { ErrorDialogComponent } from './shared/error-dialog/error-dialog.component';
import { ObservationEditFormComponent } from './chart/chart-cell/observation-edit-form/observation-edit-form.component';


@NgModule({
  declarations: [
    AppComponent
    , ErrorPageComponent
    , ChartComponent
    , ChartCycleComponent
    , ChartCellComponent
    , ObservationComponent
    , MyToggleSwitchComponent
    , DateMmDdPipe
    , NavBarComponent
    , WelcomeComponent
    , ChartAddComponent
    , ProgressSpinnerOverviewComponent
    , ChartAddDialogComponent
    , ErrorDialogComponent, ObservationEditFormComponent
  ],
  entryComponents: [
    //dialogs components only
    ChartAddDialogComponent
    , ErrorDialogComponent
  ],
  imports: [
    RouterModule.forRoot([
      { path: 'add-chart', component: ChartAddComponent }
      , { path: 'chart/:id', component: ChartComponent }
      , { path: 'observation/:id', component: ObservationEditFormComponent }
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
    , MatSnackBarModule
    , MatDialogModule
    //material end
  ],
  providers: [UserService, AppService, ChartService],
  bootstrap: [AppComponent]
})
export class AppModule { }
