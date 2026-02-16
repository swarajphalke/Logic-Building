function countVowel(str) {
  let count = 0;

  let vowels = "";
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
      vowels += str[i];
    }
  }

  console.log(count);
  console.log("vowels are -> ", vowels);
}

countVowel("javascript");
