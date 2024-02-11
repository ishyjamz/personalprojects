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
  // @Output() save = new EventEmitter<any>();
  // @Output() cancel = new EventEmitter<void>();
  constructor() {}

  ngOnInit() {

  }
}
