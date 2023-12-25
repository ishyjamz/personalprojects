import { NgModule } from '@angular/core';
import { CommonModule, JsonPipe } from '@angular/common';
import { FootballerListComponent } from './footballer-list/footballer-list.component';
import { FootballerDetailComponent } from './footballer-detail/footballer-detail.component';
import { FootballerService } from '../services/footballer.service';
import { HttpClientModule } from '@angular/common/http';
import { FootballerTemplateFormComponent } from './footballer-template-form/footballer-template-form.component';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from '../home/home.component';
import { NotFoundComponent } from '../not-found/not-found.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    children: [
      { path: '', component: FootballerListComponent},
      { path: ':id', component: FootballerTemplateFormComponent},
    ]
  }
]

@NgModule({
  declarations: [
    FootballerTemplateFormComponent,
    HomeComponent,
    NotFoundComponent
  ],
  imports: [
    CommonModule,
    FootballerListComponent,
    FootballerDetailComponent,
    HttpClientModule,
    JsonPipe,
    FormsModule,
    RouterModule.forChild(routes)
  ],
  exports: [
    FootballerListComponent,
    FootballerDetailComponent,
    FootballerTemplateFormComponent
  ],
  providers: [
    FootballerService,
    JsonPipe
  ]
})
export class FootballerModule { }
