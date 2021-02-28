using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NumberWizard : MonoBehaviour
{
   [SerializeField] int max;
   [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

   
   int guess;
   // public UnityEngine.UI.Button yourButton;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        NextGuess();
        Random.Range(min, max);
       
       
        //max = max + 1;
    }

    void NextGuess()
    {
       // StartGame();
       
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    /*  if(guess < max)
        {
          
            guess++;
           
        } if( guess > min)
        {
            guess--;
           
            
        }*/
       // Debug.Log("Is it higher or lower than..." + guess);
    }

    public void OnPressHigher()
    {
       
        min = guess;
       // Random.Range(min, max);
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
       // Random.Range(min, max);
        NextGuess();
    }


    // Update is called once per frame

    /*  if (Input.GetKeyDown(KeyCode.UpArrow))
      {
          min = guess;
          NextGuess();
      }
      else if (Input.GetKeyDown(KeyCode.DownArrow))
      {
          max = guess;
          NextGuess();
      }
      else if (Input.GetKeyDown(KeyCode.Return))
      {
          Debug.Log("I am a genius!");
          StartGame();
      }
  }
  void NextGuess()
  {
      guess = (max + min) / 2;
      Debug.Log("Is it higher or lower than..." + guess);
  }*/
}


