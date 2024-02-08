import { Component, OnInit } from '@angular/core';
import { ProfileQuestion } from '../models/profileQuestion';
import { faEdit } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  faEdit = faEdit;
  isEditMode: boolean = false;
  pageTitle: string = "Hello";

  constructor() { }

  ngOnInit() {
  }

  profileQuestions: ProfileQuestion[] = [
    {
      id: 1,
      question: "Educational Background",
      answer: "I have recently completed a BEng in Chemical Engineering"
    },
    {
      id: 2,
      question: "Occupation and Future Aspirations",
      answer: "I am software engineer and want to be an astronaut"
    },
    {
      id: 3,
      question: "Hobbies/Interests",
      answer: "Badminton and gym"
    },
    {
      id: 4,
      question: "Personality",
      answer: "Bubbly character who is sincere and trustworthy"
    },
    {
      id: 5,
      question: "Looking for...",
      answer: "Practising Muslim with good manners and a soft heart"
    }
  ]

  switchToEditMode(){
    this.isEditMode = true;
    console.log(this.isEditMode);
    this.pageTitle = "meow" + this.pageTitle;
  }

}
