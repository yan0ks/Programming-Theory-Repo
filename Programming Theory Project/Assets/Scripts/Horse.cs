using UnityEngine;

public class Horse : Animal
{
    public override void Eat()
    {
        Debug.Log("Лошадка ест сено...");
    }

    public override void Jump()
    {
        Debug.Log("Лошадка прыгает...");
        Run();
        Say();
        Eat();
    }

    public override void Run()
    {
        Speed = 7;
        Debug.Log("Лошадка скачет со скоростью ..." + Speed);
    }

    public override void Say()
    {
        Debug.Log("Лошадка говорит Иго-го...");
    }
}
