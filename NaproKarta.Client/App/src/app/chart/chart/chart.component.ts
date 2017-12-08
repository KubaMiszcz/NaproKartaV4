import { UserService } from './../../services/user.service';
import { IChart } from './../../models/ichart';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.css']
})
export class ChartComponent implements OnInit {
  chartTitle: string = 'chhh';
  chartNote: string = 'adsadsad';
  chart: IChart;
  currentChartId: number;
  constructor(private userService: UserService, private route: ActivatedRoute) {
    this.currentChartId = +this.route.snapshot.paramMap.get('id');
    console.log(this.currentChartId);
  }


  ngOnInit() {
    this.userService.GetChartById(this.currentChartId)
      .subscribe(chart => this.chart = chart, error => console.log(error), () => {
        this.chartTitle = this.chart.title;
        this.chartNote = this.chart.note;
      });
  }

}
