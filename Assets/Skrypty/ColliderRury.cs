using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderRury : MonoBehaviour
{
  GeneratorRur odnosnikRury;
  Interfejs odnosnikPkt;

  private void Start()
  {
      odnosnikRury = FindObjectOfType<GeneratorRur>();
      odnosnikPkt = FindObjectOfType<Interfejs>();
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    odnosnikRury.Utworz();
    odnosnikPkt.AddPoints();
  }

}
