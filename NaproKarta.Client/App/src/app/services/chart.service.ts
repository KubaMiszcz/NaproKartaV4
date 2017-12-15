import { IChart, Chart } from './../models/ichart';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { GlobalVariables } from '../global-variables';

const applicationUrl = GlobalVariables.BASE_API_URL + '/chart';

@Injectable()
export class ChartService {

  constructor(private http: HttpClient) { }

  GetChart(id): Observable<IChart> {
    return this.http.get<IChart>(applicationUrl + '/GetChart/' + id, { withCredentials: true });
  }

  AddChart(chart: IChart) {
    return this.http.post(applicationUrl + '/AddChart', chart, { withCredentials: true });
      //.subscribe(error => console.log(error), () => { });
  }


  // CashbackForUnfinished(rejectedUserOrders: IOrder[]) {
  //   this.http.put(this.cashbackForUnfinished, rejectedUserOrders)
  //     .subscribe(error => console.log(error), () => { });
  // }

}
