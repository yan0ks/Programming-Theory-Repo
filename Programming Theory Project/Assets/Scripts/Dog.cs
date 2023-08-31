using UnityEngine;

public class Dog : Animal
{
    public override string Eat()
    {
        return $"������� {AnimalName} ������ ��������...";
    }

    public override void Jump()
    {
        Debug.Log($"������� {AnimalName} �������...");
    }

    public override void Run()
    {
        AnimalSpeed = 5;
        Debug.Log($"������� {AnimalName} ����� �� ��������� {AnimalSpeed} ��/�");
        Say();
        Jump();
        Eat();
    }

    public override void Say()
    {
        Debug.Log($"������� {AnimalName} ������� ���-���...");
    }
}
