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

  AddChart(chart: IChart): Observable<any> {
    //console.log('api:' + apiUrl + '/AddChart');
    return this.http.post(apiUrl + '/AddChart', chart, { withCredentials: true });
  }

  DeleteChart(id: number): Observable<any> {
    console.log('api:' + apiUrl + '/DeleteChart/' + id);
    return this.http.delete(apiUrl + '/DeleteChart/' + id, { withCredentials: true });
  }

  UpdateChart(chart: IChart): Observable<any> {
    console.log('api:' + apiUrl + '/UpdateChart:' + chart);
    return this.http.put(apiUrl + '/UpdateChart', chart, { withCredentials: true });
  }

  // CashbackForUnfinished(rejectedUserOrders: IOrder[]) {
  //   this.http.put(this.cashbackForUnfinished, rejectedUserOrders)
  //     .subscribe(error => console.log(error), () => { });
  // }

}
