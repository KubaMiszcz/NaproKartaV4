import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { GlobalVariables } from '../shared/global-variables';

const applicationUrl = GlobalVariables.BASE_API_URL + '/user';

@Injectable()
export class UserService {
  constructor(private http: HttpClient) { }

}
