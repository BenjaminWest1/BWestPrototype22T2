using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubbishBagManager : MonoBehaviour
{
    public GameObject[] bags;
    private int amountOfBags = 26;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnIn()
    {
        System.Collections.Generic.List<GameObject> list = new System.Collections.Generic.List<GameObject>(bags);

        for(int i = 0; i <= amountOfBags; i++)
        {
            int randomNum = Random.Range(0, list.Count);
            list[randomNum].SetActive(true);
            Debug.Log("Spawning bag number:" + i + ", name:" + list[randomNum]);

            list.Remove(list[randomNum]);
        }
    }
}
