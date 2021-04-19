using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityStandardAssets.Characters.FirstPerson;

public class Lopter : MonoBehaviour
{
    //public FixedJoystick joy;
    //// public FixedTouch fixedTouch;
    //// Start is called before the first frame update
   // public Vector3 startPos;
    public GameObject Player;
 //   public Transform target;
 //   public float speed = 0.0001f;
    public RotationG rotationG;
  //  public Vector3 presentPos;
  //  public Vector3 NewPose;
  //  float Timer;

    //void Awake()
    //{
    //    Player = GameObject.Find("RigidBodyFPSController");
    //    rotationG = Player.GetComponent<RotationG>();
    //}
    public int flag, rev;
    public int leftLimit = -5, rightlimit = 5;
    public float angle;
    public int bck;
 //   public GameObject LeftButton;
  //  public GameObject RightButton;
  //  public bool Opp;
    
    void Start()
    {
        // startPos = Player.transform.position;
        //Input.multiTouchEnabled = false;

        Player = GameObject.Find("RigidBodyFPSController");
        rotationG = Player.GetComponent<RotationG>();
       // bck = 1;
     //   LeftButton = GameObject.Find("LeftButton");
     //   RightButton = GameObject.Find("RightButton");
       // presentPos = new Vector3(2.25f, 1.669121f, -0.7f);

        //   presentPos = new Vector3(2.25f, 1.669121f, - 0.7f);

    }
    public void Update()
    {

        //var fps = GetComponent<FirstPersonController>();
        // fps.RunAxis = joy.input;
        //   fps.mouseLook.LookAxis = fixedTouch.TouchDist;
        //// rotationG.RotateButton(angle);
    
      

        // Player.transform.localPosition = new Vector3.Lerp(presentPos, new Vector3(1.5f, 1.669121f, -0.8f, Time.deltaTime);
        //if(flag > -6 || flag < 0)
        //{
        //    RightButton.SetActive(false);
        //}
        //else
        //{
        //    LeftButton.SetActive(false);
        //}
        //if(Opp == true)
        //{
        //    RightButton.SetActive(false);
        //}
        //else if (Opp == false)
        //{
        //    LeftButton.SetActive(false);
        //}
        //else if(flag == 5)
        //{
        //    RightButton.SetActive(true);
        //    LeftButton.SetActive(true);
        //}
    }

    // Update is called once per frame
    public void LeftButtonMovement()
    {
        //int pos = (int)(data.position.x - m_StartPos.x);
        //pos = Mathf.Clamp(pos, -MovementRange, MovementRange);
        //newPos.x = delta;
        //  RightButton.SetActive(false);
        //if (flag == 5)
        //{
        //    flag = 0;
        //}
        flag--;
        if (flag == -3)
        {
            flag = -2;
            
        }
        if(flag <= 2 && flag >= 0)
        {
            rev = 1;
            
            PositionMovement(flag, rev);

        }
        else if(flag >= -2 && flag <= 0)
        {
            rev = 0;
            PositionMovement(flag, rev);
        }
        //if(flag == -6)
        //{
        //    flag = 0;
        //}
        //if (flag >= -4 || flag < 0)
        //{
        //    Opp = true;  //PositionMovementOpp(flag);
        //}

        // Player.transform.localPosition = new Vector3(-4.06f, 1.669121f, -1.49f); // * speed;
        //  angle = 30f;                                                                        //Player.transform.Rotate(0, 90, 0);
        //  Player.transform.eulerAngles = new Vector3(0f, 34.074f, 0f);
       // PositionMovement(flag);                                                                        // transform.RotateAround(Player.transform.position, Vector3.up, 34.074f);
       // rotationG.RotateButton(flag, angle);
        // startPos = Player.transform.position;
    }
    public void RightButtonMovement()
    {
        // LeftButton.SetActive(false);
        //if (flag == -5)
        //{
        //    flag = 0;
        //    //  Key = 1;
        //    // LeftButton.SetActive(false);
        //}
        flag++;
        if (flag == 3)
        {
            flag = 2;
          //  Key = 1;
           // LeftButton.SetActive(false);
        }
        if (flag >= -2 && flag <= 0)
        {
            rev = 2;
            PositionMovement(flag, rev);

        }
        else if (flag <= 2 && flag >= 0)
        {
            rev = 0;
            PositionMovement(flag, rev);
        }
        //if (flag == 5)
        //{
        //    flag = 0;
        //    //  Key = 1;
        //    // LeftButton.SetActive(false);
        //}
        //if (flag == -6)
        //{
        //    flag = 0;
        //    //  Key = 1;
        //    // LeftButton.SetActive(false);
        //}
        //if (flag <= 4 || flag < 0)
        //{
        //    Opp = false;  //PositionMovementOpp(flag);
        //}


       // PositionMovement(flag);                                                                        // transform.RotateAround(Player.transform.position, Vector3.up, 34.074f);
       // rotationG.RotateButton(flag, angle);

        //Player.transform.localPosition += Player.transform.right; //* speed;
        // startPos = Player.transform.position;
    }

