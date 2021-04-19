using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurveAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animation animation;
    public GameObject curveCanvas;
    public GameObject Player;
    public bool clickit;
    public Vector3 wPos;
    public Vector3 Present;
  //  public float Timer;
   // public float speed = 10f;
    public bool ok;
    void Start()
    {
        animation = GameObject.Find("RigidBodyFPSController").GetComponent<Animation>();
      //  curveCanvas.SetActive(false);
        // Present = new Vector3(0f, 20f, -25f);
        //  wPos = new Vector3(2.25f, 1.669121f, -0.7f);

    }
    public void Update()
    {
       // Timer += Time.deltaTime * speed;
       //if(Player.transform.position == new Vector3(0f, 20f, -25f))
       // {
       //     clickit = true;
       // }
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if(clickit == true)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                if (Physics.Raycast(ray, out hit))
                {

                    if (hit.transform.name == "Table_curve003")
                    {
                        //SceneManager.LoadScene("Level1");
                        animation.Play();
                       // curveCanvas.SetActive(true);
                       // Player.transform.position = Vector3.Lerp(Present, wPos, Timer);
                        clickit = false;
                        ok = true;
                    }
                }
            }
           
        }
        else if (Input.GetMouseButtonDown(0) && clickit == true)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Table_curve003")
                {
                    //SceneManager.LoadScene("Level1");
                     animation.Play();
                   // Player.transform.position = Vector3.Lerp(Present, wPos, Timer);
                  //  curveCanvas.SetActive(true);
                    clickit = false;
                    ok = true;
                }
            }

        }
    }
    //public void Animate()
    //{
    //    animation.Play();
    //    curveCanvas.SetActive(true);
    //}
    //public void Animate()
    //{
    //    if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
    //    {
    //        RaycastHit hit;
    //        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
    //        if (Physics.Raycast(ray, out hit))
    //        {
                
    //            if (hit.transform.name == "Table_curve003")
    //            {
    //                //SceneManager.LoadScene("Level1");
    //                animation.Play();
    //            }
    //        }
    //    }
    //}
    //// Update is called once per frame
    
}
