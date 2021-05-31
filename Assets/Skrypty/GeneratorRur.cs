using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorRur : MonoBehaviour
{
 public GameObject przeszkoda;

 public float odstep = 7;

 private void Start()
 {
   for (int i = 0 ; i < 3; i++)
   {
       Utworz();
   }
 }

 public void Utworz()
 {
   Instantiate(przeszkoda, new Vector3(odstep, Random.Range(-2.5f, 2.5f), 10), Quaternion.Euler(0,0,0));
   odstep += 7;
 }
}
