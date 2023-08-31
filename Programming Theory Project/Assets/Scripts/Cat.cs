using UnityEngine;

public class Cat : Animal
{
    public override string Eat()
    {
        return $"����� {AnimalName} ������ �������...";
    }

    public override void Jump()
    {
        Debug.Log($"����� {AnimalName} �������...");
    }

    public override void Run()
    {
        AnimalSpeed = 3;
        Debug.Log($"����� {AnimalName} ����� �� ��������� {AnimalSpeed} ��/�");
    }

    public override void Say()
    {
        Debug.Log($"����� {AnimalName} ������� ���������...");
        Run();
        Jump();
        Eat();
    }
}
