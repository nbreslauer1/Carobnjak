using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Carobnjak : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int Pokusaj;
    int maxBrojPokusaja = 10;
    public Text text;
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
