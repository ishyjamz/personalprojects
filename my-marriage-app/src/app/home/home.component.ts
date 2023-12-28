import { Component, OnInit } from '@angular/core';
import { Page } from '../models/page';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  links: Page[] = [
    {
      title: 'My Profile',
      path: '/my-profile',
      description: 'Click here to find out more about me'
    },
    {
      title: 'Compatibility Game',
      path: '/compatibility-game',
      description: 'Find out how compatible we are with this fun and interactive game'
    },
    {
      title: 'Application Form',
      path: '/application-form',
      description: 'Seen enough already? Head on over to the application section'
    }
  ]
  constructor() { }

  ngOnInit() {
  }

}
