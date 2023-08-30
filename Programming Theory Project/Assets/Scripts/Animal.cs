using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private int speed = 0;
    public int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }


    public abstract void Eat();

    public abstract void Jump();

    public abstract void Run();

    public abstract void Say();
}
