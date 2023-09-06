/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./src/index.html",
    "./src/app/app.component.{html, ts}",
    "./src/app/pages/home/home.component.{html, ts}",
    "./src/app/components/header/header.component.{html, ts}"
  ],
  darkMode: 'class',
  theme: {
    extend: {},
  },
  plugins: [],
}

