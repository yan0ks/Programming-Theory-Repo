using UnityEngine;

public class Cat : Animal
{
    public override void Eat()
    {
        Debug.Log("������ �������...");
    }

    public override void Jump()
    {
        Debug.Log("����� �������...");
    }

    public override void Run()
    {
        Speed = 3;
        Debug.Log("����� ����� �� ��������� " + Speed);
    }

    public override void Say()
    {
        Debug.Log("����� ������� ���������...");
        Run();
        Jump();
        Eat();
    }
}
