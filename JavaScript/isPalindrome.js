function isPalindrome(num) {
  let original = num;
  let reverse = 0;

  while (num > 0) {
    let digit = num % 10;
    reverse = reverse * 10 + digit;
    num = Math.floor(num / 10);
  }
  if (original === reverse) console.log("Is Palindrome");
  else {
    console.log("Not Palindrome");
  }
}
isPalindrome(12421);
