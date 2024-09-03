
Chomp chomp = new Chomp();
Player player= new Player();

player.hp = 150;
chomp.hp = 100;

Random random = new Random();

// void fight(Player player, Chomp chomp){

// }
 Console.WriteLine("Press enter to start the game");
    Console.WriteLine($"Hero Hp = {player.hp} Chomp Hp = {chomp.hp}");
while(player.hp > 0 && chomp.hp > 0){
   
    Console.ReadLine();
    
    chomp.hp -= random.Next(player.minAttack, player.maxAttack);
   player.hp -= random.Next(chomp.minAttack, chomp.maxAttack);
      Console.WriteLine("Press enter to start the next round");
      Console.WriteLine($"Hero Hp = {player.hp} Chomp Hp = {chomp.hp}");
    
 
}
Console.WriteLine();
Console.ReadLine();
