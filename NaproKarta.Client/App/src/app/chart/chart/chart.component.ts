import { ICycle } from './../../models/icycle';
import { ChartService } from '../../services/chart.service';
import { IChart } from './../../models/ichart';
import { Component, Input, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscriber } from 'rxjs/Subscriber';
import { Subscription } from 'rxjs/Subscription';
//import { OnDestroy } from '@angular/core/src/metadata/lifecycle_hooks';


@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.css']
})
export class ChartComponent implements OnInit, OnDestroy {
  chartTitle: string = 'chhh';
  chartNote: string = 'adsadsad';
  chart: IChart;
  cycles: ICycle[];
  currentChartId: number;
  sub: any;

  constructor(private chartService: ChartService, private route: ActivatedRoute) {
    // this.currentChartId = +this.route.snapshot.paramMap.get('id');
    // console.log(this.currentChartId);
  }

  ngOnInit() {
    this.sub = this.route.paramMap
      .subscribe(v => this.UpdateChart(+v.get('id')),
      error => console.log(error),
    );
    //console.log('aat' + this.currentChartId);
  }

  // ngOnChanges(changes: SimpleChanges) {
  UpdateChart(id: number) {
    this.currentChartId = id;

    this.chartService.GetChart(this.currentChartId)
      .subscribe(chart => this.chart = chart, error => console.log(error), () => {
        this.chartTitle = this.chart.title;
        this.chartNote = this.chart.note;
      });
  }

  ngOnDestroy() {
    //Called once, before the instance is destroyed.
    //Add 'implements OnDestroy' to the class.
    this.sub.unsubscribe();
  }

}
