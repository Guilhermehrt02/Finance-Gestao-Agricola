module.exports = {
  theme: {
    extend: {},
  },
  variants: {
    extend: {},
  },
  plugins: [require('tailwindcss-primeui')],
  content: [
    './src/**/*.{html,js,ts,jsx,tsx}',
    './lib/**/*.{html,js,ts,jsx,tsx}',
  ],
};
