import { Component, Input, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ChartModifyDialogComponent } from './chart-modify-dialog/chart-modify-dialog.component';
import { MatDialog, MatDialogRef } from '@angular/material';

import { ChartService } from '../services/chart.service';

import { IChart } from './../models/ichart';
import { ICycle, Cycle } from '../models/icycle';
import { IObservation, Observation } from '../models/iobservation';

// import { MaterialsModule } from './../materials/materials.module';

//import { OnDestroy } from '@angular/core/src/metadata/lifecycle_hooks';

const maxCycles = 2;

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.css']
})

export class ChartComponent implements OnInit, OnDestroy {
  chartTitle: string;
  chartNote: string;
  chart: IChart;
  cycles: ICycle[];
  currentChartId: number;
  sub: any;
  chartModifyDialogRef: MatDialogRef<ChartModifyDialogComponent>;

  constructor(private chartService: ChartService, private route: ActivatedRoute, private router: Router, private dialog: MatDialog) { }

  ngOnInit() {
    this.cycles = new Array<Cycle>(maxCycles);

    this.sub = this.route.paramMap
      .subscribe(v => this.UpdateChart(+v.get('id')),
      error => console.log(error),
    );
  }

  UpdateChart(id: number) {
    this.currentChartId = id;

    this.chartService.GetChart(this.currentChartId)
      .subscribe(chart => this.chart = chart, error => console.log(error), () => {
        this.chartTitle = this.chart.title;
        this.chartNote = this.chart.note;
      });
  }

  DeleteChart() {
    this.chartService.DeleteChart(this.currentChartId)
      .subscribe(msg => console.log(msg)
      , error => console.log(error));
    this.router.navigate(['/welcome']);

  }

  ModifyChart() {
    this.chartModifyDialogRef = this.dialog.open(ChartModifyDialogComponent, {
      hasBackdrop: true
    });
    this.chartModifyDialogRef.componentInstance.chart = this.chart;

  }


  ngOnDestroy() {
    //Called once, before the instance is destroyed.
    //Add 'implements OnDestroy' to the class.
    this.sub.unsubscribe();
  }

}
