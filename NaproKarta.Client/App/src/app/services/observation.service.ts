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
  AddObservation(observation: IObservation): Observable<any> {
    console.log('api:' + apiUrl + '/AddObservation:' + JSON.stringify(observation));
    return this.http.post(apiUrl + '/AddObservation', observation, { withCredentials: true });
  }

  UpdateObservation(observation: IObservation): Observable<any> {
    console.log('api:' + apiUrl + '/UpdateObservation:' + JSON.stringify(observation));
    return this.http.put(apiUrl + '/UpdateObservation', observation, { withCredentials: true });
  }

  DeleteObservation(id: number): Observable<any> {
    console.log('api:' + apiUrl + '/DeleteObservation:' + id);
    return this.http.delete(apiUrl + '/DeleteObservation/' + id, { withCredentials: true });
  }
}
