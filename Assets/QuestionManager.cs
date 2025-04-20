using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public GameObject feedbackText;
    public Text feedbackTextComponent;

    public void CheckAnswer(string answer)
    {
        if (answer == "Paris")
        {
            feedbackText.SetActive(true);
            feedbackTextComponent.text = "Tebrikler! Doðru cevap.";
        }
        else
        {
            feedbackText.SetActive(true);
            feedbackTextComponent.text = "Yanlýþ cevap, tekrar dene!";
        }
    }
}