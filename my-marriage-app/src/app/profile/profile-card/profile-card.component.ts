import { Component, OnInit, Input } from '@angular/core';
import { ProfileQuestion } from '../../models/profileQuestion';

@Component({
  selector: 'app-profile-card',
  templateUrl: './profile-card.component.html',
  styleUrls: ['./profile-card.component.css'],
})
export class ProfileCardComponent implements OnInit {
  @Input() profileQuestion!: ProfileQuestion;

  constructor() {}

  ngOnInit() {}
}
