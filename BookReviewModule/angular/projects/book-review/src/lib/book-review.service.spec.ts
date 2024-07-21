import { TestBed } from '@angular/core/testing';
import { BookReviewService } from './services/book-review.service';
import { RestService } from '@abp/ng.core';

describe('BookReviewService', () => {
  let service: BookReviewService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(BookReviewService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
