import { BrowserModule } from '@angular/platform-browser';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { AppComponent } from './app.component';
import { AdminModule } from './admin-module/admin.module';
import { SharedModule } from './shared-module/shared.module';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { SpinerInterceptorService } from './interceptors/spiner-interceptor.service';
import { EffectsModule } from '@ngrx/effects';
import { CategoriesService } from './services/categories.service';
import { get_settings } from './shared-module/shared-reducer-selector';
import { Store } from '@ngrx/store';
import { CategoryPipe } from './shared-module/pipes/category.pipe';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    AdminModule,
    SharedModule,
    EffectsModule.forFeature([])
  ],
  exports: [

  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: SpinerInterceptorService,
      multi: true,
    },
    {
      provide: APP_INITIALIZER,
      useFactory: get_settings,
      deps: [Store],
      multi: true
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
