import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css'],
})
export class FormComponent implements OnInit {
  applicationForm!: FormGroup;

  constructor(private fb: FormBuilder) {}

  ngOnInit() {
    this.applicationForm = this.fb.group({
      forename: ['', Validators.required],
      surname: ['', Validators.required],
      city: ['', Validators.required],
      height: ['', Validators.required],
      occupation: ['', Validators.required],
      educationLevel: ['', Validators.required],
      waliName: ['', Validators.required],
      waliRelationship: ['', Validators.required],
      waliNumber: ['', Validators.required],
      personalStatement: ['', Validators.required],
    });
  }

  onSubmit() {}
}
