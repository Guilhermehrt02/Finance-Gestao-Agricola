import { Component } from '@angular/core';
import { PrimeNG, ThemeType } from 'primeng/config';
import Aura from '@primeng/themes/aura';
import { definePreset } from '@primeng/themes';
import { RouterModule } from '@angular/router';
import { ToastModule } from 'primeng/toast';

@Component({
  imports: [RouterModule, ToastModule],
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'HandsOn';

  constructor(private primeng: PrimeNG) {
    const themePreset: ThemeType = {
      preset: preset,
      options: {
        cssLayer: {
          name: 'primeng',
          order: 'app-styles, tailwind-base, primeng, tailwind-utilities',
        },
        darkModeSelectors: ['.dark'],
      },
    };

    this.primeng.theme.set(themePreset);
  }
}

const preset = definePreset(Aura, {
  semantic: {
    primary: {
      50: '{blue.50}',
      100: '{blue.100}',
      200: '{blue.200}',
      300: '{blue.300}',
      400: '{blue.400}',
      500: '{blue.500}',
      600: '{blue.600}',
      700: '{blue.700}',
      800: '{blue.800}',
      900: '{blue.900}',
      950: '{blue.950}',
    },
  },
});
