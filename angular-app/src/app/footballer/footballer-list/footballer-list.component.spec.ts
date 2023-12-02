import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FootballerListComponent } from './footballer-list.component';

describe('FootballerListComponent', () => {
  let component: FootballerListComponent;
  let fixture: ComponentFixture<FootballerListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FootballerListComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FootballerListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
