import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { BookNowComponent } from './book-now/book-now.component';

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'book-now', component: BookNowComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { 
}
