using UnityEngine;

public class Rabbit : Animal
{
    public override void Eat()
    {
        Debug.Log("������ ���� �������� ����-����...");
        Jump();
        Run();
        Say();
    }

    public override void Jump()
    {
        Debug.Log("������ ������� ����-����...");
    }

    public override void Run()
    {
        Speed = 4;
        Debug.Log("������ ����� �� ���������..." + Speed);
    }

    public override void Say()
    {
        Debug.Log("������� ������� �������� ���� �� ��� �������� ����-����...");
    }
}
