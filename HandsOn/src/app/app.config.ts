import {
  ApplicationConfig,
  importProvidersFrom,
  provideZoneChangeDetection,
} from '@angular/core';
import { provideAnimations } from '@angular/platform-browser/animations';
import { provideRouter } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { appRoutes } from './app.routes';
import { providePrimeNG } from 'primeng/config';
import { JwtHelperService, JWT_OPTIONS } from '@auth0/angular-jwt';
import { ConfirmationService, MessageService } from 'primeng/api';
import { provideTranslateService } from '@ngx-translate/core';
import { translations } from './translations';
import { interceptorsProviders } from '@farm/core';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import Aura from '@primeng/themes/aura';
import { TooltipModule } from 'primeng/tooltip';
import { APP_CONFIG } from './environments/app-config.token';
import { environment } from './environments/environment';

export const appConfig: ApplicationConfig = {
  providers: [
    { provide: APP_CONFIG, useValue: environment },
    provideAnimations(),
    provideAnimationsAsync(),
    provideRouter(appRoutes),
    importProvidersFrom(HttpClientModule),
    interceptorsProviders,
    {
      provide: 'LOCALSTORAGE',
      useValue: window.localStorage,
    },
    providePrimeNG({
      theme: {
        preset: Aura,
        options: {
          darkModeSelector: '.farm-dark',
        },
      },
      translation: translations.pt,
    }),
    JwtHelperService,
    {
      provide: JWT_OPTIONS,
      useFactory: jwtOptionsFactory,
    },
    MessageService,
    ConfirmationService,
    provideTranslateService({
      defaultLanguage: 'pt',
      useDefaultLang: true,
    }),
    provideZoneChangeDetection({ eventCoalescing: true }),
    TooltipModule,
  ],
};

export function jwtOptionsFactory() {
  return {
    tokenGetter: () => {
      return 'uNNtAoquY3kUMt1BsvLcUqf51rovyv2e';
    },
    allowedDomains: ['http://localhost:5143'],
  };
}
