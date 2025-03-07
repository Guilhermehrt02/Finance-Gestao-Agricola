import { HTTP_INTERCEPTORS, HttpContextToken } from '@angular/common/http';
import { AuthenticationInterceptor } from './authentication/authentication.interceptor';

export const interceptorsProviders = [
  {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthenticationInterceptor,
    multi: true,
  },
];

export const BYPASS_INTERCEPTORS = new HttpContextToken<boolean>(() => false);
