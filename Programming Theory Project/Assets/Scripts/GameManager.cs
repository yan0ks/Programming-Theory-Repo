using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Cat cat;

    [SerializeField]
    Dog dog;

    [SerializeField]
    Horse horse;

    [SerializeField]
    Rabbit rabbit;

    // Start is called before the first frame update
    void Start()
    {
        cat.Say();
        dog.Run();
        horse.Jump();
        rabbit.Eat();
    }

    // Update is called once per frame
}