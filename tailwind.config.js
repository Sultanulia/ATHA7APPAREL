/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ['./index.html'],
    theme: {
      extend: {
        backgroundImage: {
          'Service-Section': "url('https://i.pinimg.com/736x/e6/35/e9/e635e9e5d5224db5491230e727707985.jpg')",
          backdropGrayscale: {
            50:'.5'
          }
        }
      },
    },
    plugins: [],
  }