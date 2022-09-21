using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public GameObject Square;

    public static gameManager I;

    void Awake()
    {
        I = this;   
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FallingSquare", 0, 0.5f);//0초 뒤에 0.5초마다 함수실행  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FallingSquare()
    {
        Instantiate(Square);//복제  
    }
}
