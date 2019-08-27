using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoSala : MonoBehaviour
{
    [SerializeField]
    Sino sino;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        if(sino.IsRunning())
        {
            print("Ativou o botao");
            // abrir sala ou realizar alguma alção

        }
        else
        {
            return;
        }

    }

    
}
