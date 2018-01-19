import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { SharedModule } from './../shared/shared.module';

import { ChartComponent } from './chart.component';
import { ChartCycleComponent } from './chart-cycle/chart-cycle.component';
import { ChartCellComponent } from './chart-cell/chart-cell.component';
import { ChartAddDialogComponent } from './chart-add-dialog/chart-add-dialog.component';
import { ChartUpdateDialogComponent } from './chart-update-dialog/chart-update-dialog.component';

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
    , ChartUpdateDialogComponent
  ],
  entryComponents: [
    //dialogs components only
    ChartAddDialogComponent
    , ChartUpdateDialogComponent
  ]
})
export class ChartModule { }
