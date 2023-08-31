using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    List<Animal> animals;

    [SerializeField]
    TMP_InputField animalName;
    string animalName1;

    [SerializeField]
    GameObject[] deactivatedUI;

    [SerializeField]
    TMP_Text outputText;


    public void StartGame()
    {
        CreateRandomPet();
        DeactivateUI();
    }

    public void DeactivateUI()
    {
        foreach (var ui in deactivatedUI)
        {
            if (ui.activeSelf)
                ui.SetActive(false);
            else
                ui.SetActive(true);
        }
    }

    public void CreateRandomPet()
    {
        var randomnimal = Random.Range(0, animals.Count);
        animalName1 = animalName.text;
        animals[randomnimal].AnimalName = animalName1;
        outputText.text = animals[randomnimal].Eat();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
