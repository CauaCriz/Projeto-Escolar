using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    void Update()
    {
    	Save();
    }
    
    public void Save()
    {
    	//Salvando posição X e Y do player
    	PlayerPrefs.SetFloat("X", transform.position.x);
    	PlayerPrefs.SetFloat("Y", transform.position.y);
    
    	PlayerPrefs.SetInt("Money", MoneyPass);
    	PlayerPrefs.SetInt("Score", Score);
    	PlayerPrefs.SetString("UltimaVez", Time.
    }
}