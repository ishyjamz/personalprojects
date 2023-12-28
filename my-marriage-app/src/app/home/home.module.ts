import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { CardComponent } from './card/card.component';
import { RouterLink } from '@angular/router';

@NgModule({
  imports: [
    CommonModule,
    CardComponent,
    RouterLink
  ],
  declarations: [HomeComponent]
})
export class HomeModule { }
