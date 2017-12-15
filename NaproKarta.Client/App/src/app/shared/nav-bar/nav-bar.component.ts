import { AppService } from '../../services/app.service';
import { IChart } from './../../models/ichart';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { INavBar } from '../../models/inavbar';
import { GlobalVariables } from '../../global-variables';
import { IChartIdAndTitle } from '../../models/auxmodels/chart-id-and-title';


@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {
  applicationUrl = GlobalVariables.BASE_NAPROCLIENT_URL;
  navBarData: INavBar;
  userName: string;
  isLogged: boolean;
  chartIdsAndTitles: IChartIdAndTitle[];
  @Output() chartChanged: EventEmitter<number> = new EventEmitter<number>();

  foods = [
    { value: 'steak-0', viewValue: 'Steak' },
    { value: 'pizza-1', viewValue: 'Pizza' },
    { value: 'tacos-2', viewValue: 'Tacos' }
  ];

  constructor(private appService: AppService) { }

  ngOnInit() {
    this.appService.GetNavBarData()
      .subscribe(navBarData => this.navBarData = navBarData
      , error => console.log(error)
      , () => {
        this.userName = this.navBarData.userName;
        this.isLogged = this.navBarData.isLogged;
        this.chartIdsAndTitles = this.navBarData.chartIdsAndTitles;
        // console.log(this.navBarData.chartIdsAndTitles);
      });
  }

  RefreshChart(id: number) {
    this.chartChanged.emit(id);
  }
}
