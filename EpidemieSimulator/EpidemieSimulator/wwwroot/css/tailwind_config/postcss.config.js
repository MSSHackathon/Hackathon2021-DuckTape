const purgecss = require("@fullhuman/postcss-purgecss");
const cssnano = require("cssnano");

module.exports = {
    plugins: [
        require("tailwindcss"),
        require("autoprefixer"),
        cssnano({
            preset: ['default', {
                discardComments: {
                    removeAll: true,
                },
            }],
        }),
        purgecss({
            content: [
                "../**/**/*.html",
                "../**/**/*.razor",
                "../**/**/*.razor.cs",
                "../**/**/*.js",
            ],
            safelist: [/^border-(\d|.-\d)/],
            defaultExtractor: (content) =>
            content.match(/[\w-/:]+(?<!:)/g) || [],
        }),
    ],
};