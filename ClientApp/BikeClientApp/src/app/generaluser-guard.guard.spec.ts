import { TestBed } from '@angular/core/testing';

import { GeneraluserGuardGuard } from './generaluser-guard.guard';

describe('GeneraluserGuardGuard', () => {
  let guard: GeneraluserGuardGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(GeneraluserGuardGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
