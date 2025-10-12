using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueText : MonoBehaviour
{
    public int SkipTime = 5;
    public GameObject canvas;
    public string Greeting = "Enter Greeting Here";
    public string Directions = "Enter Directions Here";

    private TextMeshProUGUI TextBox;

    private void OnEnable()
    {
        if (GetComponent<TextMeshProUGUI>() != null)
        {
            TextBox = GetComponent<TextMeshProUGUI>();
        }


        TextBox.text = Greeting;
        StartCoroutine(SkipToDirections(SkipTime));
    }
     private IEnumerator SkipToDirections(int delay)
    {

        yield return new WaitForSeconds(delay);
        TextBox.text = Directions;
        StartCoroutine(DisableDialogue(SkipTime));
    }

    private IEnumerator DisableDialogue(int delay)
    {
        yield return new WaitForSeconds(delay);
       canvas.SetActive(false);
        

    }

   

}