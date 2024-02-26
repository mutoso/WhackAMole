using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    float elapsed;
    float timeBetweenSpawns = 3.0f;
    [SerializeField] GameObject mole;
    Canvas canvas;
    Score score;
    // Start is called before the first frame update
    void Start()
    {
        canvas = FindObjectOfType<Canvas>();
        Mole.lifetime = 5.0f;
        score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        // Every 5 points
        if (score.Value > 0 && score.Value % 5 == 0)
        {
            // Decrease lifetime by 0.2
            Mole.lifetime -= 0.2f;
            // but cap it at a minimum of 1 second lifetime
            Mole.lifetime = Mathf.Max(1, Mole.lifetime);

            // Decrease time between spawns by 0.5
            timeBetweenSpawns -= 0.5f;
            // but cap it at a minimum of 0.5 second lifetime
            timeBetweenSpawns = Mathf.Max(0.5f, timeBetweenSpawns);
        }

        elapsed += Time.deltaTime;
        if (elapsed >= timeBetweenSpawns)
        {
            var moleWidth = mole.GetComponent<RectTransform>().sizeDelta.x;
            var moleHeight = mole.GetComponent<RectTransform>().sizeDelta.y;
            var canvasWidth = canvas.pixelRect.size.x;
            var canvasHeight = canvas.pixelRect.size.y;
            var x = Random.Range(0 + (moleWidth / 2), canvasWidth - (moleWidth / 2));
            var y = Random.Range(0 + (moleHeight / 2), canvasHeight - (moleHeight / 2));
            Instantiate(mole, new Vector3(x, y, 0), Quaternion.identity, canvas.transform);
            elapsed = 0.0f;
        }
    }
}
