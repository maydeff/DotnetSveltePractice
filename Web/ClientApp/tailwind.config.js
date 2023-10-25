/** @type {import('tailwindcss').Config} */
export default {
  content: ["./src/**/*.{html,js,svelte,ts}"],
  theme: {
    extend: {},
    colors: {
      'dark-primary' : '#181a1b',
      'dark-secondary': '#1b1d1e',
      'read-white': '#dad7d2',
      'cinder': {
    '50': '#f2f1fe',
    '100': '#e3e2fc',
    '200': '#bfbef9',
    '300': '#8585f4',
    '400': '#4447ec',
    '500': '#1c20db',
    '600': '#110fba',
    '700': '#110d97',
    '800': '#110f7d',
    '900': '#161268',
    '950': '#040311',
},

    }
  },
  plugins: [],
};
