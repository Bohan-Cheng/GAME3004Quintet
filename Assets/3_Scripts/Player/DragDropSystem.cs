using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDropSystem : MonoBehaviour
{
    [SerializeField] Camera cam;
    public List<GameObject> SpawnItems;

    GameObject PlacementItem;
    bool InPlacement;
    Vector3 HitPosition;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1 << LayerMask.NameToLayer("Terrain")))
        {
            HitPosition = hit.point;
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (!InPlacement)
                {
                    InPlacement = true;
                    GameObject Item = SpawnItems[Random.Range(0, SpawnItems.Count)];
                    PlacementItem = Instantiate(Item, HitPosition, new Quaternion());
                    PlacementItem.transform.Rotate(Vector3.up, Random.Range(0, 360));
                }
            }
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                InPlacement = false;
                PlacementItem = null;
            }
        }

        if (InPlacement && PlacementItem)
        {
            PlacementItem.transform.position = HitPosition;
        }
    }

}
