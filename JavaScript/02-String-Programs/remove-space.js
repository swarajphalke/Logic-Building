function removeSpace(str) {
  let result = "";

  for (let i = 0; i <= str.length - 1; i++) {
    if (str[i] !== " ") {
      result += str[i];
    }
  }
  console.log(result);
}

removeSpace("Hello World Swaraj");
