using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI ScoreText;
    [SerializeField]
    private IntSO scoreSO;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score: " + scoreSO.Value;
    }
}
