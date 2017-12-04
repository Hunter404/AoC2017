/**
 * Splits a string into an array of numbers
 * param {String} string of numbers
 * return {Array} array of numbers
 */
function stringToNumbers(string) {
    return string.split('').map(c => Number(c));
}

/**
 * Calculate the captcha summary from an array of numbers
 * param {Array} array of numbers
 * return {Number} captcha
 */
function captchaSum(captcha) {
    return captcha.filter((i, index) => i === captcha[index + 1 >= captcha.length ? 0 : index + 1]).reduce((sum, val) => sum + val);
}

captchaSum(stringToNumbers(captcha));
