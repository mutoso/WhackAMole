using UnityEngine;

public class Mole : MonoBehaviour
{
    [SerializeField] int score;
    public static float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clicked()
    {
        FindObjectOfType<Score>().increaseScore(score);
        Destroy(gameObject);
    }
}
