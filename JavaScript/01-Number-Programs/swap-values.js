function swapValues(a, b) {

console.log("Old value of a",a);
console.log("Old value of b",b);
 
  a = a + b;
  b = a - b;
  a = a - b;

console.log("New value of a", a);
console.log("New value of b", b);
}

swapValues(10, 30);
