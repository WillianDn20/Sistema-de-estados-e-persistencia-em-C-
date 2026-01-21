using UnityEngine;

public class Item : MonoBehaviour
{
    public ScriptableObjs_Esferas tipo;

    private void Start()
    {
        GetComponent<Renderer>().material.color = tipo.cor;

        transform.localScale = tipo.escala;

        //Debug.Log("Tipo:" + tipo.tipo);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameController.Instance.AlterarPontos(tipo.ponto);
            GameController.Instance.adicionarItem(tipo.tipo);


            Destroy(this.gameObject);
        }
    }

}
