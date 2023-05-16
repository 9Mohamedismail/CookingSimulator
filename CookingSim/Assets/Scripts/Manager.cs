using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    [SerializeField] TMP_Text IngredientsTextBox;
    [SerializeField] GameObject firstPage; 
    [SerializeField] GameObject secondPage; 
    [SerializeField] GameObject thirdPage; 
    [SerializeField] GameObject fourthPage; 
    public List<string> SubmittedIngredients = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void submitIngredient(string buttonName)
    {
        SubmittedIngredients.Add(buttonName);
        PrintSubmittedIngredients();
    }

    private void PrintSubmittedIngredients()
    {
        IngredientsTextBox.text = "Submitted Ingredients: " + string.Join(", ", SubmittedIngredients.ToArray());
    }


    public void gotoFirstPage() 
    {
        firstPage.SetActive(true);
        secondPage.SetActive(false);
        thirdPage.SetActive(false);
        fourthPage.SetActive(false);
    }

    public void gotoSecondPage() 
    {
        firstPage.SetActive(false);
        secondPage.SetActive(true);
        thirdPage.SetActive(false);
        fourthPage.SetActive(false);
    }
    
    public void gotoThirdPage() 
    {
        firstPage.SetActive(false);
        secondPage.SetActive(false);
        thirdPage.SetActive(true);
        fourthPage.SetActive(false);
    }

    public void gotoFourthPage() {
        firstPage.SetActive(false);
        secondPage.SetActive(false);
        thirdPage.SetActive(false);
        fourthPage.SetActive(true);
    }
}
