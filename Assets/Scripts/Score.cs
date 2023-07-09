using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI ScoreText;
    private Bowler bowler;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score: " + 0;
        bowler = FindObjectOfType<Bowler>();
    }

    // Update is called once per ball thrown
    public void UpdateScoreText(int x)
    {
        ScoreText.text = "Score: " + x;
    }

}
