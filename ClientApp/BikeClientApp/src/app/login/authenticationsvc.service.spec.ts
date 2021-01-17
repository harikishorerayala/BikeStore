import { TestBed } from '@angular/core/testing';

import { AuthenticationsvcService } from './authenticationsvc.service';

describe('AuthenticationsvcService', () => {
  let service: AuthenticationsvcService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AuthenticationsvcService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
