using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] int guess;
    [SerializeField] TextMeshProUGUI guesstext;
    [SerializeField] Sprite penguin;
    [SerializeField] Sprite penguin2;
    float degreesPerSecond = 20;

    // Start is called before the first frame update
    void Start()
    {
      min = 0;
      max = 100;
      guess = (min + max) / 2;
      guesstext.text = guess.ToString();
        Vector3 newPosition = new Vector3(0, 0, 60);
     
    }

    private void Vector3(int v1, int v2, int v3)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);


    }

    // Higher Button
    public void higherbutton()
    {
        min = guess;
        guess = (min + max) / 2;
        guesstext.text = guess.ToString();
    }
    public void lowerBtn()
    {
        max = guess;
        guess = (min + max) / 2;
        guesstext.text = guess.ToString();
    }
    public void correctBtn()
    {
        guesstext.text = "Im the best guesser in existance";
    }
    



}
