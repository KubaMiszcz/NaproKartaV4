import { IChart } from './../../viewModels/ichart';
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
    this.chart = this.userService.GetChart();
  }

}
