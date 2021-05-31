using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interfejs : MonoBehaviour
{
  public GameObject PanelKoncaGry;

  public TextMeshProUGUI PunktyGora;

  public TextMeshProUGUI PunktyKoniec;

  float punkty;

  Gracz  odnosnikGracz;

  private void Start()
  {
      odnosnikGracz = FindObjectOfType<Gracz>();
      Time.timeScale = 1f;
  }

  private void Update()
  {
      if (odnosnikGracz.uderzyl == true)
      {
          PanelKoncaGry.SetActive(true);
          Time.timeScale = 0f;
          PunktyKoniec.text = "Zdobyte punkty: " + punkty.ToString();
      }
  }

  public void AddPoints()
  {
    punkty++;
    PunktyGora.text = punkty.ToString();
  }

}
