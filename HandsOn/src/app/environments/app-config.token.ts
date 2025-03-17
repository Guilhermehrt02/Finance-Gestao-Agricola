import { InjectionToken } from '@angular/core';
import { Environment } from '@farm/core';

export const APP_CONFIG = new InjectionToken<Environment>('Application config');
