function countVowel(str) {
  let count = 0;

  let vowel = "";
  for (let i = 0; i < str.length; i++) {
    let char = str[i];
    if (
      char == "a" ||
      char == "e" ||
      char == "i" ||
      char == "o" ||
      char == "u"
    ) {
      count++;
      vowel += str[i];
    }
  }

  console.log(count);
  console.log("vowels are -> ", vowel);
}

countVowel("javascript");
