using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    private int pontos;
    public int PontosTotais
    {
        get { return pontos; }

    }

    private int itens;
    public int ItensTotais
    {
        get { return itens; }

    }

    private int vida;

    public int VidaAtual
    {
        get { return vida; }

    }

    public Transform JogadorPos; //Referencia ao gameobject que vai pegar o transform

    public Text txtPontuacao; //Referencia TextMeshPro

    public Button btnSalvarTudo; //Referencia ao botao
    public Button btnCarregar;
    public Button btnReset;

    public int itensVerdesCount;
    public int itensRosasCount;
    public int itensVermelhoCount;



    private void Awake() //É executada antes do Start
    {
        Instance = this; //Declara a instancia

        DontDestroyOnLoad(gameObject); //Impede que a instancia seja destruida 
    }

    private void Start()
    {
        txtPontuacao.text = ("Pontuação: " + PontosTotais);

    }

    private void Update()
    {

        txtPontuacao.text = ("Pontuação: " + PontosTotais);
       
    }
    public void AlterarPontos(int ponto) //Funcao publica que pode ser chamada por outro script e obrigado ao script a dizer quantos pontos
    {
        pontos = pontos + ponto; //soma da pontuacao atual mais a informada por quem chamou a funcao
        txtPontuacao.text = "Pontos: " + pontos; //Atualizada o textmesh com a pontuacao atual
    }

    public void adicionarItem(string tipo)
    {
        if (tipo == "Verde")
        {
            itensVerdesCount++;
            itens++;
            Debug.Log("Itens verdes" + itensVerdesCount);
            Debug.Log("Itens totais" + ItensTotais);
        }
        else if (tipo == "Rosa")
        {
            itensRosasCount++;
            itens++;
            Debug.Log("Itens rosas" + itensRosasCount);
            Debug.Log("Itens totais" + ItensTotais);
        }
        else if (tipo == "Vermelho")
        {
            itensVermelhoCount++;
            itens++;
            vida--;
            Debug.Log("Itens vermelhos" + itensVermelhoCount);
            Debug.Log("Itens totais" + ItensTotais);
            Debug.Log("Vida: " + VidaAtual);
        }
    }

    public void SalvarTudo()
    {
        int vidaPF = vida;
        PlayerPrefs.SetInt("vida", vidaPF);

        int itemPF = itens;
        PlayerPrefs.SetInt("item", itemPF);

        int pontosPF = pontos;
        PlayerPrefs.SetInt("pontos", pontosPF);

        float posX = JogadorPos.position.x;
        PlayerPrefs.SetFloat("posX", posX);
        float posY = JogadorPos.position.y;
        PlayerPrefs.SetFloat("posY", posY);
        float posZ = JogadorPos.position.z;
        PlayerPrefs.SetFloat("posZ", posZ);

        Debug.Log("Salvando");
    }

    public void Carregar()
    {
        float posXC = PlayerPrefs.GetFloat("posX");
        float posYC = PlayerPrefs.GetFloat("posY");
        float posZC = PlayerPrefs.GetFloat("posZ");
        JogadorPos.position = new Vector3(posXC, posYC, posZC);

        vida = PlayerPrefs.GetInt("vida");
        itens = PlayerPrefs.GetInt("item");
        pontos = PlayerPrefs.GetInt("pontos");

        Debug.Log("Carregando");
    }

    public void Resetar()
    {
        PlayerPrefs.SetInt("vida", 0);
        vida = PlayerPrefs.GetInt("vida");

        PlayerPrefs.SetInt("itens", 0);
        itens = PlayerPrefs.GetInt("itens");

        PlayerPrefs.SetInt("pontos", 0);
        pontos = PlayerPrefs.GetInt("pontos");

        PlayerPrefs.SetInt("itensVermelhos", 0);
        itensVermelhoCount = PlayerPrefs.GetInt("itensVermelhos");

        PlayerPrefs.SetInt("itensRosas", 0);
        itensRosasCount = PlayerPrefs.GetInt("itensRosas");

        PlayerPrefs.SetInt("itensVerdes", 0);
        itensVerdesCount = PlayerPrefs.GetInt("itensVerdes");


        int pontosPF = pontos;
        PlayerPrefs.SetInt("pontos", pontosPF);

        float posXR = 0;
        PlayerPrefs.SetFloat("posX", posXR);
        float posYR = 1;
        PlayerPrefs.SetFloat("posY", posYR);
        float posZR = 0;
        PlayerPrefs.SetFloat("posZ", posZR);

        JogadorPos.position = new Vector3(posXR, posYR, posZR);

        Debug.Log("Resetando");

    }

}
