import { Component, OnInit } from '@angular/core';
// import { MatDialogRef, MatDialog } from '@angular/material';
import { Router } from '@angular/router';
import { IChart, Chart } from './../../models/ichart';
// import { ErrorDialogComponent } from '../../shared/error-dialog/error-dialog.component';
import { ChartService } from '../../services/chart.service';

@Component({
  selector: 'app-chart-update-dialog',
  templateUrl: './chart-update-dialog.component.html',
  styleUrls: ['./chart-update-dialog.component.css']
})
export class ChartUpdateDialogComponent implements OnInit {
  id: number;
  chart: IChart = new Chart();
  response: any;
  // errorDialogRef: MatDialogRef<ErrorDialogComponent>;

  constructor(private chartService: ChartService, private router: Router) { }
  // private dialog: MatDialog,

  ngOnInit() {
  }

  UpdateChart() {
    if (this.chart.title !== null && this.chart.title !== '') {
      this.chartService.UpdateChart(this.chart)
        .subscribe(msg => this.response = msg
        , error => console.log(error)
        , () => {
          console.log('resp ' + this.response);
          alert('zmieniono' + this.response[0]);
          this.router.navigate(['/chart', this.response[0]]);
        });
      //todo: check other repsonse: not logged, wrong model etc
    } else {
      alert('title pusty nie zmieniono');
      // this.errorDialogRef = this.dialog.open(ErrorDialogComponent, {
      //   hasBackdrop: true, data: { title: 'titleeee', content: 'coontent' }
      // });
    }
  }


  aaa() {
    // this.chart.id = this.currentChartId;
    // this.chart.title = this.chartTitle;
    // this.chart.note = this.chartNote;
    // this.chart.cycles = this.cycles;

    // this.chartService.UpdateChart(this.chart)
    //   .subscribe(msg => console.log(msg)
    //   , error => console.log(error));
    // this.router.navigate(['/welcome']);
  }
}
