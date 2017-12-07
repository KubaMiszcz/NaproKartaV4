import { IUser } from './../../models/iuser';
import { UserService } from './../../services/user.service';
import { IChart } from './../../models/ichart';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {
  user: IUser;
  userName: string;
  str: string;
  // chartNamesList: string[];
  foods = [
    { value: 'steak-0', viewValue: 'Steak' },
    { value: 'pizza-1', viewValue: 'Pizza' },
    { value: 'tacos-2', viewValue: 'Tacos' }
  ];

  constructor(private userService: UserService) { }

  ngOnInit() {
    this.userService.GetLoggedUser()
      .subscribe(user => this.user = user, error => console.log(error), () => {
        this.userName = this.user.name;
      });


    this.userService.GetStr()
      .subscribe(str => this.str = str, error => console.log(error));

  }
}
