int heroHealth = 10;
int monsterHealth = 10;

Random dice = new Random();

do
{
    int heroDamage = dice.Next(1, 6);
    monsterHealth -= heroDamage;
    Console.WriteLine($"The Monster was damaged and lost {heroDamage} and now has {monsterHealth} health");

    if (monsterHealth <= 0) continue;

    int monsterDamage = dice.Next(1, 6);
    heroHealth -= monsterDamage;
    Console.WriteLine($"The hero was damaged and lost {monsterDamage} and now has {heroHealth} health");
} while (heroHealth > 0 && monsterHealth > 0);
Console.WriteLine(heroHealth > monsterHealth ? "Hero Wins!" : "Monster Wins!");
