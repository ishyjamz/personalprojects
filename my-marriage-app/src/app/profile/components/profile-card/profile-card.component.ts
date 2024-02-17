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
  @Input() isCardEditMode: boolean = false;

  constructor() {}

  ngOnInit() {
    this.isEditMode = this.isCardEditMode;
  }

  toggleEditMode() {
    this.isEditMode = !this.isEditMode;
  }

  getProfileQuestion(profileQuestion: ProfileQuestion) {
    this.profileQuestion = profileQuestion;
    this.toggleEditMode();
  }

  onCancel() {
    this.isEditMode = false;
  }

  deleteCard() {}
}
