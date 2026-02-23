function reverseArr(arr) {
  let reverse = [];

  // for(let i = arr.length-1; i>= 0; i--){
  //     reverse.push(arr[i])
  // }
  
  let j = 0;
  
  for (let i = arr.length - 1; i >= 0; i--) {
      reverse[j] = arr[i];
      j++;
    }
    console.log(reverse);
}
reverseArr([23, 12, 3, 45, 3]);
