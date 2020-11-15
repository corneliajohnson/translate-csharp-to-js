function main() {
  // Put your code here
  console.log("Do you believe in magic?")
  console.log("------------------------")

  const allSpells = GetAllSpells();
  const goodBook = MakeGoodSpellBook(allSpells)
  const evilBook = MakeEvilSpellBook(allSpells)
  DisplaySpellBook(goodBook)
  console.log("\n")
  DisplaySpellBook(evilBook)

  function DisplaySpellBook(book) {
    console.log(book.title)
    book.spells.forEach(spell => console.log(spell.Name))
  }

  function MakeGoodSpellBook(spells){
    const goodBook = {title: "Good Book"}
    goodBook.spells = spells.filter(spell => !spell.IsEvil)
    return goodBook
  }

  function MakeEvilSpellBook(spells){
    const evilBook = {title: "Evil Book"}
    evilBook.spells = spells.filter(spell => spell.IsEvil)
    return evilBook;
  }

  function GetAllSpells(){
    return [
      {
        Name: "Turn enemy into a newt",
        IsEvil: true,
        EnergyReqired: 5.1
      },
      {
        Name: "Conjure some gold for a local charity",
        IsEvil: false,
        EnergyReqired: 2.99
    },
    {
        Name: "Give a deaf person the ability to heal",
        IsEvil: false,
        EnergyReqired: 12.2
    },
    {
        Name: "Make yourself emperor of the universe",
        IsEvil: true,
        EnergyReqired: 100.0
    },
     {
        Name:"Convince your relatives your political views are correct",
        IsEvil: false,
        EnergyReqired: 2921.5
    }
    ]
  }

}

main();