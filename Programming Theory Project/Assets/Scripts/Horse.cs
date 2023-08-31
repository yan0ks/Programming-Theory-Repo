using UnityEngine;

public class Horse : Animal
{
    public override string Eat()
    {
        return $"Лошадка {AnimalName} ест сено...";
    }

    public override void Jump()
    {
        Debug.Log($"Лошадка {AnimalName} прыгает...");
        Run();
        Say();
        Eat();
    }

    public override void Run()
    {
        AnimalSpeed = 7;
        Debug.Log($"Лошадка {AnimalName} скачет со скоростью {AnimalSpeed} км/ч");
    }

    public override void Say()
    {
        Debug.Log($"Лошадка {AnimalName} говорит Иго-го...");
    }
}
