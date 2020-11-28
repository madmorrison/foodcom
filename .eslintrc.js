module.exports = {
    env: {
        es6: true,
    },
    extends: [
        'airbnb-base',
        'plugin:mocha/recommended'
    ],
    plugins: [
        'mocha'
    ],
    globals: {
        Atomics: 'readonly',
        SharedArrayBuffer: 'readonly',
    },
    parserOptions: {
        ecmaVersion: 2018,
        sourceType: 'module',
    },
    rules: {
        'indent': ['error', 2, { 'ignoredNodes': ['TemplateLiteral *'] }],
        'function-paren-newline': 'off',
        'mocha/no-mocha-arrows': 'off',
    }
};