using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoAlvo : MonoBehaviour
{

    public float velocidade = 10.0f;
    public float velocidadeDeRotacao = 100.0f;

    private Transform transformDoAlvo;

    // Start is called before the first frame update
    void Start()
    {
        transformDoAlvo = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        float translacao = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        float rotacao = Input.GetAxis("Horizontal") * velocidadeDeRotacao * Time.deltaTime;

        transformDoAlvo.Translate(0, 0, translacao);
        transformDoAlvo.Rotate(0, rotacao, 0);

    }
}
