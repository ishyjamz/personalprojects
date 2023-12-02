import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BookingComponent } from './pages/booking/booking.component';
import { HomeComponent } from './pages/home/home.component';
import { ServicesComponent } from './services/services.component';
import { AboutUsComponent } from './pages/about-us/about-us.component';
import { BookingPageComponent } from './pages/booking-page/booking-page.component';

const routes: Routes = [
  {path: '', redirectTo: '/home', pathMatch: 'full'},
  {path: 'home', component: HomeComponent},
  {path: 'about-us', component: AboutUsComponent},
  {path: 'booking', component: BookingComponent},
  {path: 'services', component: ServicesComponent},
  {path: 'booking-page', component: BookingPageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
