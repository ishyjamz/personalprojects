import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApplicationFormComponent } from './application-form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
    declarations: [ApplicationFormComponent],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule
    ],
    exports: [
    ]
})
export class ApplicationFormModule { }
