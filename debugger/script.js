function toDebug(){
    console.log("learning to debug");
    return first();
}
function first(){
    console.log("first function");
    second();
    return 100;
}
function second(){
    console.log("second function");
}
let result = toDebug();
console.log(result);

