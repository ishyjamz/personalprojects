/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { FootballerService } from './footballer.service';

describe('Service: Footballer', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [FootballerService]
    });
  });

  it('should ...', inject([FootballerService], (service: FootballerService) => {
    expect(service).toBeTruthy();
  }));
});
