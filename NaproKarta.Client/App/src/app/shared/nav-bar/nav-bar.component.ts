import { AppService } from '../../services/app.service';
import { IChart } from './../../models/ichart';
import { Component, OnInit } from '@angular/core';
import { INavBar } from '../../models/navbar';
import { Input } from '@angular/core/src/metadata/directives';



@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {
  navBarData: INavBar;
  userName: string;
  isLogged: boolean;
  chartIdsAndTitles: any;
  //const applicationUrl = 'http://www.naproclient.hostingasp.pl';
  applicationUrl = 'http://localhost/NaproKarta';

  foods = [
    { value: 'steak-0', viewValue: 'Steak' },
    { value: 'pizza-1', viewValue: 'Pizza' },
    { value: 'tacos-2', viewValue: 'Tacos' }
  ];

  constructor(private appService: AppService) { }

  ngOnInit() {

    this.appService.GetNavBarData()
      .subscribe(navBarData => this.navBarData = navBarData, error => console.log(error), () => {
        this.userName = this.navBarData.userName;
        this.isLogged = this.navBarData.isLogged;
        this.chartIdsAndTitles = this.navBarData.chartIdsAndTitles;
        // console.log(this.navBarData.chartIdsAndTitles);
      });
  }
}
