import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FootballerListComponent } from './footballer-list/footballer-list.component';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    FootballerListComponent
  ],
  exports: [
    FootballerListComponent,
  ]
})
export class FootballerModule { }
