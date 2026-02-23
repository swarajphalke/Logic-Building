function palindromeString(str) {
  let originalStr = str.toLowerCase();
  let reverse = "";

  for (let i = str.length - 1; i >= 0; i--) {
    reverse += str[i];
  }
  console.log(
    originalStr === reverse ? "Palindrome String " : "Not Palindrome String",
  );
}

palindromeString("INDIA");
