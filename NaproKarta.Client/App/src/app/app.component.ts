import { Component } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'NaproKarta v2.0';
  // userCharts

  // wywal potem
  // label = 'ok';
  // isChecked = true;
  // side = 'after';

  onChartChanged(id: number) {
//    console.log('clicked' + id);
  }

}
