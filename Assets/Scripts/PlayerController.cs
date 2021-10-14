using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movimentacao
    public float Velocidade;
    private float _Velocidade;

    public Rigidbody projectile;
    public Transform Spawnpoint;

    Rigidbody clone;

    void Start()
    {

    }

    void FixedUpdate()
    {
        _Velocidade = Velocidade;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveHorizontal != 0 && moveVertical != 0)
        {
            _Velocidade = Velocidade / 1.5f;
        }

        //direita
        if (moveHorizontal > 0.2)
        {
            transform.Translate(Vector3.right * Time.deltaTime * _Velocidade, Space.World);
            //animationController.PlayAnimation(EstadosAnimacao.CaminhandoDireita);
        }
        //esquerda
        else if (moveHorizontal < -0.2)
        {
            transform.Translate(Vector3.left * Time.deltaTime * _Velocidade, Space.World);
            // animationController.PlayAnimation(EstadosAnimacao.CaminhandoEsquerda);
        }

        //frente/cima
        if (moveVertical > 0.2)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _Velocidade, Space.World);
            // animationController.PlayAnimation(EstadosAnimacao.CaminhandoCima);
        }
        //tras/baixo
        else if (moveVertical < -0.2)
        {
            transform.Translate(Vector3.back * Time.deltaTime * _Velocidade, Space.World);
            // animationController.PlayAnimation(EstadosAnimacao.CaminhandoBaixo);
        }

        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    // animator.SetBool("SocoBaixo", true);
        //    taxaAtaqueAtual += Time.deltaTime;

        //    if (taxaAtaqueAtual > taxaAtaque)
        //    {
        //        taxaAtaqueAtual = 0;
        //        //animationController.atacar(ataque)
        //    }
        //}
        //else
        //{
        //    animator.SetBool("SocoBaixo", false);

        //}

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectile, new Vector3(Spawnpoint.position.x, transform.position.y, Spawnpoint.position.z), projectile.rotation);
        }
    }
}
