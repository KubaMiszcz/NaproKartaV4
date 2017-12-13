import { IChart, Chart } from './../models/ichart';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

 const applicationUrl = 'http://localhost/NaproKarta/api/chart/';
//const applicationUrl = 'http://www.naproclient.hostingasp.pl/api/chart/';


@Injectable()
export class ChartService {

  constructor(private http: HttpClient) { }

  GetChartById(id): Observable<IChart> {
    return this.http.get<IChart>(applicationUrl + 'GetChartById/' + id, { withCredentials: true });
  }

  AddNewChart(chartToAdd: Chart) {
    return this.http.post(applicationUrl + 'AddNewChart', chartToAdd, { withCredentials: true })
      .subscribe(error => console.log(error), () => {});
  }


  // CashbackForUnfinished(rejectedUserOrders: IOrder[]) {
  //   this.http.put(this.cashbackForUnfinished, rejectedUserOrders)
  //     .subscribe(error => console.log(error), () => { });
  // }

}
