import { Component, Input, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ChartUpdateDialogComponent } from './chart-update-dialog/chart-update-dialog.component';
import { MatDialog, MatDialogRef } from '@angular/material';

import { ChartService } from '../services/chart.service';

import { IChart, Chart } from './../models/ichart';
import { ICycle, Cycle } from '../models/icycle';

//import { OnDestroy } from '@angular/core/src/metadata/lifecycle_hooks';

const maxCycles = 5;

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.css']
})

export class ChartComponent implements OnInit, OnDestroy {
  cycles: ICycle[];
  chart: IChart;
  sub: any;
  ChartUpdateDialogRef: MatDialogRef<ChartUpdateDialogComponent>;

  constructor(private chartService: ChartService, private route: ActivatedRoute, private router: Router, private dialog: MatDialog) {
  }

  ngOnInit() {
    this.chart = new Chart();
    this.cycles = new Array(maxCycles);
    for (let i = 0; i < maxCycles; i++) {
      this.cycles[i] = new Cycle();
      this.cycles[i].id = 0;
      this.cycles[i].chartId = 0;
    }

    this.sub = this.route.paramMap
      .subscribe(v => this.RefreshChart(+v.get('id'))
      , error => console.log(error));
  }

  RefreshChart(id: number) {
    this.chartService.GetChart(id)
      .subscribe(chart => this.chart = chart
      , error => console.log(error)
      , () => {
        this.chart.cycles.forEach(element => {
          this.cycles[element.numberInChart] = element;
        });
      });
  }

  DeleteChart() {
    if (confirm('na pewno usunac?')) {
      this.chartService.DeleteChart(this.chart.id)
        .subscribe(msg => console.log(msg)
        , error => console.log(error));
      this.router.navigate(['/welcome']);
    } else {
      // Do nothing!
    }
  }

  UpdateChartDialog() {
    this.ChartUpdateDialogRef = this.dialog.open(ChartUpdateDialogComponent, {
      hasBackdrop: true
    });
    this.ChartUpdateDialogRef.componentInstance.chart = this.chart;
  }

  ngOnDestroy() {
    //Called once, before the instance is destroyed. Add 'implements OnDestroy' to the class.
    this.sub.unsubscribe();
  }

}
