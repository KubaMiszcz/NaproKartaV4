import { IChart } from './../../models/ichart';
import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.css']
})
export class ChartComponent implements OnInit {
  chartName = 'karta1';
  chartNote = 'Cards are built with as little markup and styles as possible, but still manage to deliver a ton of control and customization. Built with flexbox, they offer easy alignment and mix well with other Bootstrap components.';
  chart: IChart;
  constructor(private userService: UserService) { }

  ngOnInit() {
    // this.chart = this.userService.GetChart()
    // .subscribe(chart => this.chart = (chart as IChart), error => console.log(error));

    // this.userService.getUserInfo()
    // .subscribe(user => this.user = user, error => console.log(error), () => {
    //   this.restaurantService.userInfo = this.user;
    //   this.restaurantService.balance = this.user.balance;
    //   this.isAdmin = this.user.isAdmin;
    // });

    // this.restaurantService.getUserInfo()
    // .subscribe(user => this.user = user, error => console.log(error), () => {
    //   this.restaurantService.userInfo = this.user;
    //   this.restaurantService.balance = this.user.balance;
    //   this.isAdmin = this.user.isAdmin;
    // });
  }

}
