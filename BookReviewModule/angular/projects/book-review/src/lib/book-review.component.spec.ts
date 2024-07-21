import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { BookReviewComponent } from './components/book-review.component';
import { BookReviewService } from '@book-review';
import { of } from 'rxjs';

describe('BookReviewComponent', () => {
  let component: BookReviewComponent;
  let fixture: ComponentFixture<BookReviewComponent>;
  const mockBookReviewService = jasmine.createSpyObj('BookReviewService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [BookReviewComponent],
      providers: [
        {
          provide: BookReviewService,
          useValue: mockBookReviewService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BookReviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
