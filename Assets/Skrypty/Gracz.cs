using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gracz : MonoBehaviour
{
  float czas = 0;

  public float szybkosc;

  public float wysokosc;

  public bool uderzyl = false;

  private void Update()
  {
      czas += Time.deltaTime;
      GetComponent<Rigidbody2D>().velocity = new Vector2(szybkosc + (czas / 4), GetComponent<Rigidbody2D>().velocity.y);

      if (Input.GetKeyDown(KeyCode.Space))
      {
          GetComponent<Rigidbody2D>().velocity = new Vector2(3, GetComponent<Rigidbody2D>().velocity.y + wysokosc);
      }

      if (transform.position.y > 5)
      {
          transform.position = new Vector2(transform.position.x, 5);
          GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
      }

      if (transform.position.y < -5)
      {
          transform.position = new Vector2(transform.position.x, -5);
          GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
      }
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
      uderzyl = true;
  }

}
