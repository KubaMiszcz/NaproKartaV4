import { Component, OnInit } from '@angular/core';
import { IChart, Chart } from '../../models/ichart';
import { ChartService } from '../../services/chart.service';
import { MatDialog, MatDialogRef } from '@angular/material';
import { ErrorDialogComponent } from '../../shared/error-dialog/error-dialog.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-chart-add-dialog',
  templateUrl: './chart-add-dialog.component.html',
  styleUrls: ['./chart-add-dialog.component.css']
})
export class ChartAddDialogComponent implements OnInit {
  chart: IChart = new Chart();
  response: any;
  errorDialogRef: MatDialogRef<ErrorDialogComponent>;

  constructor(private chartService: ChartService, private dialog: MatDialog, private router: Router) { }

  ngOnInit() {
    // this.chart.title = 'karta nr ...';
    // this.chart.title = '';
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
