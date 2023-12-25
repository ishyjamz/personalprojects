import { Component, OnInit } from '@angular/core';
import { FootballerService } from '../../services/footballer.service';
import { Footballer } from '../../models/footballer';
import { FootballerType } from '../../models/footballer-type';
import { ActivatedRoute, Params, Router } from '@angular/router';

@Component({
  selector: 'app-footballer-template-form',
  templateUrl: './footballer-template-form.component.html',
  styleUrls: ['./footballer-template-form.component.css'],
})
export class FootballerTemplateFormComponent implements OnInit {

  constructor(private footballerService: FootballerService, 
    private router: Router, private activeRoute: ActivatedRoute) { }

  footballer! : Footballer;
  footballerType: FootballerType[] = [
    {
      key: 0,
      value: 'Playmaker'
    },
    {
      key: 1,
      value: 'Box to Box'
    },
    {
      key: 2,
      value: 'Poacher'
    },
    {
      key: 3,
      value: 'Stopper'
    },
    {
      key: 4,
      value: 'Dribbler'
    },
  ]

  ngOnInit() {
    this.activeRoute.params.subscribe((data: Params) => {
      this.footballerService.getFootballer(1).subscribe((data: Footballer) => {
        this.footballer = data;
      });
    })
  }

  back(): void {
    this.router.navigate(['/footballer']);
  }

  handleSubmit(object: any){
    console.log(object);
  }
  toggleIsGoat(object: any){
    console.log(object);
  }

}
