﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    [SerializeField]
    private Transform piece1place;

    private Vector2 initialPosition;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
        }
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - piece1place.position.x) <= 0.5f &&
            Mathf.Abs(transform.position.y - piece1place.position.y) <= 0.5f)
        {
            transform.position = new Vector2(piece1place.position.x, piece1place.position.y);
            locked = true;
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }

}