using UnityEngine;

public class Horse : Animal
{
    public override string Eat()
    {
        return $"������� {AnimalName} ��� ����...";
    }

    public override void Jump()
    {
        Debug.Log($"������� {AnimalName} �������...");
        Run();
        Say();
        Eat();
    }

    public override void Run()
    {
        AnimalSpeed = 7;
        Debug.Log($"������� {AnimalName} ������ �� ��������� {AnimalSpeed} ��/�");
    }

    public override void Say()
    {
        Debug.Log($"������� {AnimalName} ������� ���-��...");
    }
}
