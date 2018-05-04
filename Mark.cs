namespace PlayerController 
{
    using UnityEngine;

    [RequireComponent(typeof(CharacterController))]

    public class Mark : MonoBehaviour 
    {
        AudioSource AmbientSound;

        float forwardMovement = 1.0f;

        float leftMovement = 1.0f;

        float rightMovement = 1.0f;

        float backMovement = 1.0f;

        float Velocidade = 1.0f;

        float VelocidadeGirar = 20.0f;

        KeyCode W = KeyCode.W;

        KeyCode S = KeyCode.S;

        KeyCode R = KeyCode.R;

        KeyCode E = KeyCode.E;

        public GameObject mark;

        public Light LuzPlayer;

        //referencia do script de animacao do player

        MarkAnimando AnimMark;

        CharacterController ControleMark;

        void Awake () 
        {
            //pega o componente de som ambiente

            AmbientSound = GetComponent<AudioSource>();

            //pega a luz do player

            LuzPlayer = GetComponentInChildren<Light>();

            //referencia de script de animacao do player

            AnimMark = GetComponent<MarkAnimando>();

            //seta o character controller

            ControleMark = GetComponent<CharacterController>();
        }

        void Update () 
        {
            //movimentos e giro da camera

            transform.Rotate (0, Input.GetAxis("Horizontal") * VelocidadeGirar *
            Time.deltaTime, 0);

            Vector3 forward = transform.TransformDirection (Vector3.forward);

            //rotacao pelas teclas A e D, e setas direcionais

            float VelocidadeGiro = Velocidade * Input.GetAxis ("Vertical");

            ControleMark.SimpleMove (forward * VelocidadeGiro);

            ControleMark.enabled = true;

            ControleMark.detectCollisions = true;

            //se o character controller esta no chao, a gravidade e inativa

            if (ControleMark.isGrounded) 
            {
                //pressionando w faz o Mark andar para frente

                if (Input.GetKey(W)) 
                {
                    Vector3 position = transform.TransformDirection (Vector3.forward *
                    forwardMovement * Time.deltaTime);
                }

                //pressionando s faz o Mark andar para tras

                else if (Input.GetKey(S)) 
                {
                    Vector3 position = transform.TransformDirection (Vector3.back *
                    backMovement * Time.deltaTime);
                }

                //Controla a ativacao da luz do Mark
                //fazendo ela desligar e ligar

                if (Input.GetKeyDown(E)) 
                {
                    LuzPlayer.enabled = !LuzPlayer.enabled;
                }

                //faz o Mark correr

                if (Input.GetKeyDown(R)) 
                {
                    Velocidade = Input.acceleration.x * 60.0f * Time.deltaTime;
                } 
                
                else 
                {
                    Velocidade = 3.0f;
                }
            }
        }
    }
}