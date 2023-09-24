int heroHealthPoint = 10;
int monsterHealthPoint = 10;

string winner = "";

Random randomAttackPoint = new Random();
do
{
    //Hero turn
    int randomAttackPointHero = randomAttackPoint.Next(1, 11);

    monsterHealthPoint -= randomAttackPointHero;

    Console.WriteLine(
        $"Monster was damaged and lost {randomAttackPointHero} health and now has {monsterHealthPoint}"
    );
    if (monsterHealthPoint <= 0)
    {
        winner = "Hero";
        break;
    }

    //Monster turn
    //Hero turn
    int randomAttackPointMonster = randomAttackPoint.Next(1, 11);

    heroHealthPoint -= randomAttackPointMonster;

    Console.WriteLine(
        $"Hero was damaged and lost {randomAttackPointMonster} health and now has {heroHealthPoint}"
    );
    if (heroHealthPoint <= 0)
    {
        winner = "Monster";
        break;
    }
} while (heroHealthPoint > 0 && monsterHealthPoint > 0);

Console.WriteLine($"{winner} wins!");
