function main() {
  // Put your code here
console.log("Let's roll some dice, baby!")
console.log("---------------------------")

for(let i = 0; i < 10; i++){
  let die1 = Roll()
  let die2= Roll()

  let message = `${Die(die1)} + ${Die(die2)} == ${die1 + die2}`
  if (die1 === die2){
    message += " DOUBLES"
  }
  console.log(message)
}

function Roll(){
  let dieValue = Math.floor(Math.random() * 6) + 1;  // returns a random integer from 1 to 6
  return dieValue;
}

function Die(value){
  let dieString = "Unknown"

 switch(value){
  case 1:
    dieString = "\u2680";
    break;
  case 2:
    dieString = "\u2681";
    break;
  case 3:
    dieString = "\u2682";
    break;
  case 4:
    dieString = "\u2683";
    break;
  case 5:
    dieString = "\u2684";
    break;
  case 6:
    dieString = "\u2685";
    break;
}
return dieString;
 }
}

main();