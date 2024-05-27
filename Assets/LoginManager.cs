using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoginManager : MonoBehaviour
{

    public InputField Input_Password;
    string contraseña = "kevin";
    // Start is called before the first frame update
    public void BotonPresionar()
    {
        if (Input_Password.text == contraseña)
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }
    }
}
