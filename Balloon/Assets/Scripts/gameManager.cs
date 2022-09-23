using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public GameObject Square;
    public Text TimeText;
    public Text EndText;

    public Animator anim;
    public GameObject Balloon;

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
        anim.SetBool("isDie", true);
        EndText.gameObject.SetActive(true);
        Invoke("dead", 0.5f) ;
    }

    void FallingSquare()
    {
        Instantiate(Square);//복제  
    }

    void dead()
    {
        Time.timeScale = 0.00f;
        Destroy(Balloon);
    }
}
