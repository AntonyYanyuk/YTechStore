import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditSmartComponent } from './add-edit-smart.component';

describe('AddEditSmartComponent', () => {
  let component: AddEditSmartComponent;
  let fixture: ComponentFixture<AddEditSmartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEditSmartComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditSmartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
