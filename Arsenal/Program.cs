using System.Text.Json;



string gText = File.ReadAllText("goomba.json");
Weapon goomba = new();

// Enemy goomba = new()
// {
//     Name = "Goomba",
//     Hp = 1
// };

// string gText = JsonSerializer.Serialize(goomba);
// Console.WriteLine();
// File.WriteAllText("goomba.txt", gText);

Console.ReadLine();