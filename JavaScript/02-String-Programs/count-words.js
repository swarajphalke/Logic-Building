function countWords(str){
    let count = 0;

    for(let i =0; i<=str.length-1; i++){
        if( str[i] !== " " && (i===0 || str[i-1]===" ") ){
            count++
        }
    }
    console.log(count);
    
}
countWords("Hello Swaraj How are you")