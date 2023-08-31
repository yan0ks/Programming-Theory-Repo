using UnityEngine;

public class Cat : Animal
{
    public override string Eat()
    {
        return $" иска {AnimalName} лакает молочко...";
    }

    public override void Jump()
    {
        Debug.Log($" иска {AnimalName} прыгает...");
    }

    public override void Run()
    {
        AnimalSpeed = 3;
        Debug.Log($" иска {AnimalName} бежит со скоростью {AnimalSpeed} км/ч");
    }

    public override void Say()
    {
        Debug.Log($" иска {AnimalName} говорит ћ€ууууууу...");
        Run();
        Jump();
        Eat();
    }
}
