import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApplicationFormComponent } from './application-form.component';
import { FormComponent } from './form/form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

@NgModule({
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  declarations: [ApplicationFormComponent, FormComponent],
})
export class ApplicationFormModule {}
