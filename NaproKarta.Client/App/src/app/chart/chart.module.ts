import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { MaterialsModule } from './../materials/materials.module';

import { ChartComponent } from './chart.component';
import { ChartCycleComponent } from './chart-cycle/chart-cycle.component';
import { ChartCellComponent } from './chart-cell/chart-cell.component';
import { ChartAddDialogComponent } from './chart-add-dialog/chart-add-dialog.component';
import { ChartModifyDialogComponent } from './chart-modify-dialog/chart-modify-dialog.component';


@NgModule({
  imports: [
    CommonModule
    , FormsModule
    , RouterModule.forChild([
      { path: 'chart/:id', component: ChartComponent }
    ])
    , MaterialsModule
  ],
  declarations: [
    ChartComponent
    , ChartAddDialogComponent
    , ChartModifyDialogComponent
    , ChartCycleComponent
    , ChartCellComponent
  ],
  entryComponents: [
    //dialogs components only
    ChartAddDialogComponent
    , ChartModifyDialogComponent
  ]
})
export class ChartModule { }
