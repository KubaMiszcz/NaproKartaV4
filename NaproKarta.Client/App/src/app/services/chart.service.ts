import { IChart, Chart } from './../models/ichart';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { GlobalVariables } from '../global-variables';

const apiUrl = GlobalVariables.BASE_API_URL + '/chart';

@Injectable()
export class ChartService {

  constructor(private http: HttpClient) { }

  GetChart(id): Observable<IChart> {
    return this.http.get<IChart>(apiUrl + '/GetChart/' + id, { withCredentials: true });
  }

  AddChart(chart: IChart) {
    console.log('api:' + apiUrl + '/AddChart');
    return this.http.post(apiUrl + '/AddChart', chart, { withCredentials: true });

    //.subscribe(error => console.log(error), () => { });
  }


  // CashbackForUnfinished(rejectedUserOrders: IOrder[]) {
  //   this.http.put(this.cashbackForUnfinished, rejectedUserOrders)
  //     .subscribe(error => console.log(error), () => { });
  // }

}
