using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carobnjak : MonoBehaviour
{
    int max;
    int min;
    int Pokusaj;
    int maxBrojPokusaja = 10;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1001;
        min = 1;
        NextPokusaj();
    }
    public void pokusajLower()
    {
        max = Pokusaj;
        NextPokusaj();
    }
    public void pokusajHigher()
    {
        min = Pokusaj;
        NextPokusaj();
    }
    void NextPokusaj()
    {
        Pokusaj = Random.Range(min, max + 1);
        text.text = Pokusaj.ToString();
        maxBrojPokusaja = maxBrojPokusaja - 1;
        if (maxBrojPokusaja <= 0)
        {
            Application.LoadLevel("Win");
        }
    }
}
