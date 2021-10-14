using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class IAInimigoBehaviour : MonoBehaviour
{

    public float Vida;
    public float Velocidade;
    public List<Transform> Caminho;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Caminho.FirstOrDefault().position;
    }



    // Update is called once per frame
    //deve sempre mover para o ponto mais proximo a base inimiga
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Caminho.LastOrDefault().position, Time.deltaTime * Velocidade);
    }
}
