using UnityEngine;
using UnityEngine.UI;

public class TempoJogo : MonoBehaviour
{
    public Text tempoJogo;

    float tempoCronometro = 0f;

    void Update()
    {
        tempoCronometro += Time.deltaTime;

        int segundos = Mathf.FloorToInt(tempoCronometro % 60);
        segundos.ToString();

        tempoJogo.text = "Tempo de jogo " + segundos + " segundos";
        
    }

}
