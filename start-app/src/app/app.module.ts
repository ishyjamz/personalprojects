import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BookingComponent } from './pages/booking/booking.component';
import { HomeComponent } from './pages/home/home.component';
import { GoogleMapsModule } from '@angular/google-maps';
import { AboutUsComponent } from './pages/about-us/about-us.component';
import { ServicesComponent } from './services/services.component';
import { BookingPageComponent } from './pages/booking-page/booking-page.component';

@NgModule({
  declarations: [
    AppComponent,
    BookingComponent,
    HomeComponent,
    AboutUsComponent,
    ServicesComponent,
    BookingPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    GoogleMapsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
