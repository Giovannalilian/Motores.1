using UnityEngine;

public class Play : MonoBehaviour
{

    public float velocidade = 40;

    private Rigidbody2D rb;

    private bool  noChao = false;
    public float forcaDoPulo = 3;
    
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
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

        if (Input.GetKey(KeyCode.Space) && noChao == true)
        {
            float forcaDoPulo = 3;
            rb.AddForce(new Vector2(0,y: forcaDoPulo), ForceMode2D.Impulse);
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
