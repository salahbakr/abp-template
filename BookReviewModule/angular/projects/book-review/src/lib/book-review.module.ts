import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { BookReviewComponent } from './components/book-review.component';
import { BookReviewRoutingModule } from './book-review-routing.module';

@NgModule({
  declarations: [BookReviewComponent],
  imports: [CoreModule, ThemeSharedModule, BookReviewRoutingModule],
  exports: [BookReviewComponent],
})
export class BookReviewModule {
  static forChild(): ModuleWithProviders<BookReviewModule> {
    return {
      ngModule: BookReviewModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<BookReviewModule> {
    return new LazyModuleFactory(BookReviewModule.forChild());
  }
}
