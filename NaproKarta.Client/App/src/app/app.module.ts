import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {
  MatSlideToggleModule
  , MatCheckboxModule
  , MatButtonModule
  , MatButtonToggleModule
  , MatSelectModule
} from '@angular/material';
import { MatFormFieldModule } from '@angular/material/form-field';

import { NavBarComponent } from './shared/nav-bar/nav-bar.component';
import { WelcomeComponent } from './shared/welcome/welcome.component';

import { ChartCellComponent } from './chart/chart-cell/chart-cell.component';
import { ChartRowComponent } from './chart/chart-row/chart-row.component';
import { ChartComponent } from './chart/chart/chart.component';
import { ObservationComponent } from './observation/observation.component';

import { MyToggleSwitchComponent } from './my-toggle-switch/my-toggle-switch.component';
import { DateMmDdPipe } from './services/date-mm-dd.pipe';
import { UserService } from './services/user.service';

@NgModule({
  declarations: [
    AppComponent
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
      { path: 'bs', redirectTo: 'https://getbootstrap.com/docs/4.0/components/card/path' }
      // {path: 'chartList', component: ChartListComponent}
      // { path: 'error-page', component: ErrorPageComponent },
       , { path: 'welcome', component: WelcomeComponent },
      //  , { path: '', redirectTo: 'welcome', pathMatch: 'full' }
      //  , { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
    ])
    , BrowserModule
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
