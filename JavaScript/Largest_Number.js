let nums = [4, 9, 2, 15, 6];

let max = nums[0]

for(let i = 0; i<nums.length; i++){
    if(nums[i] > max){
        max=nums[i]
    }
}
console.log(max);