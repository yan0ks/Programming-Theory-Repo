using UnityEngine;

public class Cat : Animal
{
    public override void Eat()
    {
        Debug.Log("Ћакает молочко...");
    }

    public override void Jump()
    {
        Debug.Log(" иска прыгает...");
    }

    public override void Run()
    {
        Speed = 3;
        Debug.Log(" иска бежит со скоростью " + Speed);
    }

    public override void Say()
    {
        Debug.Log(" иска говорит ћ€ууууууу...");
        Run();
        Jump();
        Eat();
    }
}
