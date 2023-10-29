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
        // D� inicio as chamadas de Spawn
        CallSpawnObject();
    }

    private void Update()
    {
        spawnCooldown -= Time.deltaTime * 0.03f;
       spawnCooldown = Mathf.Clamp(spawnCooldown, 1.2f, 3f);
    }

    // S� chama e inicia o Enumerator (n�o sei se isso � necess�rio)
    void CallSpawnObject()
    {
        StartCoroutine(SpawnObject());
    }

    // Substituir pelo m�todo SpawnObject existente*
    IEnumerator SpawnObject()
    {
        yield return new WaitForSeconds(spawnCooldown);
        Instantiate(obstacle);

        // ir� causar a chamada de si mesmo, para sempre ficar repetindo
        CallSpawnObject(); 
    }
}
