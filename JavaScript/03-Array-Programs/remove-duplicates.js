function removeDuplicte(arr) {
  let result = [];
  let j = 0;
  for (num of arr) {
    if (!result.includes(num)) {
      result[j] = num;
      j++;
    }
  }
  console.log(result);
}
removeDuplicte([2, 3, 4, 5, 1, 2]);
