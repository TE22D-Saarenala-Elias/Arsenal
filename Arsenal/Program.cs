using System.Text.Json;
// Weapon weapon = new Weapon(){
//     Name = "Sword",
//     DamageMax = 10,
//     DamageMin = 1
// };


string Weapon = File.ReadAllText("weapon.json");
 
Weapon Sword = JsonSerializer.Deserialize<Weapon>(Weapon);

Console.WriteLine("Tryck på en siffra mellan 1 och 10 och sen enter");



for (){
    ;
}










Console.WriteLine(Sword.Name + " " +
                    Sword.DamageMin + " "+
                    Sword.DamageMax);

// string gText = JsonSerializer.Serialize(goomba);
// Console.WriteLine();
// File.WriteAllText("goomba.txt", gText);

Console.ReadLine();