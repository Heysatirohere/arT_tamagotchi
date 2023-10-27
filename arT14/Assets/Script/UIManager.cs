using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

  public Text hungerLevel, happinessLevel, bathLevel;
  GameObject foodPanel;
 
  public Player player;

  void Update()
  {
    hungerLevel.text = player.hunger.ToString("F1") + "%";
    happinessLevel.text = player.happiness.ToString("F1") + "%";
    bathLevel.text = player.bath.ToString("F1") + "%";
    
  }
  
}