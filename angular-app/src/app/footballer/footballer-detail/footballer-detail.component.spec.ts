import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FootballerDetailComponent } from './footballer-detail.component';

describe('FootballerDetailComponent', () => {
  let component: FootballerDetailComponent;
  let fixture: ComponentFixture<FootballerDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FootballerDetailComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FootballerDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
