using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour {

    public GameObject[] rat;
    Transform spawnPoint;
    GameObject selectCharacterMenu;
    
    
    private void Start()
    {
        spawnPoint = GameObject.Find("RatSpawnPoint").GetComponent<Transform>();
        Time.timeScale = 0;
        selectCharacterMenu = GameObject.Find("SelectCharacterMenu");
    }
    private void Update()
    {
           
    }
    public void Rat1()
    {
        Time.timeScale = 1;
        Instantiate(rat[0], spawnPoint.transform.position, spawnPoint.transform.rotation);
        selectCharacterMenu.SetActive(false);
    }

    public void Rat2()
    {
        Time.timeScale = 1;
        Instantiate(rat[1], spawnPoint.transform.position, spawnPoint.transform.rotation);
        selectCharacterMenu.SetActive(false);
    }

    public void Rat3()
    {
        Time.timeScale = 1;
        Instantiate(rat[2], spawnPoint.transform.position, spawnPoint.transform.rotation);
        selectCharacterMenu.SetActive(false);
    }
}
