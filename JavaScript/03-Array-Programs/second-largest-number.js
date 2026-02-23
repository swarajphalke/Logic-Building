function secondLargestNum(arr) {
  let first = arr[0];
  let second = arr[0];
  for (let num of arr) {
    if (num > first) {
      second = first;
      first = num;
    } else if (num > second && num !== first) {
      second = num;
    }
  }

  console.log(second);
}
secondLargestNum([10, 20, 30, 40]);
