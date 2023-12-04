import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Footballer } from '../../models/footballer';
import { FootballerListComponent } from '../footballer-list/footballer-list.component';

@Component({
  selector: 'app-footballer-detail',
  standalone: true,
  host: {ngSkipHydration: 'true'},
  imports: [CommonModule, FootballerListComponent],
  templateUrl: './footballer-detail.component.html',
  styleUrl: './footballer-detail.component.css'
})
export class FootballerDetailComponent implements OnInit {
  @Input() detail!: Footballer;

  @Output() remove: EventEmitter<any> = new EventEmitter();

  constructor(){}

  ngOnInit(): void {}

  onRemove(){
    console.log(this.detail);
    this.remove.emit(this.detail);
  }
}
