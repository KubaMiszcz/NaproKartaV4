import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { IUser } from '../models/iuser';

const applicationUrl = 'http://localhost:57454/api/values/';
// const applicationUrl = 'http://localhost:57454/manage/';

@Injectable()
export class UserService {
  constructor(private http: HttpClient) { }

  GetLoggedUser(): Observable<IUser> {
    return this.http.get<IUser>(applicationUrl + 'GetLoggedUser');
  }

  GetStr(): Observable<string> {
    return this.http.get<string>(applicationUrl + 'GetStr');
  }


  // GetChart(): Observable<IChart> {
  //   return this.http.get<IChart>(this.urlGetChart);
  // }
  // GetAllUserCharts(): Observable<IChart[]> {
  //   return this.http.get<IChart[]>(this.urlGetAllUserCharts);
  // }




  ////////////////

//  constructor(private http: HttpClient) { }

  // GetPendingOrders(): Observable<IPendingOrder[]> {
  //   return this.http.get<IPendingOrder[]>(this.pendingOrders);
  // }

  // ConfirmMealOrder(meal: IOrderedMealForRestaurant): void {
  //   this.http.put(this.confirmMealOrder, meal)
  //     .subscribe(error => console.log(error), () => { });
  // }

  // GetConfirmedUserOrders(): Observable<IOrder[]> {
  //   return this.http.get<IOrder[]>(this.confirmedUserOrders);
  // }

  // GetRejectedUserOrders(): Observable<IOrder[]> {
  //   return this.http.get<IOrder[]>(this.rejectedUserOrders);
  // }

  // CashbackForUnfinished(rejectedUserOrders: IOrder[]) {
  //   this.http.put(this.cashbackForUnfinished, rejectedUserOrders)
  //     .subscribe(error => console.log(error), () => { });
  // }
  // DeleteUnfinishedOrders() {
  //   console.log('333');
  //   return this.http.delete(this.deleteUnfinishedOrders)
  //   .subscribe();
  // }
}
