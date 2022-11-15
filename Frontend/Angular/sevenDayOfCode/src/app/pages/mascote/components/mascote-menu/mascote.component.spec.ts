import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MascoteComponent } from './mascote.component';

describe('MascoteComponent', () => {
  let component: MascoteComponent;
  let fixture: ComponentFixture<MascoteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MascoteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MascoteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
