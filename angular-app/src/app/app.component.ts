import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { FootballerModule } from './footballer/footballer.module';

interface Footballer {
  id: number;
  name: string;
  goals: number;
  assists: number;
  team: string;
  isGoat: boolean;
}

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, FormsModule, FootballerModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
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

  constructor() {
  }

  handleClick(footballer : Footballer){
    this.footballers.push({
      id : footballer.id,
      name : footballer.name,
      goals : footballer.goals,
      assists : footballer.assists,
      team : footballer.team,
      isGoat : footballer.isGoat
    });
  };
}
