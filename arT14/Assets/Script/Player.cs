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
        if (hunger <= 0) { Die(); } // se ficar com mt fome, vai de vasco

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
    }

    public void Wash(int cleanessIncrease)
    {
        bath += cleanessIncrease;
    }

    // mt triste vo chora
    public void Die()
    {
        // inserir oq acontece quando morre aq
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
