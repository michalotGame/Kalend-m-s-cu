
DateTime cas = DateTime.Now; 
int cislMesice = cas.Month;    //Zjistíto to měsíc a uložího ho

string[] poleMesicu = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec" };
//tady jsem udělal seznam měsíců který ze kterého pak bude celý program vycházet

Console.WriteLine($"Nyní je  {poleMesicu[cislMesice - 1]} , další měsíc je {poleMesicu[cislMesice]}, Předchozí měsíc byl{poleMesicu[cislMesice - 2]}. ");
Console.WriteLine("-------------"); //vypíše se mi aktuální měsíc 

Console.WriteLine("Zadejte číslo od 1 do 12 (číslo měsíce) ");
int Mesic = Convert.ToInt32(Console.ReadLine());
int MesicMinus = Mesic - 1;
int MesicpPlus = Mesic + 1;

if (Mesic >= 2 && Mesic <= 11)     
  {
    Console.WriteLine($"Nyní je  {poleMesicu[Mesic - 1]} , další měsíc je {poleMesicu[MesicpPlus]}, Předchozí měsíc byl{poleMesicu[MesicMinus - 1]}. ");
  }

  else if (Mesic == 1)
  {
    Console.WriteLine($"Nyní je  {poleMesicu[0]} , další měsíc je {poleMesicu[1]}, Předchozí měsíc byl{poleMesicu[11]}. ");
    Console.ReadLine();
  }
  else if (Mesic == 12)
  {
    Console.WriteLine($"Nyní je  {poleMesicu[11]} , další měsíc je {poleMesicu[0]}, Předchozí měsíc byl{poleMesicu[10]}. ");
    Console.ReadLine();
  }



Console.WriteLine("Chcete vypsat všechny měsíce? Y/N");
string volba = Console.ReadLine();
if (volba == "Y")
{
    foreach(string pole in poleMesicu)
    {
        Console.WriteLine(pole);
    }
}
else if (volba == "N")
{
    Console.WriteLine("OK nic nebude");
}