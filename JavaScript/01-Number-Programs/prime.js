function isPrime(num) {
  let count = 0;

  for (let i = 1; i <= num; i++) {
    if (num % i === 0) {
      count++;
    }
  }

  console.log(count === 2 ? "Prime Number" : "Not Prime Number");
}

isPrime(10);
