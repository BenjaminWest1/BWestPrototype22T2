using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubbishBag : MonoBehaviour
{
    public GameObject flower;

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
        Instantiate(flower, this.transform.parent.position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0))).transform.SetParent(null);
        gameObject.transform.parent.parent.gameObject.SetActive(false);
        FindObjectOfType<ScoreScript>().UpdateScore(1);
    }
}
