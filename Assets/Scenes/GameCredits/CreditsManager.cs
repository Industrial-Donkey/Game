using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreditsManager : MonoBehaviour
{
    public Camera camera;
    public TextAsset creditsTextFile;
    public TMP_FontAsset font;
    public float timePerSection = 8f;
    public float fadeSpeed = 1f;
    public char sectionDeliminator = '#';

    private string contents;
    private float timeSinceLastTransition = 0.0f;
    private int sectionInView = 0;
    private List<string> contentChunks;

    private GameObject canvasGameObject;

    private Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        contents = creditsTextFile.text;

        contentChunks = new List<string>();
        contentChunks.AddRange(contents.Split(sectionDeliminator));

        // Setup the canvas
        canvasGameObject = new GameObject();
        canvasGameObject.name = "CreditsCanvas";
        canvasGameObject.AddComponent<Canvas>();
        canvasGameObject.AddComponent<CanvasScaler>();
        canvasGameObject.AddComponent<GraphicRaycaster>();
        canvasGameObject.transform.SetParent(this.gameObject.transform);

        canvas = canvasGameObject.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        canvas.worldCamera = camera;
        
        GameObject textObject = new GameObject("Text");
        TextMeshPro chunkText = textObject.AddComponent<TextMeshPro>();
            
        chunkText.text = "An Industrial Donkey Production";
        chunkText.fontSize = 12;
        chunkText.font = font;
        chunkText.alignment = TextAlignmentOptions.Center;

        RectTransform rectTransform = chunkText.GetComponent<RectTransform>();
        rectTransform.localPosition.Set(0,0,0);
        rectTransform.sizeDelta.Set(400, 200);
        rectTransform.localScale.Set(1, 1, 1);

        chunkText.enabled = true;

        textObject.transform.SetParent(canvasGameObject.transform);

    }

    // Update is called once per frame
    void Update() {

    }
}
