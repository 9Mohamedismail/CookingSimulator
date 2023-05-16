using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ingredients : MonoBehaviour
{
    [SerializeField] private TMP_Text[] textBoxes;
    [SerializeField] private string[] ingredients;

    private string[] randomizedArray;

    private void Start()
    {
        // Check if the number of available text boxes is less than the length of the ingredients array
        if (textBoxes.Length < ingredients.Length)
        {
            Debug.LogError("Insufficient number of UI TextBoxes!");
            return;
        }

        // Create a copy of the ingredients array to ensure no duplicates are used
        string[] randomizedIngredients = (string[])ingredients.Clone();

        // Randomly assign text to the text boxes from the randomized ingredients array
        randomizedArray = new string[ingredients.Length];
        for (int i = 0; i < ingredients.Length; i++)
        {
            int randomIndex = Random.Range(0, randomizedIngredients.Length);
            textBoxes[i].text = randomizedIngredients[randomIndex];

            randomizedArray[i] = randomizedIngredients[randomIndex];

            // Remove the used ingredient from the randomized ingredients array to avoid duplicates
            randomizedIngredients[randomIndex] = randomizedIngredients[randomizedIngredients.Length - 1];
            System.Array.Resize(ref randomizedIngredients, randomizedIngredients.Length - 1);
        }

        // Print the randomized array to the console
        PrintRandomizedArray();
    }

    private void PrintRandomizedArray()
    {
        if (randomizedArray != null && randomizedArray.Length > 0)
        {
            Debug.Log("Randomized Array:");
            for (int i = 0; i < randomizedArray.Length; i++)
            {
                Debug.Log("Element " + (i + 1) + ": " + randomizedArray[i]);
            }
        }
        else
        {
            Debug.LogError("Randomized Array is empty!");
        }
    }
}
