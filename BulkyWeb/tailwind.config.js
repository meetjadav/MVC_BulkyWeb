module.exports = {
    content: [
        './Views/**/*.cshtml',
        './Pages/**/*.cshtml',
        './wwwroot/js/**/*.js',
    ],
    theme: {
        extend: {
            boxShadow: {
                'top-bottom-md': '0 -4px 6px rgba(128, 128, 128, 0.1), 0 4px 6px rgba(128, 128, 128, 0.1)', // Strictly top and bottom
            },
},
    },
    plugins: [],
    // Optionally disable purge for debugging
    mode: 'jit',
    purge: false,
}
