function main() {
  // Put your code here
  const names = ["Nashville", "Hong Kong", "The back yard", "Earth", "London", "The mall", "Ryman Auditorium", "The Great Wall of China"]

  console.log("All Place Names")

  names.forEach(name => console.log(name))

  console.log("\n")

  const filterTheNames = names.filter(name => name.startsWith("The"))
  
  console.log(`'The' Place Names`)
  
  filterTheNames.forEach(name => console.log(name))
}

main();