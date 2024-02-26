using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int Value { get { return score; } }
    int score;
    [SerializeField] TMP_Text scoreText;

    public void increaseScore(int amount)
    {
        score += amount;
        updateText();
    }

    void updateText()
    {
        scoreText.text = score.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        updateText();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
