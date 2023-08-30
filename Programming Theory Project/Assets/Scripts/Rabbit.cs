using UnityEngine;

public class Rabbit : Animal
{
    public override void Eat()
    {
        Debug.Log("Кролик есть морковку хрум-хрум...");
        Jump();
        Run();
        Say();
    }

    public override void Jump()
    {
        Debug.Log("Кролик прыгает прыг-скок...");
    }

    public override void Run()
    {
        Speed = 4;
        Debug.Log("Кролик бежит со скоростью..." + Speed);
    }

    public override void Say()
    {
        Debug.Log("Кролику некогда говорить ведь он ест морковку хрум-хрум...");
    }
}
