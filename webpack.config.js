const path = require('path');
const CopyPlugin = require('copy-webpack-plugin');
const {CleanWebpackPlugin} = require('clean-webpack-plugin');

module.exports = {
    entry: path.join(__dirname, 'src', 'app.js'),
    module: {
        rules: [
            {
                test: /\.s[ac]ss$/i,
                use: [
                    // Creates `style` nodes from JS strings
                    "style-loader",
                    // Translates CSS into CommonJS
                    "css-loader",
                    // Compiles Sass to CSS
                    "sass-loader",
                ],
            },
            {
                test: /\.(png|svg|jpg|jpeg|gif|ico)$/i,
                use: [
                    {
                        loader: 'file-loader',
                    },
                ],
            },
            {
                test: /\.(woff|woff2|eot|ttf|otf)$/i,
                use: [
                    {
                        loader: 'file-loader',
                    },
                ],
            },
        ],
    },
    output: {
        filename: 'app.js',
        path: path.join(__dirname, 'wwwroot'),
    },
    plugins: [
        new CopyPlugin({
            patterns: [
                { from: 'node_modules/jquery/dist/jquery.min.js', to: '' },
                { from: 'node_modules/jquery-validation/dist/jquery.validate.min.js', to: '' },
                { from: 'node_modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js', to: '' },
                { from: 'node_modules/bootstrap-icons/bootstrap-icons.svg', to: '' },
                { from: 'src/img', to: 'img' },
                { from: 'src/favicon', to: '' },
            ],
        }),
    ],
    watchOptions: {
        ignored: [
            "node_modules/"
        ]
    }
};