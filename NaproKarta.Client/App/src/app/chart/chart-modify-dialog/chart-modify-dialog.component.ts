import { Component, OnInit } from '@angular/core';
// import { MatDialogRef, MatDialog } from '@angular/material';
import { Router } from '@angular/router';
import { IChart, Chart } from './../../models/ichart';
// import { ErrorDialogComponent } from '../../shared/error-dialog/error-dialog.component';
import { ChartService } from '../../services/chart.service';

@Component({
  selector: 'app-chart-modify-dialog',
  templateUrl: './chart-modify-dialog.component.html',
  styleUrls: ['./chart-modify-dialog.component.css']
})
export class ChartModifyDialogComponent implements OnInit {
  id: number;
  chart: IChart = new Chart();
  response: any;
  // errorDialogRef: MatDialogRef<ErrorDialogComponent>;

  constructor(private chartService: ChartService, private router: Router) { }
  // private dialog: MatDialog,

  ngOnInit() {
  }

  ModifyChart() {
    if (this.chart.title !== null && this.chart.title !== '') {
      this.chartService.ModifyChart(this.chart)
        .subscribe(msg => this.response = msg, error => console.log(error), () => {
          console.log(this.response);
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

    // this.chartService.ModifyChart(this.chart)
    //   .subscribe(msg => console.log(msg)
    //   , error => console.log(error));
    // this.router.navigate(['/welcome']);
  }
}
