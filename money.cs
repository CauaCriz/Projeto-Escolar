using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    public int MoneyPass = 0;
    
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
        if(CompareTag("Money"))
        {
            MoneyPass += 5;
            Debug.Log("Voce agr tem: " + MoneyPass + "de dinheiro");
            Destroy(collision);
        }
    }
}