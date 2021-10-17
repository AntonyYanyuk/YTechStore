import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowSmartComponent } from './show-smart.component';

describe('ShowSmartComponent', () => {
  let component: ShowSmartComponent;
  let fixture: ComponentFixture<ShowSmartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowSmartComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowSmartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
