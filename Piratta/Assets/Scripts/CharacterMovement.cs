using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CharacterMovement : MonoBehaviour
{
    MouseInputs mouseInputs;
    public Tilemap map;
    private Vector3 destination;
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
        Debug.Log($"Position (x : {mousePosition.x}, y : {mousePosition.y})");
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Debug.Log($"Position (x : {mousePosition.x}, y : {mousePosition.y})");
        Vector3Int gridPosition = map.WorldToCell(mousePosition);
        Debug.Log($"Position (x : {gridPosition.x}, y : {gridPosition.y})");
        if (map.HasTile(gridPosition))
        {
            destination = map.GetCellCenterWorld(gridPosition);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, destination) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, 5f * Time.deltaTime);
        }
    }
}
