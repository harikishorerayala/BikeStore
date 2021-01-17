import { TestBed } from '@angular/core/testing';

import { AdminguradGuard } from './admingurad.guard';

describe('AdminguradGuard', () => {
  let guard: AdminguradGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(AdminguradGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
