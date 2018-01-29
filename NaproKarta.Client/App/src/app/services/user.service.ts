import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { GlobalVariables } from '../global-variables';

const applicationUrl = GlobalVariables.BASE_URL_API + '/user';

@Injectable()
export class UserService {
  constructor(private http: HttpClient) { }

}
