import { Component, Input, OnInit } from '@angular/core';
import { Page } from '../../models/page';
import { Router, RouterLink } from '@angular/router';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css'],
  standalone: true
})
export class CardComponent implements OnInit {

  @Input() link!: Page;

  constructor(private router: Router) { }

  ngOnInit() {
  }

  goToLinkPage(link: string) : void {
    this.router.navigate([link]);
  }

}
