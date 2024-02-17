import { Component, Input, OnInit, EventEmitter, Output } from '@angular/core';
import { ProfileQuestion } from '../../../models/profileQuestion';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';

@Component({
  selector: 'app-profile-form',
  templateUrl: './profile-form.component.html',
  styleUrls: ['./profile-form.component.css'],
})
export class ProfileFormComponent implements OnInit {
  @Input() profileQuestion!: ProfileQuestion;
  @Input() form!: FormGroup;
  @Output() save = new EventEmitter<ProfileQuestion>();
  @Output() cancel = new EventEmitter<void>();
  profileQuestionForm!: FormGroup;

  constructor(private fb: FormBuilder) {}

  ngOnInit() {
    this.profileQuestionForm = this.fb.group({
      id: [this.profileQuestion.id],
      question: [this.profileQuestion.question, Validators.required],
      answer: [this.profileQuestion.answer, Validators.required],
    });
  }

  onSave() {
    this.profileQuestion = this.profileQuestionForm.value;
    this.save.emit(this.profileQuestion);
    console.log(this.profileQuestion);
  }
}
