using UnityEngine;

public class Horse : Animal
{
    public override void Eat()
    {
        Debug.Log("������� ��� ����...");
    }

    public override void Jump()
    {
        Debug.Log("������� �������...");
        Run();
        Say();
        Eat();
    }

    public override void Run()
    {
        Speed = 7;
        Debug.Log("������� ������ �� ��������� ..." + Speed);
    }

    public override void Say()
    {
        Debug.Log("������� ������� ���-��...");
    }
}
