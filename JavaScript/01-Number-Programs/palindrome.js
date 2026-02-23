function isPalindrome(num) {
  let originalVal = num;
  let reverse = 0;

  while (num > 0) {
    let digit = num % 10;
    reverse = reverse * 10 + digit;
    num = Math.floor(num / 10);
  }
  console.log(originalVal === reverse ? "Palindrome" : "Not Palindrome");
}

isPalindrome(233332);
