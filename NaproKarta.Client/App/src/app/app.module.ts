import { ErrorPageComponent } from './shared/error-page/error-page.component';
import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule, Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import {
  MatSlideToggleModule
  , MatCheckboxModule
  , MatButtonModule
  , MatButtonToggleModule
  , MatSelectModule
} from '@angular/material';
import { MatFormFieldModule } from '@angular/material/form-field';

import { WelcomeComponent } from './shared/welcome/welcome.component';
import { NavBarComponent } from './shared/nav-bar/nav-bar.component';

import { ChartComponent } from './chart/chart/chart.component';
import { ChartCellComponent } from './chart/chart-cell/chart-cell.component';
import { ChartRowComponent } from './chart/chart-row/chart-row.component';
import { ObservationComponent } from './observation/observation.component';

import { MyToggleSwitchComponent } from './my-toggle-switch/my-toggle-switch.component';
import { DateMmDdPipe } from './shared/pipes/date-mm-dd.pipe';
import { UserService } from './services/user.service';

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
  ],
  imports: [
    RouterModule.forRoot([
      { path: 'chart/:id', component: ChartComponent }
      , { path: 'error-page', component: ErrorPageComponent }
      , { path: 'welcome', component: WelcomeComponent }
      , { path: '', redirectTo: 'welcome', pathMatch: 'full' }
      , { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
    ])
    , BrowserModule
    , FormsModule
    , HttpClientModule
    , BrowserAnimationsModule
    , MatSlideToggleModule
    , MatButtonModule
    , MatCheckboxModule
    , MatButtonToggleModule
    , MatSelectModule
    , MatFormFieldModule
  ],
  providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
