using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDeEnemigos : MonoBehaviour
{
    public GameObject zombiePrefab;
    public Transform[] puntosDeSpawn;
    public float tiempoDeSpawns = 6f;
    // Start is called before the first frame update
    void Start()
    {
        puntosDeSpawn = new Transform[transform.childCount];
        for(int i=0; i<transform.childCount; i++)
        {
            puntosDeSpawn[i] = transform.GetChild(i);
        }

        StartCoroutine(SpawnearEnemigo());
    }

    IEnumerator SpawnearEnemigo()
    {
        while (true)
        {
            for (int i = 0; i < puntosDeSpawn.Length; i++)
            {
                Transform puntoDeSpawn = puntosDeSpawn[i];
                Instantiate(zombiePrefab, puntoDeSpawn.position, puntoDeSpawn.rotation);
            }
            yield return new WaitForSeconds(tiempoDeSpawns);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
