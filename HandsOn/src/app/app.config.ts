import { ApplicationConfig, importProvidersFrom } from '@angular/core';
import { provideAnimations } from '@angular/platform-browser/animations';
import { provideRouter } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { appRoutes } from './app.routes';
import { providePrimeNG } from 'primeng/config';
import { JwtHelperService, JWT_OPTIONS } from '@auth0/angular-jwt';
import { environments } from './environments/environments';
import { ConfirmationService, MessageService } from 'primeng/api';
import { provideTranslateService } from '@ngx-translate/core';
import { translations } from './translations';
import { interceptorsProviders } from '../../lib/core/interceptors';

export const appConfig: ApplicationConfig = {
  providers: [
    provideAnimations(),
    provideRouter(appRoutes),
    importProvidersFrom(HttpClientModule),
    interceptorsProviders,
    {
      provide: 'LOCALSTORAGE',
      useValue: window.localStorage,
    },
    providePrimeNG({
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
  ],
};

export function jwtOptionsFactory() {
  return {
    tokenGetter: () => {
      return environments.jwtToken;
    },
    allowedDomains: [environments.jwtDomain],
  };
}
