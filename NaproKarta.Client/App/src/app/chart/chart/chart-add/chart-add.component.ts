import { IChart, Chart } from './../../../models/ichart';
import { Component, OnInit } from '@angular/core';
import { ChartService } from '../../../services/chart.service';
import { GlobalVariables } from '../../../global-variables';

@Component({
  selector: 'app-chart-add',
  templateUrl: './chart-add.component.html',
  styleUrls: ['./chart-add.component.css']
})
export class ChartAddComponent implements OnInit {
  chartToAdd: IChart = new Chart();
  response: any;

  constructor(private chartService: ChartService) { }

  ngOnInit() {
    this.chartToAdd.title = 'karta nr ...';
    this.chartToAdd.title = '';
  }

  AddChart(): number {
    this.chartService.AddChart(this.chartToAdd)
      .subscribe(msg => this.response = msg, error => console.log(error), () => console.log(this.response));

      
//todo: check other repsonse: not logged, wrong model etc
    
    // [routerLink]="[ '/chart',chartIdAndTitle.id]"
    return null;
  }


}
