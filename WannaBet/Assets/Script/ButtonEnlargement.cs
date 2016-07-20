using UnityEngine;
using System.Collections;

public class ButtonEnlargement : MonoBehaviour {
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Enlarge()
    {
        RectTransform RectTransform = gameObject.GetComponent<RectTransform>();
        RectTransform.anchorMin -= new Vector2(0.005f, 0);
        RectTransform.anchorMax += new Vector2(0.005f, 0);
    }
}
