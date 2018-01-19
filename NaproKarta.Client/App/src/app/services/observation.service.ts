import { IObservation } from './../models/iobservation';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { GlobalVariables } from '../global-variables';

const apiUrl = GlobalVariables.BASE_API_URL + '/observation';

@Injectable()
export class ObservationService {

  public storage: IObservation;

  constructor(private http: HttpClient) { }

  GetObservation(id): Observable<IObservation> {
    return this.http.get<IObservation>(apiUrl + '/GetObservation/' + id, { withCredentials: true });
  }

  UpdateObservation(observation: IObservation): Observable<any> {
    console.log('api:' + apiUrl + '/UpdateObservation:' + observation);
    return this.http.put(apiUrl + '/UpdateObservation', observation, { withCredentials: true });
  }

  // AddChart(chart: IChart): Observable<any> {
  //   //console.log('api:' + apiUrl + '/AddChart');
  //   return this.http.post(apiUrl + '/AddChart', chart, { withCredentials: true });
  // }

  // DeleteChart(id: number): Observable<any> {
  //   console.log('api:' + apiUrl + '/DeleteChart/' + id);
  //   return this.http.delete(apiUrl + '/DeleteChart/' + id, { withCredentials: true });
  // }

  // UpdateChart(chart: IChart): Observable<any> {
  //   console.log('api:' + apiUrl + '/UpdateChart:' + chart);
  //   return this.http.put(apiUrl + '/UpdateChart', chart, { withCredentials: true });
  // }

  // CashbackForUnfinished(rejectedUserOrders: IOrder[]) {
  //   this.http.put(this.cashbackForUnfinished, rejectedUserOrders)
  //     .subscribe(error => console.log(error), () => { });
  // }

}
