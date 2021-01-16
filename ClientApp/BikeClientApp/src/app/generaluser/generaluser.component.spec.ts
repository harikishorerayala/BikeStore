import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GeneraluserComponent } from './generaluser.component';

describe('GeneraluserComponent', () => {
  let component: GeneraluserComponent;
  let fixture: ComponentFixture<GeneraluserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GeneraluserComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GeneraluserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
