module.exports = {
    content: [
        './Views/**/*.cshtml',
        './Pages/**/*.cshtml',
        './wwwroot/js/**/*.js',
    ],
    theme: {
        extend: {},
    },
    plugins: [],
    // Optionally disable purge for debugging
    mode: 'jit',
    purge: false,
}
