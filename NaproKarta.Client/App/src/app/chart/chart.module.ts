import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { SharedModule } from './../shared/shared.module';

import { ChartComponent } from './chart.component';
import { ChartCycleComponent } from './chart-cycle/chart-cycle.component';
import { ChartCellComponent } from './chart-cell/chart-cell.component';
import { ChartAddDialogComponent } from './chart-add-dialog/chart-add-dialog.component';
import { ChartModifyDialogComponent } from './chart-modify-dialog/chart-modify-dialog.component';

@NgModule({
  imports: [
    CommonModule
    , SharedModule
    , RouterModule.forChild([
      { path: 'chart/:id', component: ChartComponent }
    ])
  ],
  declarations: [
    ChartComponent
    , ChartCycleComponent
    , ChartCellComponent
    , ChartAddDialogComponent
    , ChartModifyDialogComponent
  ],
  entryComponents: [
    //dialogs components only
    ChartAddDialogComponent
    , ChartModifyDialogComponent
  ]
})
export class ChartModule { }
