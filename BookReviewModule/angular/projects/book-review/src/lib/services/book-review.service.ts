import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class BookReviewService {
  apiName = 'BookReview';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/BookReview/sample' },
      { apiName: this.apiName }
    );
  }
}
