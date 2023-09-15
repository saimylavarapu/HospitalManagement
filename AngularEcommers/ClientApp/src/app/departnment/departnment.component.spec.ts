import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartnmentComponent } from './departnment.component';

describe('DepartnmentComponent', () => {
  let component: DepartnmentComponent;
  let fixture: ComponentFixture<DepartnmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DepartnmentComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DepartnmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
