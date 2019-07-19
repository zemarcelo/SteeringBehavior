/// <summary>
/// Classe Implementadora dos Steering Bevaiors
/// </summary>
/// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringBehavior : MonoBehaviour
{
    //Parametros de movimento
    public float massa = 1.0f;
    public float forca_Max = 0.5f;
    public float velocidade_Max = 1.0f;

    private Transform agente;
    private Vector3 posicao = new Vector3();
    private Vector3 velocidade = new Vector3();

    //steering


    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<Transform>();
        posicao = agente.position;

    }

    // Update is called once per frame
    void Update()
    {
        Move(Steering());
        agente.position = posicao;
    }

    void Move(Vector3 direcao)
    {

        Vector3 forca_De_Steering = direcao.normalized * Mathf.Min(direcao.magnitude, forca_Max);
        Vector3 aceleracao = forca_De_Steering / massa;
        velocidade = velocidade + aceleracao;
        velocidade = velocidade.normalized * Mathf.Min(velocidade.magnitude, velocidade_Max);
        posicao = posicao + velocidade * Time.deltaTime;

    }

    Vector3 Steering()
    {
        return new Vector3(0, 0, 1);

    }

}
