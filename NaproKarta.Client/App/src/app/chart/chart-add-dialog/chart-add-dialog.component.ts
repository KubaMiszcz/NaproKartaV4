import { Component, OnInit } from '@angular/core';
import { ChartService } from '../../services/chart.service';
import { Router } from '@angular/router';
// import { MatDialog, MatDialogRef } from '@angular/material';

import { IChart, Chart } from '../../models/ichart';
// import { ErrorDialogComponent } from '../../shared/error-dialog/error-dialog.component';

@Component({
  selector: 'app-chart-add-dialog',
  templateUrl: './chart-add-dialog.component.html',
  styleUrls: ['./chart-add-dialog.component.css']
})
export class ChartAddDialogComponent implements OnInit {
  chart: IChart = new Chart();
  response: any;
  // errorDialogRef: MatDialogRef<ErrorDialogComponent>;

  constructor(private chartService: ChartService,  private router: Router) { } //private dialog: MatDialog,

  ngOnInit() {
  }

  AddChart() {
    if (this.chart.title !== null && this.chart.title !== '') {
      this.chartService.AddChart(this.chart)
        .subscribe(msg => this.response = msg, error => console.log(error), () => {
          console.log(this.response);
          alert('dodano' + this.response[0]);
          this.router.navigate(['/chart', this.response[0]]);
        });
      //todo: check other repsonse: not logged, wrong model etc
    } else {
      alert('title pusty nie dodano');
      // this.errorDialogRef = this.dialog.open(ErrorDialogComponent, {
      //   hasBackdrop: true, data: { title: 'titleeee', content: 'coontent' }
      // });
    }
  }
}
