import { Injectable } from '@angular/core';
import { InMemoryDbService, RequestInfo } from 'angular-in-memory-web-api';
import { Observable } from 'rxjs';
import {Hero} from './hero';

@Injectable({
  providedIn: 'root'
})
export class InMemoryDataService implements InMemoryDbService {
  createDb(reqInfo?: RequestInfo | undefined): {} | Observable<{}> | Promise<{}> {
    const heroes = [
      { id: 12, name: 'Dr. Nice', power: 4 },
    { id: 13, name: 'Bombasto', power: 8 },
    { id: 14, name: 'Celeritas', power: 10 },
    { id: 15, name: 'Magneta', power: 10 },
    { id: 16, name: 'RubberMan', power: 1 },
    { id: 17, name: 'Dynama', power: 2 },
    { id: 18, name: 'Dr. IQ', power: 3 },
    { id: 19, name: 'Magma', power: 5 },
    { id: 20, name: 'Tornado', power: 6 }
    ];
    return {heroes};
  }

  genId(heroes: Hero[]): number {
    return heroes.length > 0 ? Math.max(...heroes.map(hero => hero.id)) + 1 : 11;
  }
}
