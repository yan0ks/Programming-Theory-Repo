using UnityEngine;

public class Rabbit : Animal
{
    public override string Eat()
    {
        Debug.Log($"Кролик {AnimalName} ест морковку хрум-хрум...");
        Jump();
        Run();
        Say();
        return $"Кролик {AnimalName} ест морковку хрум-хрум...";

    }

    public override void Jump()
    {
        Debug.Log($"Кролик {AnimalName} прыгает прыг-скок...");
    }

    public override void Run()
    {
        AnimalSpeed = 4;
        Debug.Log($"Кролик {AnimalName} бежит со скоростью {AnimalSpeed} км/ч");
    }

    public override void Say()
    {
        Debug.Log($"Кролику {AnimalName} некогда говорить ведь он ест морковку хрум-хрум...");
    }
}
