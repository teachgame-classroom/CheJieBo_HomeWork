using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork_190327 : MonoBehaviour
{
    private GameObject playerPrefab;
    private GameObject player;

    void Start()
    {
        playerPrefab = Resources.Load<GameObject>("Player");
        System.IO.File.Create(Application.persistentDataPath + "/" + "war4.sav");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player = (GameObject)Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += player.transform.forward * 10 * Time.deltaTime;
        }
    }
}
