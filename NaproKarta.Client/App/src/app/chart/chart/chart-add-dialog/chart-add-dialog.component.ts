import { Component, OnInit } from '@angular/core';
import { IChart, Chart } from '../../../models/ichart';
import { ChartService } from '../../../services/chart.service';
import { MatDialog, MatDialogRef } from '@angular/material';
import { ErrorDialogComponent } from '../../../shared/error-dialog/error-dialog.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-chart-add-dialog',
  templateUrl: './chart-add-dialog.component.html',
  styleUrls: ['./chart-add-dialog.component.css']
})
export class ChartAddDialogComponent implements OnInit {
  chartToAdd: IChart = new Chart();
  response: any;
  errorDialogRef: MatDialogRef<ErrorDialogComponent>;

  constructor(private chartService: ChartService, private dialog: MatDialog, private router: Router) { }

  ngOnInit() {
    this.chartToAdd.title = 'karta nr ...';
    this.chartToAdd.title = '';
  }


  AddChart() {
    if (this.chartToAdd.title !== null && this.chartToAdd.title !== '') {
      this.chartService.AddChart(this.chartToAdd)
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


    // [routerLink]="[ '/chart',chartIdAndTitle.id]"
    //return this.response;

  }
}
