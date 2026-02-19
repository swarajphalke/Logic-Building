function CountDigits(num) {
  let count = 0;

  while (num > 0) {
    count++;
    num = Math.floor(num / 10);
  }

  console.log("Digits are", count);
}
CountDigits(6655);
