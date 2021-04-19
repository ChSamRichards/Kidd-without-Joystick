using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectSelect : MonoBehaviour
{

    public Animation animation;
    // Update is called once per frame
    
    void Start()
    {
        //animation = GameObject.Find("RigidBodyFPSController").GetComponent<Animiation>();
    }
    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cube" || hit.transform.name == "Sphere" || hit.transform.name == "Capsule" || hit.transform.name == "Table_curve003")
                {
                   // SceneManager.LoadScene("Level1");
                }
                
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cube" || hit.transform.name == "Sphere" || hit.transform.name == "Capsule" || hit.transform.name == "Table_curve003")
                {
                  //  SceneManager.LoadScene("Level1");
                }
            }

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Level1");
            //if (hit.transform.name == "Maths" || hit.transform.name == "Science" || hit.transform.name == "Hindi" || hit.transform.name == "Social")
            //{
            //    SceneManager.LoadScene("Level1");
            //}
            //RaycastHit hit;
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out hit))
            //{
            //    if (hit.transform.name == "Maths" || hit.transform.name == "Science" || hit.transform.name == "Hindi" || hit.transform.name == "Social")
            //    {
            //        SceneManager.LoadScene("Level1");
            //    }
            //}
        }
    }
    public void Scenechange()
    {
        SceneManager.LoadScene("LoaderScene");
    }
}
