using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squares : MonoBehaviour 
{
    int type;
    float size;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.7f, 2.7f);
        float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);

        type = Random.Range(1, 6);

        if (type == 1)
        {
            size = 0.6f;

            GetComponent<SpriteRenderer>().color = new Color(255.0f / 255.0f, 0, 0, 255.0f / 255.0f);
        }
        else if (type == 2)
        {
            size = 1.0f;

            GetComponent<SpriteRenderer>().color = new Color(255.0f / 255.0f, 130.0f / 255.0f, 0, 255.0f / 255.0f);
        }
        else if (type == 3)
        {
            size = 1.2f;

            GetComponent<SpriteRenderer>().color = new Color(255.0f / 255.0f, 255.0f / 255.0f, 0, 255.0f / 255.0f);
        }
        else if (type == 4)
        {
            size = 1.5f;

            GetComponent<SpriteRenderer>().color = new Color(130.0f / 255.0f, 255.0f / 255.0f, 0, 255.0f / 255.0f);
        }
        else
        {
            size = 1.7f;

            GetComponent<SpriteRenderer>().color = new Color(0, 0, 255.0f / 255.0f, 255.0f / 255.0f);
        }

        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.0f) //박스가 화면 밖으로 사라지면 
            Destroy(gameObject); // 박스 오브젝트 소멸
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "balloon")
        {
            gameManager.I.gameover();
        }
    }


}
