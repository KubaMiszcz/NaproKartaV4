import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

 const applicationUrl = 'http://localhost/NaproKarta/api/user/';
//const applicationUrl = 'http://www.naproclient.hostingasp.pl/api/user/';

@Injectable()
export class UserService {
  constructor(private http: HttpClient) { }

}
