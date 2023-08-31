using UnityEngine;

public class Dog : Animal
{
    public override string Eat()
    {
        return $"Собачка {AnimalName} грызет косточку...";
    }

    public override void Jump()
    {
        Debug.Log($"Собачка {AnimalName} прыгает...");
    }

    public override void Run()
    {
        AnimalSpeed = 5;
        Debug.Log($"Собачка {AnimalName} бежит со скоростью {AnimalSpeed} км/ч");
        Say();
        Jump();
        Eat();
    }

    public override void Say()
    {
        Debug.Log($"Собачка {AnimalName} говорит Гав-Гав...");
    }
}
