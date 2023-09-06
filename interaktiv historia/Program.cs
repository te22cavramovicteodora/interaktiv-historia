// See https://aka.ms/new-console-template for more information

Console.WriteLine("Du vaknar upp förvrirad, du minns ingenting innan detta. Du kollar du dig runt. Du ligger på en fuktig gräsplätt som gör dina strumpor blöta. När du sätter dig upp så ser du höga väggar av buskar och träd som sträcker sig upp mot himmelen, medan solen, som lyser lite för starkt, skiner igenom busktopparna. Du verkar vara i en stor trädgård, med stora rosa blommor du inte känner igen. Förvirrad så ställer du dig upp och drar händerna över buskarna. Du är mitt i en labyrint.");
Console.WriteLine("Plötsligt hör du ett ljud.");
Console.WriteLine("'Hjälp! Hjälp'");
Console.WriteLine("du går för att undersöka och hittar ett litet vattendrag bakom en stor kruka. I vattendraget ligger en liten tomte och sprattlar, han skriker och ber att du ska hjälpa honom upp.");
Console.WriteLine("hjälper du? y/n?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "y")
{
  Console.WriteLine("Du tar tag i tomten och drar upp honom i armarna. Han ställer sig upp och skakar av sig vattnet.");
  Console.WriteLine("'Tack för att du räddade mig! Jag är dig evigt tacksam, mitt namn är Carl.E, är du vilsen?'");
  Console.WriteLine("Fingrarna dansar över kontrollerna, och systemen aktiveras.");
  Console.WriteLine("Livbåten skjuts ut ur skeppet precis i tid - bakom dig sprängs rymdskeppet i en enorm atomexplosion.");
  Console.WriteLine("Du lever, men du vet att företaget kommer att hålla dig ansvarig för skeppet - du kommer att vara skuldsatt resten av livet. Om inte radioaktiviteten från explosionen just gjort dig steril så hade dessutom dina barn och barnbarn fått ärva skulden.");
}
else if (choice == "n")
{
  Console.WriteLine("Du kommer in i reaktorrummet.");
  Console.WriteLine("Röda larmlampor blinkar, och du ser att reaktorn snart kommer att explodera.");
  Console.WriteLine("På en skärm blinkar frågan \"RESET REACTOR SYSTEMS?\"");
  Console.WriteLine("Under skärmen finns två knappar. En röd, en grön. Det står inget på dem som antyder vilken som är \"ja\" och vilken som är \"nej\".");
  Console.WriteLine("Trycker du på röd eller grön knapp?");

  choice = Console.ReadLine();
  choice = choice.ToLower();

  if (choice == "röd")
  {
    Console.WriteLine("Bra jobbat! Du mindes precis i tid att någon på marknadsföringsavdelningen tyckt att rött var en mycket snällare färg och att man därmed bytt färg på alla ja/nej-knappar.");
    Console.WriteLine("Rymdskeppet är räddat och kan åka vidare med sin last av illegala vapen.");
  }
  else if (choice == "grön")
  {
    Console.WriteLine("BOOM! Tyvärr hade du glömt att någon på marknadsföringsavdelningen tyckt att rött var en mycket snällare färg och att man därmed bytt färg på alla ja/nej-knappar.");
    Console.WriteLine("Du är död och rymdskeppet förintat.");
  }
  else
  {
    Console.WriteLine("Din klant! Du skrev inget jag kunde förstå, så nu dör du när reaktorn exploderar.");
  }
}
else
{
  Console.WriteLine("Din klant! Du skrev inget jag kunde förstå, så nu dör du när reaktorn exploderar.");
}

Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();
