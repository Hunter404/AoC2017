function stringToNumbers(string) {
    return string.split('').map(c => Number(c));
}

function captchaSum(captcha) {
    return captcha.filter((i, index) => i === captcha[index + 1 >= captcha.length ? 0 : index + 1]).reduce((sum, val) => sum + val);
}

captchaSum(stringToNumbers(captcha));
