import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SealseBillComponent } from './sealse-bill.component';

describe('SealseBillComponent', () => {
  let component: SealseBillComponent;
  let fixture: ComponentFixture<SealseBillComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SealseBillComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SealseBillComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
