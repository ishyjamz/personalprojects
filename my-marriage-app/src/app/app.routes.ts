import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ProfileComponent } from './profile/profile.component';
import { CompatibilityGameComponent } from './compatibility-game/compatibility-game.component';
import { ApplicationFormComponent } from './application-form/application-form.component';

export const routes: Routes = [
    { path: "", component: HomeComponent, pathMatch: 'full' },
    { path: "my-profile", component: ProfileComponent, pathMatch: 'full'},
    { path: "compatibility-game", component: CompatibilityGameComponent},
    { path: "application-form", component: ApplicationFormComponent},
];
