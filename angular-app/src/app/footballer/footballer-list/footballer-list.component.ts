import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-footballer-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './footballer-list.component.html',
  styleUrl: './footballer-list.component.css'
})
export class FootballerListComponen implements OnInit {
  constructor() {}

  ngOnInit(): void{

  }
}
