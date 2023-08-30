using UnityEngine;

public class Dog : Animal
{
    public override void Eat()
    {
        Debug.Log("Собачка грызет косточку...");
    }

    public override void Jump()
    {
        Debug.Log("Собачка прыгает...");
    }

    public override void Run()
    {
        Speed = 5;
        Debug.Log("Собачка бежит со скоростью " + Speed);
        Say();
        Jump();
        Eat();
    }

    public override void Say()
    {
        Debug.Log("Собачка говорит Гав-Гав...");
    }
}
