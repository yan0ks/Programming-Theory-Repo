using UnityEngine;

public class Dog : Animal
{
    public override void Eat()
    {
        Debug.Log("������� ������ ��������...");
    }

    public override void Jump()
    {
        Debug.Log("������� �������...");
    }

    public override void Run()
    {
        Speed = 5;
        Debug.Log("������� ����� �� ��������� " + Speed);
        Say();
        Jump();
        Eat();
    }

    public override void Say()
    {
        Debug.Log("������� ������� ���-���...");
    }
}
