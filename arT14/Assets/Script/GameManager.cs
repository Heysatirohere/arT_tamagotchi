using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public float spawnCooldown = 3f;
   [SerializeField] GameObject obstacle;
    void Start()
    {
        // Dá inicio as chamadas de Spawn
        CallSpawnObject();
    }

    private void Update()
    {
        spawnCooldown -= Time.deltaTime * 0.03f;
       spawnCooldown = Mathf.Clamp(spawnCooldown, 1.2f, 3f);
    }

    // Só chama e inicia o Enumerator (não sei se isso é necessário)
    void CallSpawnObject()
    {
        StartCoroutine(SpawnObject());
    }

    // Substituir pelo método SpawnObject existente*
    IEnumerator SpawnObject()
    {
        yield return new WaitForSeconds(spawnCooldown);
        Instantiate(obstacle);

        // irá causar a chamada de si mesmo, para sempre ficar repetindo
        CallSpawnObject(); 
    }
}
