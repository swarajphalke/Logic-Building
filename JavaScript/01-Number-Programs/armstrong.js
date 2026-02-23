function armstrong(num) {
  let originalVal = num;
  let sum = 0;

  while (num > 0) {
    let digit = num % 10;
    sum = sum + digit ** 3;
    num = Math.floor(num / 10);
  }
  console.log(originalVal === sum ? "ArmStrong" : "Not Armstrong");
}

armstrong(153);
