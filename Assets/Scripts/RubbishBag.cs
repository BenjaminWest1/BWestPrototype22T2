using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubbishBag : MonoBehaviour
{
    public ScoreScript score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("hit" + this.transform.parent.parent.name);
        gameObject.transform.parent.parent.gameObject.SetActive(false);
        FindObjectOfType<ScoreScript>().UpdateScore(1);
    }
}
