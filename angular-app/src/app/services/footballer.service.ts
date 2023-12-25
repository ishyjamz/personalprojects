import { Injectable } from '@angular/core';
import { Footballer } from '../models/footballer';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

const FOOTBALLER_API = 'http://localhost:3000/footballer'

@Injectable({
  providedIn: 'root'
})
export class FootballerService {

  constructor(private http: HttpClient) {
    console.log(this.http);
   }

   getFootballer(id: number){
    return this.http.get<Footballer>(`${FOOTBALLER_API}/1`)
   }

  getFootballers(): Observable<Footballer[]> {
    return this.http.get<Footballer[]>(FOOTBALLER_API);
  }

}
