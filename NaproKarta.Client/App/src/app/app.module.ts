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
  , MatDatepickerModule
  , MatProgressSpinnerModule
  , MatFormFieldModule
  , MatInputModule
  , MatNativeDateModule
  , MatIconModule
  , MatRadioModule

} from '@angular/material';
// import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
// import { MatFormFieldModule } from '@angular/material/form-field';
// import { MatInputModule } from '@angular/material/input';
//=======================end materials

import { AppService } from './services/app.service';
import { UserService } from './services/user.service';
import { ChartService } from './services/chart.service';

import { DateMmDdPipe } from './shared/pipes/date-mm-dd.pipe';

import { WelcomeComponent } from './shared/welcome/welcome.component';
import { ErrorPageComponent } from './shared/error-page/error-page.component';
import { NavBarComponent } from './shared/nav-bar/nav-bar.component';

import { ChartComponent } from './chart/chart.component';
import { ChartAddDialogComponent } from './chart/chart-add-dialog/chart-add-dialog.component';
import { ChartModifyDialogComponent } from './chart/chart-modify-dialog/chart-modify-dialog.component';
import { ChartCellComponent } from './chart/chart-cell/chart-cell.component';
import { ChartCycleComponent } from './chart/chart-cycle/chart-cycle.component';

import { ObservationEditDialogComponent } from './observation/observation-edit-dialog/observation-edit-dialog.component';

import { MyToggleSwitchComponent } from './shared/ZZZmy-toggle-switch/my-toggle-switch.component';
import { ProgressSpinnerOverviewComponent } from './shared/progress-spinner-overview/progress-spinner-overview.component';
import { ErrorDialogComponent } from './shared/error-dialog/error-dialog.component';
import { RadioGroup2ColumsComponent } from './observation/observation-edit-dialog/radio-group-2-colums/radio-group-2-colums.component';


@NgModule({
  declarations: [
    AppComponent
    , DateMmDdPipe
    , ErrorPageComponent
    , ErrorDialogComponent
    , WelcomeComponent
    , NavBarComponent
    , ChartComponent
    , ChartAddDialogComponent
    , ChartModifyDialogComponent
    , ChartCycleComponent
    , ChartCellComponent
    , ObservationEditDialogComponent
    , ProgressSpinnerOverviewComponent
    , MyToggleSwitchComponent 
    , RadioGroup2ColumsComponent
  ],
  entryComponents: [
    //dialogs components only
    ErrorDialogComponent
    , ChartAddDialogComponent
    , ChartModifyDialogComponent
  ],
  imports: [
    RouterModule.forRoot([
      { path: 'chart/:id', component: ChartComponent }
      , { path: 'test', component: ObservationEditDialogComponent }
      , { path: 'observation/:id', component: ObservationEditDialogComponent }
      , { path: 'settings', redirectTo: 'http://localhost/NaproKarta/Manage' }
      , { path: 'error', component: ErrorPageComponent }
      , { path: 'welcome', component: WelcomeComponent }
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
    , MatDatepickerModule
    , MatNativeDateModule
    , MatIconModule
    , MatRadioModule
    //material end
  ],
  providers: [UserService, AppService, ChartService],
  bootstrap: [AppComponent]
})
export class AppModule { }
