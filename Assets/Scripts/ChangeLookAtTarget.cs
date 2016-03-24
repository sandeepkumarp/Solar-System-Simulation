using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeLookAtTarget : MonoBehaviour
{

    public GameObject target; // the target that the camera should look at
    public Text text;

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
        }
    }

    // Called when MouseDown on this gameObject
    void OnMouseDown()
    {
        // change the target of the LookAtTarget script to be this gameobject.
        LookAtTarget.target = target;
        text.text = "Solar System\nFocusing on " + target.name;
        Camera.main.fieldOfView = 60 * target.transform.localScale.x;
    }
}
