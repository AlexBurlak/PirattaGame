using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CharacterMovement : MonoBehaviour
{
    MouseInputs mouseInputs;
    public Tilemap map;
    private Vector3 destination;
    private Vector3 direction;
    [SerializeField]
    private float movementSpeed;

    private void Awake()
    {
        mouseInputs = new MouseInputs();
    }
    private void OnEnable()
    {
        this.mouseInputs?.Enable();
    }
    private void OnDisable()
    {
        this.mouseInputs?.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        destination = transform.position;
        mouseInputs.Mouse.MouseClick.performed += _ => MouseClick();
    }

    private void MouseClick()
    {
        Vector2 mousePosition = mouseInputs.Mouse.MousePosition.ReadValue<Vector2>();
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3Int gridPosition = map.WorldToCell(mousePosition);
        if (map.HasTile(gridPosition))
        {
            destination = map.GetCellCenterWorld(gridPosition);
            direction = destination - transform.position;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, destination) > 0.1f)
        {
            // find the target position relative to the player:
            // calculate movement at the desired speed:
            var movement = direction.normalized * 5f * Time.deltaTime;
            // limit movement to never pass the target position:
            if (movement.magnitude > direction.magnitude) movement = direction;

            transform.position += movement;
        }
    }

    public void Interact()
    {
        Debug.Log("Interacted!");
    }
}
