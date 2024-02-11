import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-form-button',
  templateUrl: './form-button.component.html',
  styleUrls: ['./form-button.component.css'],
})
export class FormButtonComponent implements OnInit {
  constructor(private router: Router) {}

  ngOnInit() {}

  goToForm() {
    this.router.navigateByUrl('form');
  }
}
