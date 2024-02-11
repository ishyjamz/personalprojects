import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApplicationFormComponent } from './application-form.component';
import { FormComponent } from './form/form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { UploadFileComponent } from './upload-file/upload-file.component';
import { FormButtonComponent } from './form-button/form-button.component';
import { TextComponent } from './text/text.component';
import { ProfileCardComponent } from '../profile/components/profile-card/profile-card.component';

@NgModule({
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  declarations: [
    ApplicationFormComponent,
    FormComponent,
    UploadFileComponent,
    FormButtonComponent,
    TextComponent,
  ],
})
export class ApplicationFormModule {}
