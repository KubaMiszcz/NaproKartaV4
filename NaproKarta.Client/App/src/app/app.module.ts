import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule, Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import 'hammerjs';
import { MaterialsModule } from './materials/materials.module';
import { AppComponent } from './app.component';

import { AppService } from './services/app.service';
import { UserService } from './services/user.service';
import { ChartService } from './services/chart.service';

 import { DateMmDdPipe } from './shared/pipes/date-mm-dd.pipe';

import { WelcomeComponent } from './shared/welcome/welcome.component';
import { ErrorPageComponent } from './shared/error-page/error-page.component';
import { NavBarComponent } from './shared/nav-bar/nav-bar.component';

import { ChartModule } from './chart/chart.module';
import { ObservationModule } from './observation/observation.module';

//import { ObservationEditDialogComponent } from './observation/observation-edit-dialog/observation-edit-dialog.component';

// import { ProgressSpinnerOverviewComponent } from './shared/progress-spinner-overview/progress-spinner-overview.component';
// import { ErrorDialogComponent } from './shared/error-dialog/error-dialog.component';
// import { RadioGroup2ColumsComponent } from './observation/observation-edit-dialog/radio-group-2-colums/radio-group-2-colums.component';

import { MymoduleModule } from './mymodule/mymodule.module';


@NgModule({
  declarations: [
    AppComponent
    , DateMmDdPipe
    , ErrorPageComponent
    // , ErrorDialogComponent
    , WelcomeComponent
    , NavBarComponent
    //    , ObservationEditDialogComponent
    // , ProgressSpinnerOverviewComponent
    // , RadioGroup2ColumsComponent
  ],
  entryComponents: [
    //dialogs components only
    // ErrorDialogComponent
  ],
  imports: [
    RouterModule.forRoot([
      //    { path: 'test', component: ObservationEditDialogComponent }
      // , { path: 'chart/:id', component: ChartComponent }
      //  , { path: 'observation/:id', component: ObservationEditDialogComponent }
      { path: 'settings', redirectTo: 'http://localhost/NaproKarta/Manage' }
      , { path: 'error', component: ErrorPageComponent }
      , { path: 'welcome', component: WelcomeComponent }
      , { path: '', redirectTo: 'welcome', pathMatch: 'full' }
      , { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
    ])
    , BrowserModule
    , FormsModule
    , HttpClientModule
    , BrowserAnimationsModule
    , MaterialsModule
    , ChartModule
    , ObservationModule
    , MymoduleModule
  ],
  providers: [AppService, UserService, ChartService],
  bootstrap: [AppComponent]
})
export class AppModule { }
