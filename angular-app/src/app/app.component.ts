import { Component } from '@angular/core';
import { Router, RouterLink, RouterOutlet, provideRouter } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { FootballerListComponent } from './footballer/footballer-list/footballer-list.component';
import { FootballerDetailComponent } from './footballer/footballer-detail/footballer-detail.component';
import { FootballerModule } from "./footballer/footballer.module";

interface Nav {
    link: string,
    name: string,
    exact: boolean
}

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterLink, CommonModule, RouterOutlet, FormsModule, FootballerListComponent, FootballerDetailComponent, FootballerModule]
})
export class AppComponent {
    nav: Nav[] = [
        {
            link: '/',
            name: 'Home',
            exact: true
        },
        {
            link:'/badroute',
            name:'Bad Route',
            exact: true
        }
    ]
}
