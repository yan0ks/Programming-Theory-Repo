using OpenCover.Framework.Model;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private int animalSpeed;
    public int AnimalSpeed
    {
        get { return animalSpeed; }
        set { animalSpeed = value; }
    }

    private string animalName;
    public string AnimalName
    {
        get { return animalName; }
        set { animalName = value; }
    }

    public abstract string Eat();

    public abstract void Jump();

    public abstract void Run();

    public abstract void Say();
}
