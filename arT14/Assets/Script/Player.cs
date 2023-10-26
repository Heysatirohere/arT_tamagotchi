using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float hunger = 100;
    public float happiness = 100;

    public float bath = 100; 

    void Update()

    {
            if(hunger <= 0) { Die(); } // se ficar com mt fome, vai de vasco

            hunger -= 0.1f * Time.deltaTime; // diminui o valor de "fome" um pouquinho a cada segundo

            happiness -= 0.1f * Time.deltaTime; // mesma coisa da fome, diminui a felicidade cada segundo (tipo na minha vida)
            bath -= 0.1f * Time.deltaTime; 
            }

            // esse método pode ser acessado através de um botão na UI, que chama ele pelo EventSystem
            public void Eat(int calories)
            {
            // passa um valor a ser adicionado a sua "fome" (cada comida pode ter um valor, por exemplo)
            hunger += calories;
            }

        public void Play(int happinessIncrease)
        {
            // passa um valor a ser adicionado na felicidade quando vc brinca com o bicho
            happiness += happinessIncrease;
        }

        // mt triste vo chora
        public void Die()
        {
        // inserir oq acontece quando morre aq
        }
        }
