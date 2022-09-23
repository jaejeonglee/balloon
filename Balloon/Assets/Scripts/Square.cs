using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    //변수 선언 
    int Type;
    float Size;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.7f, 2.7f);
        float y = Random.Range(3.0f, 5.0f);
        transform.position = new Vector3(x, y, 0);

        //타입을 랜덤으로 1~3 
        Type = Random.Range(1, 4);

        if (Type == 1)
        {
            Size = 1.3f;

        }
        else if (Type == 2)
        {
            Size = 1.0f;

        }
        else
        {
            Size = 0.7f;

        }
        //스케일을 바꾼다
        transform.localScale = new Vector3(Size, Size, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    //collider 이벤트
    //void OnCollisionEnter2D(Collision2D coll)
    //{
    //    if (coll.gameObject.tag == "Circle")
    //    {
    //        Debug.Log("동그라미!");
    //    }
    //    if (coll.gameObject.tag == "Balloon")
    //    {
    //        Debug.Log("풍선!");
    //    }
    //}
}
