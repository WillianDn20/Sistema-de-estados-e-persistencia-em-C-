using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 5f; //Float com a velocidade do jogador
    Rigidbody rb; //Referencia Rigidbody
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        float eixoX = Input.GetAxis("Horizontal"); //Pega  input do jogador de a e d 
        float eixoZ = Input.GetAxis("Vertical"); //Pega  input do jogador de w e s 

        Vector3 movimento = new Vector3(eixoX, 0f, eixoZ) * velocidade;

        rb.linearVelocity = new Vector3(movimento.x, 0, movimento.z);
    }
}
