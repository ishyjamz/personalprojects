import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { ProfileQuestion } from '../../../models/profileQuestion';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-profile-card',
  templateUrl: './profile-card.component.html',
  styleUrls: ['./profile-card.component.css'],
})
export class ProfileCardComponent implements OnInit {
  @Input() profileQuestion!: ProfileQuestion;
  public isEditMode: boolean = false;
  profileQuestionForm!: FormGroup;

  constructor(private fb: FormBuilder) {}

  ngOnInit() {
    this.profileQuestionForm = this.fb.group({
      answer: [this.profileQuestion.answer, Validators.required],
    });
  }

  toggleEditMode() {
    this.isEditMode = !this.isEditMode;
  }

  onSave(profileData: any) {
    console.log(profileData);
    this.toggleEditMode();
  }

  onCancel() {
    this.isEditMode = false;
  }

  deleteCard(){
  }
}
