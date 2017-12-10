import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { IChart } from '../models/ichart';

const applicationUrl = 'http://localhost/NaproKarta/api/chart/';

@Injectable()
export class ChartService {
  constructor(private http: HttpClient) { }

  GetChartById(id): Observable<IChart> {
    return this.http.get<IChart>(applicationUrl + 'GetChartById/' + id, { withCredentials: true });
  }


}
