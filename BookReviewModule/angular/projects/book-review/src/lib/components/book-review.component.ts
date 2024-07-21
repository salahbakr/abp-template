import { Component, OnInit } from '@angular/core';
import { BookReviewService } from '../services/book-review.service';

@Component({
  selector: 'lib-book-review',
  template: ` <p>book-review works!</p> `,
  styles: [],
})
export class BookReviewComponent implements OnInit {
  constructor(private service: BookReviewService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
