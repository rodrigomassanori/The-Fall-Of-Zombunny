namespace PlayerController
{
    using UnityEngine;

    public class MarkAnimando : MonoBehaviour
    {
        //referencia do script do player

        Mark Player;

        Vector3 animacao;

        Animator PlayerAC2;

        Rigidbody rb;

        float Velocidade = 1.0f;

        void Awake()
        {
            //referencia para pegar o animator do Mark

            PlayerAC2 = GetComponent<Animator>();

            //referencia para pegar o collider do Mark

            rb = GetComponent<Rigidbody>();

            //referencia para pegar o script de movimento do Mark

            Player = GetComponent<Mark>();
        }

        void FixedUpdate()
        {
            float h = Input.GetAxis("Horizontal");

            float v = Input.GetAxis("Vertical");

            Mover(h, v);

            Animando(h, v);
        }

        //tempo para animacao em cada plataforma

        void Mover(float h, float v)
        {
            animacao.Set(h, 1.0f, v);

            animacao = animacao.normalized * Velocidade * Time.deltaTime;

            rb.MovePosition(transform.position + animacao);

            rb.useGravity = true;
        }

        //animacao por Boolean

        void Animando(float h, float v)
        {
            bool andar;

            andar = h != 0.0f || v != 0.0f;

            PlayerAC2.SetBool("Walking", andar);
        }
    }
}