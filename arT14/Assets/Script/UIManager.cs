using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
  // cria as referencias dos 2 "Text" - vc tem que associá-los pelo inspetor dps
  public Text hungerLevel, happinessLevel, bathLevel;
  GameObject foodPanel;
  // Esse é o seu outro script (o que eu mandei acima), vamos imaginar que ele se chame Player  - Também, você deve referenciá-lo pelo inspetor
  public Player player;


  void Update()
  {
    hungerLevel.text = player.hunger.ToString("F2") + "%";
    happinessLevel.text = player.happiness.ToString("F2") + "%";
    bathLevel.text = player.bath.ToString("F2") + "%";
    
  }
  



}