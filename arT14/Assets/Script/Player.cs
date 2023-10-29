using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float hunger = 100f;
    public float happiness = 100f;
    public float bath = 100f;

        public void Start()
    {
        LoadGame();
        InvokeRepeating("SaveGame", 1, 30);
    }
    void Update()

    {
            bath = Mathf.Clamp(bath, 0, 100);
            hunger = Mathf.Clamp(hunger, 0, 100);
            happiness = Mathf.Clamp(happiness, 0, 100);

            if (hunger <= 0) Die();  // se ficar com mt fome, vai de vasco

        hunger -= 0.25f * Time.deltaTime; // diminui o valor de "fome" um pouquinho a cada segundo

        happiness -= 0.25f * Time.deltaTime; // mesma coisa da fome, diminui a felicidade cada segundo (tipo na minha vida)
        bath -= 0.25f * Time.deltaTime;
    }

    // esse método pode ser acessado através de um botão na UI, que chama ele pelo EventSystem
    public void Eat(int calories)
    {
        // passa um valor a ser adicionado a sua "fome" (cada comida pode ter um valor, por exemplo)
        hunger += calories;
        if (hunger > 100f)
            hunger = 100f;
    }

    public void Play(int happinessIncrease)
    {
        // passa um valor a ser adicionado na felicidade quando vc brinca com o bicho
        happiness += happinessIncrease;
        if (happiness > 100f)
            happiness = 100;
        SaveGame();
    }

    public void Wash(int cleanessIncrease)
    {
        bath += cleanessIncrease;
        if (bath > 100f)
            bath = 100f;

        SaveGame();
    }

    // mt triste vo chora
    public void Die()
    {

        PlayerPrefs.SetFloat("hunger", 100f);
        PlayerPrefs.SetFloat("bath", 100f);
        PlayerPrefs.SetFloat("happiness", 100f);

        GetComponent<LoadScene>().Load("Die"); 
    }
    public void SaveGame()
    {

        PlayerPrefs.SetFloat("hunger", hunger);
        PlayerPrefs.SetFloat("bath", bath);
        PlayerPrefs.SetFloat("happiness", happiness);
    

    }
    

    public void LoadGame()
    {
        hunger = PlayerPrefs.GetFloat("hunger");
        bath = PlayerPrefs.GetFloat("bath");
        happiness = PlayerPrefs.GetFloat("happiness");

    }
    
}
