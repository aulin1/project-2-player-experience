using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemScript : MonoBehaviour
{
    public string tag;
    public GameObject[] rewards;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        rewards = GameObject.FindGameObjectsWithTag(tag);
        for(int i = 0; i < rewards.Length; i++){
            rewards[i].SetActive(false);
        }
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        Debug.Log("Hello!");
        gameObject.SetActive(false);
        for(int i = 0; i < rewards.Length; i++){
            rewards[i].SetActive(true);
        }
    }
}
