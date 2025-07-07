using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    // Start is called before the first frame update
    public int velocidade = 10;
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector2(x * velocidade, y * velocidade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision hit) 
    {
        if (hit.gameObject.name == "esquerda")
        {
            transform.position = new Vector3(-0.3999996f, 1.62f, 5.65f);
            Start();
        }
    }
}
