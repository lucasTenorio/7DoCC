import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdotadoComponent } from './adotado.component';

describe('AdotadoComponent', () => {
  let component: AdotadoComponent;
  let fixture: ComponentFixture<AdotadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdotadoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdotadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
