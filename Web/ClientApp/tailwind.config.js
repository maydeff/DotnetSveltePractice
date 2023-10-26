/** @type {import('tailwindcss').Config} */
export default {
  content: ["./src/**/*.{html,js,svelte,ts}"],
  theme: {
    extend: {},
    colors: {
      'dark-primary' : '#181a1b',
      'dark-secondary': '#1b1d1e',
      'dark-search-bar': '#2f2f2f',
      'border-primary': '#ad99bb',
      'border-shadow': '#680e9c',
      'read-white': '#dad7d2',
      'deep-blue': {
          100: "#d0cde0",
          200: "#a19cc1",
          300: "#736aa1",
          400: "#443982",
          500: "#150763",
          600: "#11064f",
          700: "#0d043b",
          800: "#080328",
          900: "#040114"
      },
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
