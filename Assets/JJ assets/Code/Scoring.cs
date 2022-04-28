using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Transform playerMove;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerMove.position.x.ToString("0");
    }
}
