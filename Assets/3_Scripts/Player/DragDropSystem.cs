using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDropSystem : MonoBehaviour
{
    [SerializeField] Camera cam;

    public GameObject PlacementItem;
    Vector3 HitPosition;

    // Update is called once per frame
    void Update()
    {
        if (PlacementItem)
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1 << LayerMask.NameToLayer("Terrain")))
            {
                if (!InPlacement)
                {
                    InPlacement = true;
                    GameObject Item = SpawnItems[Random.Range(0, SpawnItems.Count)];
                    PlacementItem = Instantiate(Item, HitPosition, new Quaternion());
                    PlacementItem.transform.Rotate(Vector3.up, Random.Range(0, 360));
                    Quests.placedTurrets += 1;
                }
                HitPosition = hit.point;
                PlacementItem.transform.position = HitPosition;
            }

            if(Input.GetMouseButtonUp(0))
            {
                PlacementItem = null;
            }
        }
    }

}
