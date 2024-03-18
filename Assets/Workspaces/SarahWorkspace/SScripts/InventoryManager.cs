using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryManager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] GameObject[] slots = new GameObject[1];
    [SerializeField] GameObject inventoryParent;
    [SerializeField] GameObject itemPrefab;
    [SerializeField] Camera cam;
    GameObject draggedObject;
    GameObject lastObjectSlot;
    bool isInventoryOpened;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inventoryParent.SetActive(isInventoryOpened);
        if (draggedObject != null) {
            draggedObject.transform.position = Input.mousePosition;
        }
        if (Input.GetKeyDown(KeyCode.Tab)) {
            if (isInventoryOpened) {
                Debug.Log("Tab was clicked");
                Cursor.lockState = CursorLockMode.None;
                isInventoryOpened = false;
                Cursor.visible = false;
            }
            else {
                isInventoryOpened = true;
                Cursor.visible = true;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData) {
        if (eventData.button == PointerEventData.InputButton.Left) {
            Debug.Log(eventData.pointerCurrentRaycast.gameObject);
            GameObject clickedObject = eventData.pointerCurrentRaycast.gameObject;
            InventorySlot slot = clickedObject.GetComponent<InventorySlot>();

            if (slot != null && slot.heldItem != null) {
                draggedObject = slot.heldItem;
                slot.heldItem = null;
                lastObjectSlot = clickedObject;
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData) {
        if (draggedObject != null && eventData.pointerCurrentRaycast.gameObject != null && eventData.button == PointerEventData.InputButton.Left) {
            GameObject clickedObject = eventData.pointerCurrentRaycast.gameObject;
            InventorySlot slot = clickedObject.GetComponent<InventorySlot>();

            if (slot != null && slot.heldItem == null) {
                slot.SetHeldItem(draggedObject);
            }
            else if (slot != null && slot.heldItem == null) {
                lastObjectSlot.GetComponent<InventorySlot>().SetHeldItem(slot.heldItem);
                slot.SetHeldItem(draggedObject);
            }
            else if (clickedObject.name != "DropItem") {
                lastObjectSlot.GetComponent<InventorySlot>().SetHeldItem(draggedObject);
            }
            else {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                Vector3 position = ray.GetPoint(3);

                GameObject newItem = Instantiate(draggedObject.GetComponent<Inventory>().itemScriptableObject.prefab, position, new Quaternion());
                newItem.GetComponent<ItemPickable>().itemScriptableObject = draggedObject.GetComponent<Inventory>().itemScriptableObject;

                lastObjectSlot.GetComponent<InventorySlot>().heldItem = null;
                Destroy(draggedObject);
            }
            draggedObject = null;
        }
    }

    public void ItemPicked(GameObject pickedItem) {
        GameObject emptySlot = null;

        for (int i = 0; i < slots.Length; i++) {
            InventorySlot slot = slots[i].GetComponent<InventorySlot>();

            if (slot.heldItem == null) {
                emptySlot = slots[i];
                break;
            }
        }
        if (emptySlot != null) {
            GameObject newItem = Instantiate(itemPrefab);
            newItem.GetComponent<Inventory>().itemScriptableObject = pickedItem.GetComponent<ItemPickable>().itemScriptableObject;
            newItem.transform.SetParent(emptySlot.transform.parent.parent.GetChild(2));

            emptySlot.GetComponent<InventorySlot>().SetHeldItem(newItem);

            Destroy(pickedItem);
        }

    } 
}
