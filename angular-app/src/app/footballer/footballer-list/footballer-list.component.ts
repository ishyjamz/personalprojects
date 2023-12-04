import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Footballer } from '../../models/footballer';
import { FootballerDetailComponent } from '../footballer-detail/footballer-detail.component';

@Component({
  selector: 'app-footballer-list',
  standalone: true,
  imports: [CommonModule, FootballerDetailComponent],
  templateUrl: './footballer-list.component.html',
  styleUrl: './footballer-list.component.css'
})

export class FootballerListComponent implements OnInit {

  footballers: Footballer[] = [{
    id: 1,
    name: 'David Beckham',
    goals: 123,
    assists: 320,
    team: 'Manchester United',
    isGoat: true
  },
  {
    id: 2,
    name: 'Cristiano Ronaldo',
    goals: 820,
    assists: 320,
    team: 'Real Madrid',
    isGoat: false
  },
  {
    id: 3,
    name: 'Roberto Carlos',
    goals: 83,
    assists: 220,
    team: 'Brazil',
    isGoat: true
  },
  {
    id: 4,
    name: 'Mario Mandzukic',
    goals: 357,
    assists: 124,
    team: 'Bayern Munich',
    isGoat: false
  },
]

  constructor() {}

  ngOnInit(): void{}

  handleRemove(event: Footballer){
    console.log('Remove event received', event);
    this.footballers = this.footballers
    .filter(footballer => footballer.id !== event.id);
  }
}

