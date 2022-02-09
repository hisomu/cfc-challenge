import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListComponent } from './component/list/list.component';
import { MaterialModule } from '../shared';


@NgModule({
  declarations: [
    ListComponent
  ],
  imports: [
    CommonModule,
    MaterialModule
  ]
})
export class ListModule { }
