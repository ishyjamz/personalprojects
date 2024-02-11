import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterOutlet } from '@angular/router';
import { HomeModule } from './home/home.module';
import { ProfileModule } from './profile/profile.module';
import { NavbarComponent } from './components/navbar/navbar.component';
import { ApplicationFormModule } from './application-form/application-form.module';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, HomeModule, ProfileModule, RouterLink, NavbarComponent, ApplicationFormModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'my-marriage-app';
}
