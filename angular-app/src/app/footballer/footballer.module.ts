import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FootballerListComponent } from './footballer-list/footballer-list.component';
import { FootballerDetailComponent } from './footballer-detail/footballer-detail.component';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    FootballerListComponent,
    FootballerDetailComponent
  ],
  exports: [
    FootballerListComponent,
    FootballerDetailComponent
  ]
})
export class FootballerModule { }