    public void BackButton()
    {
        // rotationG.BackButtomMovement(bck);
        SceneManager.LoadScene("LoaderScene");
    }
    public void PositionMovement(int flag, int rev)
    {
        if((flag > -3 && flag < 3))
        {
            switch (flag)
            {
                case -1:
                   //S Player.transform.localPosition = new Vector3(1.5f, 1.669121f, -0.8f);// Vector3.Lerp(Player.transform.localPosition, new Vector3(1.5f, 1.669121f, -0.8f), Time.deltaTime*speed); // * Time.deltaTime;
                  //  NewPose = new Vector3(1.5f, 1.669121f, -0.8f);
                    angle = -20f;
                   // Player.transform.LookAt(target);
                    //Update(angle);
                    // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -30, 0), speed * Time.deltaTime);
                    rotationG.RotateButton(flag, angle, rev);
                    //Player.transform.localPosition = Vector3.Lerp(Player.transform.localPosition, new Vector3(1.5f, 1.669121f, -0.8f), Time.deltaTime * speed);
                    break;
                case -2:
                   // NewPose = new Vector3(0f, 1.669121f, -1.7f);
                    angle = 30f;
                    //  transform.LookAt(target);
                    // Update(angle);
                  //  Player.transform.localPosition = new Vector3(0f, 1.669121f, -1.7f);
                    rotationG.RotateButton(flag, angle, rev);
                    break;
                //case -3:
                //    //  NewPose = new Vector3(-2f, 1.669121f, -1.7f);
                //    angle = 10f;
                //    //  transform.LookAt(target);
                //    rotationG.RotateButton(flag, angle, rev);
                //    break;
                //case -4:
                //    //  NewPose = new Vector3(-4f, 1.669121f, -0.8f);
                //    angle = 30f;
                //    //  transform.LookAt(target);
                //    rotationG.RotateButton(flag, angle, rev);
                //    break;
                //case -5:
                //    NewPose = new Vector3(2.25f, 1.669121f, -0.7f);
                //    angle = 0f;
                //    rotationG.RotateButton(flag, angle, Player.transform.position, NewPose, rev);
                //    flag = 0;
                //    break;


                // flag = 0;
                // cameraRotSide = angle;

                case 1:
                   // NewPose = new Vector3(2.8f, 1.669121f, -0.8f);
                    angle = 30f;

                    rotationG.RotateButton(flag, angle, rev);
                    break;
                case 2:
                  //  NewPose = new Vector3(4.8f, 1.669121f, -1.7f);
                    angle = -30f;
                    rotationG.RotateButton(flag, angle, rev);
                    break;
                //case 3:
                //    //  NewPose = new Vector3(6.8f, 1.669121f, -1.7f);
                //    angle = -10f;
                //    rotationG.RotateButton(flag, angle, rev);
                //    break;
                //case 4:
                //    // NewPose = new Vector3(8.2f, 1.669121f, -0.8f);
                //    angle = -30f;
                //    rotationG.RotateButton(flag, angle, rev);
                //    break;
                //case 5:
                //    NewPose = new Vector3(2.25f, 1.669121f, -0.7f);
                //    angle = 0f;
                //    rotationG.RotateButton(flag, angle, Player.transform.position, NewPose, rev);
                //    break;

                default:
                    //flag = 0;
                  //  NewPose = new Vector3(2.25f, 1.669121f, -0.7f);
                  //  NewPose = new Vector3(2.25f, 1.669121f, -0.7f);
                    angle = 0f;
                    rotationG.RotateButton(flag, angle, rev);
                    break;
                    //addd points

            }
        }
       
    }
    //public void PositionMovementRight(int flag)
    //{
    //    if (flag < 5 && flag > 0)
    //    {
    //        switch (flag)
    //        {
    //            case 1:
    //                NewPose = new Vector3(2.8f, 1.669121f, -0.8f);
    //                angle = 30f;

    //                rotationG.RotateButton(flag, angle);
    //                break;
    //            case 2:
    //                NewPose = new Vector3(4.8f, 1.669121f, -1.7f);
    //                angle = 10f;
    //                rotationG.RotateButton(flag, angle);
    //                break;
    //            case 3:
    //                NewPose = new Vector3(6.8f, 1.669121f, -1.7f);
    //                angle = -10f;
    //                rotationG.RotateButton(flag, angle);
    //                break;
    //            case 4:
    //                NewPose = new Vector3(8.2f, 1.669121f, -0.8f);
    //                angle = -30f;
    //                rotationG.RotateButton(flag, angle);
    //                break;
    //            case 0:
    //                NewPose = new Vector3(2.25f, 1.669121f, -0.7f);
    //                angle = 0f;
    //                rotationG.RotateButton(flag, angle);
    //                break;
    //            default:
    //                //flag = 0;
    //                NewPose = new Vector3(2.25f, 1.669121f, -0.7f);
    //                angle = 0f;
    //                rotationG.RotateButton(flag, angle);
    //                break;
    //        }
    //    }
    //}
    public void PositionMovementOpp(int flag)
    {

    }
}
