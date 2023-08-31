using UnityEngine;

public class Rabbit : Animal
{
    public override string Eat()
    {
        Debug.Log($"������ {AnimalName} ��� �������� ����-����...");
        Jump();
        Run();
        Say();
        return $"������ {AnimalName} ��� �������� ����-����...";

    }

    public override void Jump()
    {
        Debug.Log($"������ {AnimalName} ������� ����-����...");
    }

    public override void Run()
    {
        AnimalSpeed = 4;
        Debug.Log($"������ {AnimalName} ����� �� ��������� {AnimalSpeed} ��/�");
    }

    public override void Say()
    {
        Debug.Log($"������� {AnimalName} ������� �������� ���� �� ��� �������� ����-����...");
    }
}
