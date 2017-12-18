import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-progress-spinner-overview',
  templateUrl: './progress-spinner-overview.component.html',
  styleUrls: ['./progress-spinner-overview.component.css']
})
export class ProgressSpinnerOverviewComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}


// import { SpinnerService } from '../../services/spinner.service';

// export class ProgressSpinnerOverviewComponent implements OnInit {

//   visible: boolean = false;

//   constructor(private spinnerService: SpinnerService) { }

//   ngOnInit() {
//     this.spinnerService._register(this);
//   }

//   showSpiner(): void {
//     this.visible = true;
//   }

//   hideSpiner(): void {
//     this.visible = false;
//   }
// }
