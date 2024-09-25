using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public static int maxlife = 4;
    public int life = maxlife;
    public GameObject[] Hearthlist = new GameObject[maxlife];
    public GameObject[] Canvas = new GameObject[2];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void lifeLoss(int loss)
    {
        if (life > 1)
        {
            life -= loss;
        }
        else
        {
            Canvas[0].SetActive(false);
            Canvas[1].SetActive(true);
        }
    }

    public void lifeGain(int Gain)
    {
        if (life < maxlife)
        {
            life += Gain;
        }
    }

    public void updateLifeUI(int life)
    {
        foreach (GameObject Hearth in Hearthlist)
        {
            Hearth.SetActive(false);
        }

        for (int i = 0; i < life; i++)
        {
            Hearthlist[i].SetActive(true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            lifeLoss(1);
            Debug.Log(gameObject.name + " has hit " + collision.gameObject.name);
            updateLifeUI(life);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("health"))
        {
            lifeGain(1);
            Debug.Log(gameObject.name + " has hit " + collision.gameObject.name);
            updateLifeUI(life);
        }
    }
}


