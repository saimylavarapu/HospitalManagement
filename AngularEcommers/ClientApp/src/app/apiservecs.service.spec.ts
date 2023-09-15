import { TestBed } from '@angular/core/testing';

import { ApiservecsService } from './apiservecs.service';

describe('ApiservecsService', () => {
  let service: ApiservecsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ApiservecsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
