let nums = [4, 9, 2, 15, 6];

let largest = nums[0]
for(let i = 0; i<nums.length; i++){
    if(nums[i] > largest){
        largest=nums[i]
    }
}
console.log(largest);