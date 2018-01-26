import { GlobalVariables } from './../../global-variables';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AppService } from '../../services/app.service';
import { Router } from '@angular/router';
import { MatDialog, MatDialogRef } from '@angular/material';
import { ChartAddDialogComponent } from './../../chart/chart-add-dialog/chart-add-dialog.component';

import { IChart } from './../../models/ichart';
import { INavBar } from '../../models/inavbar';
import { IChartIdAndTitle } from '../../models/auxmodels/chart-id-and-title';
//import { SHARED_FORM_DIRECTIVES } from '@angular/forms/src/directives';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {
  angularUrl = GlobalVariables.BASE_NAPROANGULAR_URL;
  clientUrl = GlobalVariables.BASE_NAPROCLIENT_URL;
  navBarData: INavBar;
  userName: string;
  chartIdsAndTitles: IChartIdAndTitle[];
  chartAddDialogRef: MatDialogRef<ChartAddDialogComponent>;

  //  @Output() chartChanged: EventEmitter<number> = new EventEmitter<number>();

  // foods = [
  //   { value: 'steak-0', viewValue: 'Steak' },
  //   { value: 'pizza-1', viewValue: 'Pizza' },
  //   { value: 'tacos-2', viewValue: 'Tacos' }
  // ];


  constructor(private appService: AppService, private dialog: MatDialog, private router: Router) { }

  ngOnInit() {
    this.appService.GetNavBarData()
      .subscribe(navBarData => this.navBarData = navBarData
      , error => console.log(error)
      , () => {
        this.userName = this.navBarData.userName;
        this.chartIdsAndTitles = this.navBarData.chartIdsAndTitles;
        // console.log(this.navBarData.chartIdsAndTitles);
      });
  }

  RefreshChart(id: number) {
    console.log('i ' + id);

    this.router.navigate(['/chart', id]);
  }

  AddChartByPopup() {
    this.chartAddDialogRef = this.dialog.open(ChartAddDialogComponent, {
      hasBackdrop: true
    });
    this.chartAddDialogRef.componentInstance.chart.title = 'Karta nr ';
    this.chartAddDialogRef.componentInstance.chart.note = '';
  }
}

