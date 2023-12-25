import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Footballer } from '../../models/footballer';
import { FootballerDetailComponent } from '../footballer-detail/footballer-detail.component';
import { FootballerService } from '../../services/footballer.service';
import { HttpClient, HttpClientModule, HttpHandler } from '@angular/common/http';

@Component({
  selector: 'app-footballer-list',
  standalone: true,
  imports: [CommonModule, FootballerDetailComponent, HttpClientModule],
  providers: [FootballerService],
  templateUrl: './footballer-list.component.html',
  styleUrl: './footballer-list.component.css'
})

export class FootballerListComponent implements OnInit {
  footballers!: Footballer[];

  constructor(private footballerService: FootballerService) {

  }

  ngOnInit(): void{
    this.footballerService.getFootballers().subscribe((data: Footballer[]) => {
      console.log(data);
      this.footballers = data;
    });
  }

  handleRemove(event: Footballer){
    console.log('Remove event received', event);
    this.footballers = this.footballers
    .filter(footballer => footballer.id !== event.id);
  }
}

