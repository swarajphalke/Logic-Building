function reverseNum(num) {
  let reverse = 0;

  while (num > 0) {
    let digit = num % 10;
    reverse = reverse * 10 + digit;
    // num = (num / 10) | 0;     // Bitwise OR with 0 converts number to 32-bit integer - It automatically removes decimal part.
    // num = parseInt(num/10)    //parseInt() removes decimal part.
    num = Math.floor(num / 10);
  }
  console.log(reverse);
}
reverseNum(54321);
