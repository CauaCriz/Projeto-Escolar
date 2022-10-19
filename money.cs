using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    public int MoneyPass;
    public GameObject money;
    
    //Use this initialization
    void Start()
    {
        
    }
    
    //Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTrigerEnter(Collider collision)
    {
        if(collision.CompareTag("Money"))
        {
            MoneyPass += 5;
            Debug.Log("Voce agr tem: " + MoneyPass + "de dinheiro");
            Destroy(Money);
        }
    }
}