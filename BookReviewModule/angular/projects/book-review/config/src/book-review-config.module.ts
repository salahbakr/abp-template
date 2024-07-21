import { ModuleWithProviders, NgModule } from '@angular/core';
import { BOOK_REVIEW_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class BookReviewConfigModule {
  static forRoot(): ModuleWithProviders<BookReviewConfigModule> {
    return {
      ngModule: BookReviewConfigModule,
      providers: [BOOK_REVIEW_ROUTE_PROVIDERS],
    };
  }
}
