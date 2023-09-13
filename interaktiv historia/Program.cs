// See https://aka.ms/new-console-template for more information

Console.WriteLine("Du vaknar upp i veras house of horrors. du är mitt i en labyrint");
Console.WriteLine("Plötsligt hör du ett ljud.");
Console.WriteLine("'Hjälp! Hjälp'");
Console.WriteLine("det ligger en liten tomte vera och sprattlar, han skriker och ber att du ska hjälpa honom upp.");
Console.WriteLine("hjälper du? y/n?");

string choice = Console.ReadLine ();


if (choice == "y")
{
  Console.WriteLine("Du tar tag i tomten och drar upp honom i armarna. Vera ställer sig upp och skakar av sig vattnet.");
  Console.WriteLine(" 'Tack för att du räddade mig! Jag är dig evigt tacksam, mitt namn är Vera Cohen, är du vilse? Jag kan hjälpa dig genom labyrinten, men du måste lyssna noga för det är en farlig labyrint'");
  Console.WriteLine("lyssnar du på Vera Cohen? y/n");
  Console.ReadLine();
  if (choice == "y")
  {
Console.WriteLine("bra, vera tar dig till en smal liten öppning i en av väggarna");
Console.WriteLine("du måste gå igenom ensam, jag får inte plats i hålet. Jag kommer att ge dig instruktioner att följa, och om du inte följer dom så dör du.");
Console.WriteLine("vera säger 'gå vänster vänster höger vänster höger.'");
Console.ReadLine();
if (choice== "vänster vänster höger vänster höger");
Console.WriteLine("du kommer ut till ett stenrum, där sitter vera med en pigelin och kollar på dig.");
Console.WriteLine("haha jag lurade dig!");
Console.WriteLine("du blir äten av vera");
Console.WriteLine("-lurad ending-");
Console.ReadLine();
  }

  if (choice == "höger höger vänster höger vänster")
  {
  Console.WriteLine("du kom ut, överlevde, bra jobbat! du lurade vera!");
  Console.WriteLine("-secret ending-");
  }
}

else if (choice == "n")
{
  Console.WriteLine("det var en fälla. vera äter dig, du borde lyssnat.");
  Console.WriteLine("-dryg ending-");
}