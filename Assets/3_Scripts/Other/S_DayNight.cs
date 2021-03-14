using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_DayNight : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;
    [SerializeField] float nightRest = 10.0f;
    bool isNight = false;
    float OriLux;
    Light lightComp;
    // Start is called before the first frame update
    void Start()
    {
        lightComp = GetComponent<Light>();
        OriLux = lightComp.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isNight)
        {
            transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
            if (transform.position.x >= 180.0f)
            {
                isNight = true;
                lightComp.intensity = 0;
                StartCoroutine(ResetSun());
            }
        }
    }

    IEnumerator ResetSun()
    {
        yield return new WaitForSeconds(nightRest);
        Quaternion rot = transform.rotation;
        rot.x = 0;
        transform.rotation = rot;
        lightComp.intensity = OriLux;
        isNight = false;
    }
}
