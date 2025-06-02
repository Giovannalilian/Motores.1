using UnityEngine;

public class Play : MonoBehaviour
{

    public float velocidade = 40;

    void Start()
    {

    }

    void Update()
    {
        //debug.log(numero0;
        //numero = numero + 1;

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(+velocidade * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0,forcaDoPulo), ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        //if (colisao.gameObject.tag == "Chao")
        if(colisao.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }
    }

    void OnCollisionExit2D(Collision2D colisao)
    {
        if(colisao.gameObject.CompareTag("Chao"))
        {
            noChao = false;
        }
    }
}