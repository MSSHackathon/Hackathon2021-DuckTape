const { colors } = require('tailwindcss/defaultTheme')
let customColors = {
    transparent: colors.transparent,
    white: colors.white,
    black: colors.black,
    gray: {
        '50': '#FAFAFA',
        '100': '#F4F4F5',
        '150': '#ECECEE',
        '200': '#E4E4E7',
        '300': '#D4D4D8',
        '400': '#A1A1AA',
        '500': '#71717A',
        '600': '#52525B',
        '700': '#3F3F46',
        '800': '#27272A',
        '900': '#18181B',
    },
    blue: {
        '50': '#EFF6FF',
        '100': '#DBEAFE',
        '200': '#BFDBFE',
        '300': '#93C5FD',
        '400': '#60A5FA',
        '500': '#3B82F6',
        '600': '#2563EB',
        '700': '#1D4ED8',
        '800': '#1E40AF',
        '900': '#1E3A8A',
    },
    green: {
        '50': '#F0FDF4',
        '100': '#DCFCE7',
        '200': '#BBF7D0',
        '300': '#86EFAC',
        '400': '#4ADE80',
        '500': '#22C55E',
        '600': '#16A34A',
        '700': '#15803D',
        '800': '#166534',
        '900': '#14532D',
    },
    yellow: {
        '50': '#FEFCE8',
        '100': '#FEF9C3',
        '200': '#FEF08A',
        '300': '#FDE047',
        '400': '#FACC15',
        '500': '#EAB308',
        '600': '#CA8A04',
        '700': '#A16207',
        '800': '#854D0E',
        '900': '#713F12',
    },
    orange: {
        '50': '#FFF7ED',
        '100': '#FFEDD5',
        '200': '#FED7AA',
        '300': '#FDBA74',
        '400': '#FB923C',
        '500': '#F97316',
        '600': '#EA580C',
        '700': '#C2410C',
        '800': '#9A3412',
        '900': '#7C2D12',
    },
    red: {
        '50': '#FEF2F2',
        '100': '#FEE2E2',
        '200': '#FECACA',
        '300': '#FCA5A5',
        '400': '#F87171',
        '500': '#EF4444',
        '600': '#DC2626',
        '700': '#B91C1C',
        '800': '#991B1B',
        '900': '#7F1D1D',
    },
    orgadata: {
        'primary': '#F58220',
        'secondary': '#ED1C24',
    },
};
module.exports = {
    purge: [],
    darkMode: 'class', // or 'media' or 'class'
    theme: {
        boxShadow: {
            light: '2px 2px 4px 2px rgba(0, 0, 0, 0.3)',
            dark: '2px 2px 4px 1px rgba(0, 0, 0, 0.4)',
            'very-light': '1px 1px 2px 1px rgba(0, 0, 0, 0.2)',
            'very-dark': '1px 1px 2px 1px rgba(0, 0, 0, 0.6)',
            'side-dark': '0px 3px 7px 2px rgba(0, 0, 0, 0.4)',
            'side-light': '0px 3px 3px 2px rgb(0, 0, 0, 0.25)',
            none: 'none',
        },
        colors: {
            ...customColors,
        },
        extend: {
            fill: {
                ...customColors,
            },
            width: {
                '1/7': '14.2857143%',
            },
            maxHeight: {
                '1/4': '25%',
                '2/4': '50%',
                '1/2': '50%',
                '3/4': '75%',
                '5/6': '83.333333%',
            },
            maxWidth: {
                '1/2': '50%',
                '11/12': '91.666667%'
            },
            stroke: {
                ...customColors,
            },
        },
    },
    variants: {
        extend: {
            boxShadow: ['dark'],
            display: ['dark'],
            stroke: ['dark', 'hover'],
            fill: ['hover', 'dark', 'focus'],
            margin: ['odd'],
            padding: ['last']
        },
    },
    plugins: [],
}