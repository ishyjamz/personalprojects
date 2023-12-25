import { AfterViewInit, Component, ElementRef, OnInit, Renderer2, ViewChild, ViewChildren } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Footballer } from '../../models/footballer';
import { FootballerDetailComponent } from '../footballer-detail/footballer-detail.component';
import { FootballerService } from '../../_services/footballer.service';
import { HttpClient, HttpClientModule, HttpHandler } from '@angular/common/http';
import { HighlighttextDirective } from '../../_directives/highlighttext.directive';

@Component({
  selector: 'app-footballer-list',
  standalone: true,
  imports: [CommonModule, FootballerDetailComponent, HttpClientModule],
  providers: [FootballerService],
  templateUrl: './footballer-list.component.html',
  styleUrl: './footballer-list.component.css'
})

export class FootballerListComponent implements OnInit, AfterViewInit {

  footballers!: Footballer[];
  @ViewChildren('footballerRef') footballerRef!: ElementRef;
  @ViewChild('footballerUl') footballerUl!: ElementRef;

  constructor(private footballerService: FootballerService, private renderer: Renderer2) {

  }

  ngAfterViewInit(): void {
    console.log(this.footballerRef);
    console.log(this.footballerUl)
    const div = this.renderer.createElement('div');
    const text = this.renderer.createText('Meow fakhi');
    this.renderer.appendChild(div, text);
    this.renderer.appendChild(this.footballerUl.nativeElement, div);
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

