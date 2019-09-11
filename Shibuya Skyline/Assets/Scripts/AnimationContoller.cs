using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class AnimationContoller : MonoBehaviour
{
    [Space]
    public GameObject Perent;
    public GameObject The_Camera;
    public GameObject Dramatic_Bars;
    public GameObject RagDoll;
    public GameObject Player;
    [Space]
    public Animator Animator;
    [Space]
    public Bullet_Time Bullet_Time;
    [Space]
    [Range(0f, 100f)]
    public float Walking_Speed;
    [Range(0f, 100f)]
    public float Running_Speed;
    [Space]
    public bool On_Floor;
    public bool Walking;
    public bool Running;
    [Space]
    public bool Idle_Jump;
    public bool Walk_Jump;
    public bool Run_Jump;
    [Space]
    public bool Run_Vault;
    public bool Run_Tall_Vault;
    [Space]
    public bool Run_Climb;
    [Space]
    public bool Vault_Enabled;
    public bool Climb_Enabled;
    public bool Tall_Vault_Enabled;
    [Space]
    public bool Slide;
    [Space]
    public bool Sprint_check;
    public bool Jump_Check;
    private bool Fall_Check_bool;
    public bool Combat_Roll_Checker;
    public bool Death_Timer = false;
    public bool Time_Check = false;
    private bool Ctrl_Check;
    private bool NOKILL;
    private bool cansprint;

    // Use this for initialization
    void Start()
    {
        //Camera_Stable = GetComponent<Camera_Stable>();
        Animator.SetBool("Falling", false);
        Perent.SendMessage("Running_Speed", Running_Speed);
        Perent.SendMessage("Walking_Speed", Walking_Speed);
    }

    // Update is called once per frame
    public void Update()
    {
        if (Slide == true)
        {
            Fall_Check_bool = false;
        }
        if (Input.GetKeyDown("a"))
        {
            Walk_Left_On();
        }
        if (Input.GetKeyUp("a"))
        {
            Walk_Left_Off();
        }
        if (Input.GetKeyDown("d"))
        {
            Walk_Right_On();
        }
        if (Input.GetKeyUp("d"))
        {
            Walk_Right_Off();
        }
        if (Input.GetKeyDown("s"))
        {
            Walk_Back_On();
        }
        if (Input.GetKeyUp("s"))
        {
            Walk_Back_Off();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && cansprint == true || Input.GetKeyDown("joystick button 4")&& cansprint == true)
        {
            Sprint_check = true;
            WalkOn();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp("joystick button 4") || cansprint == false)
        {
            Sprint_check = false;
            Animator.SetBool("Run", false);
            if (Running == true)
            {
                WalkOn();
            }
        }
        if (Input.GetKeyDown("e") || Input.GetKeyDown("joystick button 1"))
        {

            Combat_Roll_Check();
        }
        if (Input.GetKeyUp("e") || Input.GetKeyUp("joystick button 1"))
        {
 
            Combat_Roll_Check_Off();
        }
        if (Input.GetKeyUp("w"))
        {
            RunOff();
        }
        if (Input.GetKeyDown("w"))
        {
            if (Sprint_check == false)
            {
                WalkOn();
            }

            if (Sprint_check == true)
            {
               
                RunOn();
            }
        }
        if (Input.GetKeyUp("w"))
        {
            WalkOff();
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 0"))
        {
            Jump();
            StartCoroutine(Jump_Checker());
        }
        if (Input.GetKeyDown("q") || Input.GetKeyDown("joystick button 2"))
        {
            Time_Slow();
        }
    }
    public void Controller_W()
    {
        WalkOn();
        Debug.Log("w");
        cansprint = true;
    }
    public void Controller_S()
    {
        Walk_Back_On();
        Debug.Log("s");
    }
    public void Controller_D()
    {
        Walk_Right_On();
        Debug.Log("d");
    }
    public void Controller_A()
    {
        Debug.Log("a");
        Walk_Left_On();
    }
    public void Controller_W_Off()
    {
        WalkOff();
        Debug.Log("woff");
        
    }

    public void Controller_S_Off()
    {
        Walk_Back_Off();
        Debug.Log("soff");
    }
    public void Controller_A_Off()
    {
        Debug.Log("aoff");
        Walk_Left_Off();
    }
    public void Controller_D_Off()
    {
        Walk_Right_Off();
        Debug.Log("doff");
    }
    // Movemenet Methods aka the main body
    public void Combat_Roll_Check ()
    { 
            Animator.SetBool("Roll",true);
    }
    public void Combat_Roll_Check_Off()
    {
        Animator.SetBool("Roll", false);
    }
    IEnumerator Roll_Off()
    {
        yield return new WaitForSecondsRealtime(1);
        Animator.SetBool("Roll", false);
        Combat_Roll_Checker = false;
    }
    public void Grounded()
    {
        On_Floor = true;
        //Death_Timer = false;
    }
    public void NotGrounded()
    {
        On_Floor = false;
    }
    public void Falling()
    {
        Fall_Check_bool = true;
        StartCoroutine(Fall_Check());
    }
    public void NotFalling()
    {
        Fall_Check_bool = false;
        Animator.SetBool("Falling", false);
    }
    public void RunOn()
    {
       
        Animator.SetBool("Run", true);
        Animator.SetBool("Walk", false);
        Running = true;
        Walking = false;
    }
    public void RunOff()
    {
         Animator.SetBool("Run", false);
         Running = false;
    }
    public void WalkOn()
    {
        if (Sprint_check == false)
        {
            if (cansprint == true)
            {
                Animator.SetBool("Walk", true);
                Animator.SetBool("Run", false);
                Running = false;
                Walking = true;
            }

        }
        else
        {
            RunOn();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            RunOn();
        }
    }
    public void WalkOff()
    {
        Animator.SetBool("Walk", false);
        Walking = false;
    }

    public void Walk_Back_On()
    {
        Animator.SetBool("Walk_Back", true);
    }
    public void Walk_Back_Off()
    {
        Animator.SetBool("Walk_Back", false);
    }
    public void Walk_Right_On()
    {
        Animator.SetBool("Walk_Right", true);
    }
    public void Walk_Right_Off()
    {
        Animator.SetBool("Walk_Right", false);
    }
    public void Walk_Left_On()
    {
        Animator.SetBool("Walk_Left", true);
    }
    public void  Walk_Left_Off()
    {
        Animator.SetBool("Walk_Left", false);
    }

    public void Jump()
    {
        if (Running == false && Walking == false)
        {
            Animator.SetBool("Idle_Jump", true);
            Idle_Jump = true; 
            StartCoroutine(Idle_JumpOff());
        }
        if (Running == true && Walking == false && Vault_Enabled == false)
        {
            Animator.SetBool("Run_Jump", true);
            Run_Jump = true;
            StartCoroutine(Run_JumpOff());
        }
        if (Running == false && Walking == true)
        {
            Animator.SetBool("Walk_Jump", true);
            Walk_Jump = true;
            StartCoroutine(Walk_JumpOff());
        }
        if (Running == true && Walking == false && Vault_Enabled == true)
        {
            Animator.SetBool("Run_Vault", true);
            Animator.SetBool("Run_Jump", false);
            Run_Vault = true;
            StartCoroutine(Run_VaultOff());

        }
        if (Running == true && Walking == false && Tall_Vault_Enabled == true)
        {
           
            Animator.SetBool("Run_Tall_Vault", true);
            Run_Tall_Vault = true;
            Perent.SendMessage("TALL_VAULT");
            StartCoroutine(Run_Tall_VaultOff());

        }
        if (Running == true && Walking == false && Climb_Enabled == true)
        {
            
            Animator.SetBool("Run_Wall", true);
            Run_Climb = true;
            Perent.SendMessage("Run_Climb");
            StartCoroutine(Run_Climb_Off());

        }
    }
    public void Time_Slow()
    {
        Bullet_Time.Do_Bullet_Time();
        Dramatic_Bars.SendMessage("Time");
        //The_Camera.SendMessage("BloomTime");
    }
    public void DeathOn()
    {
        NOKILL = true;
    }
    public void DeathOff()
    {
        NOKILL = false;
    }
    public void Death()
    {
        Debug.Log("deathactive");
        RagDoll.SetActive(true);
        Perent.SendMessage("Death_Cam");
        Player.SetActive(false);
       

        //{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //}
    }
    //Below are timers to switch animations off once the animation is complete
    //they are called out in the above method(s)

    IEnumerator Jump_Checker()
    {
        Jump_Check = false;
        if (Time_Check == false)
        {
            Time_Check = true;
            yield return new WaitForSecondsRealtime(1);
            Time_Check = false;
            Jump_Check = true;
        }
    }
    IEnumerator Death_Height()
    {
        yield return new WaitForSecondsRealtime(1.2f);
        // if (On_Floor == false && Death_Timer == false && Run_Jump == false && Idle_Jump == false)
        // {
        //    Debug.Log("1");
        //    yield return new WaitForSecondsRealtime(1f);
        //    if (Combat_Roll_Checker = false && On_Floor == false && Death_Timer == false && Run_Jump == false && Idle_Jump == false)
        //    {
        //           Debug.Log("4");
        //            Death_Timer = false;
        //           Death();
        //   }
        //}
        Debug.Log("Check2");
        if ( NOKILL = false && Slide == false && Fall_Check_bool == true  && Run_Jump == false && Idle_Jump == false)
        {
            Debug.Log("1");
            yield return new WaitForSecondsRealtime(1f);
            if (NOKILL = false && Slide == false && Fall_Check_bool == true &&  Run_Jump == false && Idle_Jump == false)
            {
                Debug.Log("2");
                yield return new WaitForSecondsRealtime(0.1f);
                if (NOKILL = false && Slide == false && Fall_Check_bool == true && Combat_Roll_Checker == false) 
                {
                    Death();
                }
            }
        }
    }
    IEnumerator Idle_JumpOff()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(1);
        Animator.SetBool("Idle_Jump", false);
        Idle_Jump = false;
    }
    IEnumerator Walk_JumpOff()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Animator.SetBool("Walk_Jump", false);
        Walk_Jump = false;
    }
    IEnumerator Run_JumpOff()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(0.3f);
        Animator.SetBool("Run_Jump", false);
        Run_Jump = false;
        Vault_Enabled = false;
    }
    IEnumerator Run_VaultOff()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(1);
        Animator.SetBool("Run_Vault", false);
        Run_Vault = false;
        Vault_Enabled = false;
    }
    IEnumerator Run_Tall_VaultOff()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(1);
        Animator.SetBool("Run_Tall_Vault", false);
        Run_Tall_Vault = false;
        Tall_Vault_Enabled = false;
    }
    IEnumerator Run_Climb_Off()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(1);
        Animator.SetBool("Run_Wall", false);
        Run_Climb = false;
        Climb_Enabled = false;
    }
    IEnumerator Fall_Check()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(0.2f);
        if (Fall_Check_bool == true && Slide ==false && Run_Vault == false && Run_Tall_Vault == false && Run_Climb ==false)
        {
            StartCoroutine(Death_Height());
            Debug.Log("Check1");
            Animator.SetBool("Falling", true);
            On_Floor = false;
        }
    }

    //Below are all inputs from obsitcales, here they will declere bools to
    //tell the controller that the player is in vacinity of set obsitcal and
    //can peform the opropriate animation

    public void Vault_Entered()
    {
        Vault_Enabled =true;
    }
    public void Vault_Exit()
    {
        Vault_Enabled = false;
    }
    public void Tall_Vault_Entered()
    {
        Tall_Vault_Enabled = true;
    }
    public void Tall_Vault_Exit()
    {
        Tall_Vault_Enabled = false;
    }
    public void Climb_Enter()
    {
        Climb_Enabled = true;
    }
    public void Climb_Exit()
    {
        Climb_Enabled = false;
    }
    public void Slide_Entered()
    {
        Slide = true;
        On_Floor = true;
        Animator.SetBool("Slide", true);
    }
    public void Slide_Exit()
    {
        Animator.SetBool("Slide", false);
        Slide = false;
    }

}