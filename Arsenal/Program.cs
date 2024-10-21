using System.Text.Json;


string Weapon = File.ReadAllText("weapon.json");
 
Weapon Sword = JsonSerializer.Deserialize<Weapon>(Weapon);

Console.WriteLine("Tryck på en siffra mellan 1 och 5 och sen enter");
string Input = Console.ReadLine();
int LoopRead=0;
int AttackRounds=0;
int DamageSum=0;



if (Input=="1")
{ AttackRounds=1; }
if (Input=="2")
{ AttackRounds=2; }
if (Input=="3")
{ AttackRounds=3; }
if (Input=="4")
{ AttackRounds=4; }
if (Input=="5")
{ AttackRounds=5; }

while(true){
    LoopRead++;


    if (LoopRead != (AttackRounds+ 1)){
        Sword.Damage= Sword.Attack();
        DamageSum += Sword.Damage;
        Console.WriteLine($"Runda {LoopRead} - Du attackerar med {Sword.Damage}");
    }

    if (LoopRead==AttackRounds){
        break;

    }
}

 

Console.WriteLine("Din Sammanlagda skada är " + DamageSum);











Console.ReadLine();