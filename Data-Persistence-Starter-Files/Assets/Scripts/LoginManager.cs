using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginManager : MonoBehaviour
{
    
    public TMP_InputField nameInput;
    


    public void PlayButton()
    {
        string name = nameInput.text;

        if ( !string.IsNullOrEmpty(name))
        {
            PlayerData newPlayerData = new PlayerData(name);
            SaveSystem.SavePlayer(newPlayerData);
        }
        

        SceneManager.LoadScene(1);

    }
}
