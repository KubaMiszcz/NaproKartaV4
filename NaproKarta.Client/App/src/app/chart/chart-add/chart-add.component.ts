import { IChart, Chart } from './../../models/ichart';
import { Component, OnInit } from '@angular/core';
import { ChartService } from '../../services/chart.service';

@Component({
  selector: 'app-chart-add',
  templateUrl: './chart-add.component.html',
  styleUrls: ['./chart-add.component.css']
})
export class ChartAddComponent implements OnInit {
  chartToAdd: IChart = new Chart();

  constructor(private chartService: ChartService) { }

  ngOnInit() {
    this.chartToAdd.title = 'karta nr ...';
    this.chartToAdd.title = '';
  }

  // AddNewChart(): number {
  //   console.log('title' + this.chartToAdd.title);
  //   console.log('not' + this.chartToAdd.note);
  //   console.log('not' + this.chartToAdd);

  //   const msg = this.chartService.AddChart(this.chartToAdd);

  //   // if (msg[0] !== 0) {
  //   //  console.log(msg);
  //   // alert(msg[1]);
  //   // }
  //   return null;
  // }


}
