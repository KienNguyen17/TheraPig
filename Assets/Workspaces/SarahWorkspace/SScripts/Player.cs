using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] InventoryManager inventoryManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E)) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, 3)) {
                ItemPickable item = hitInfo.collider.gameObject.GetComponent<ItemPickable>();

                if (item != null) {
                    inventoryManager.ItemPicked(hitInfo.collider.gameObject);
                }
            }
        }
    }
}
