using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public GameObject Square;
    public Text TimeText;
    public Text EndText;

    public static gameManager I;

    float time = 0.00f;

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
        time += Time.deltaTime;
        TimeText.text = time.ToString("N2");
    }

    public void Stop()
    {
        Time.timeScale = 0.00f;
        EndText.gameObject.SetActive(true);
    }

    void FallingSquare()
    {
        Instantiate(Square);//복제  
    }
}
