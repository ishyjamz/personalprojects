import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProfileComponent } from './profile.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ProfileCardComponent } from './components/profile-card/profile-card.component';
import { ProfileFormComponent } from './components/profile-form/profile-form.component';

@NgModule({
  imports: [
    CommonModule,
    FontAwesomeModule,
    FormsModule,
    ReactiveFormsModule
  ],
  declarations: [ProfileComponent, ProfileCardComponent, ProfileFormComponent],
})
export class ProfileModule { }
