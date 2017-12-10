import { ChartService } from '../../services/chart.service';
import { IChart } from './../../models/ichart';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { OnChanges } from '@angular/core/src/metadata/lifecycle_hooks';

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

  constructor(private chartService: ChartService, private route: ActivatedRoute) {
    this.currentChartId = +this.route.snapshot.paramMap.get('id');
    console.log(this.currentChartId);
  }


  ngOnInit() {
    this.chartService.GetChartById(this.currentChartId)
      .subscribe(chart => this.chart = chart, error => console.log(error), () => {
        this.chartTitle = this.chart.title;
        this.chartNote = this.chart.note;
      });
    console.log('aat' + this.currentChartId);
  }


}
