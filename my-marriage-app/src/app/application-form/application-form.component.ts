import { Component, OnInit } from '@angular/core';
import { User } from '../models/user';

@Component({
  selector: 'app-application-form',
  templateUrl: './application-form.component.html',
  styleUrls: ['./application-form.component.css'],
})
export class ApplicationFormComponent implements OnInit {

  user!: User;

  constructor() { }

  ngOnInit() {
  }

  handleSubmit(){
    
  }

}
