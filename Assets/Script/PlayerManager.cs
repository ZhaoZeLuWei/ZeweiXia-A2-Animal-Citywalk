using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;
    [SerializeField] float value;
    [SerializeField] Vector3 sizeChangeValue;
    private Vector3 startPosition;
    private Quaternion startRotation;
    private Vector3 startScale;
    public int moveCheck;

    public void Start()
    {
        startPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        startRotation = player.transform.rotation;
        startScale = player.transform.localScale;
    }

    public void moveRight() {
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + value);
    }

    public void moveLeft() {
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - value);
    }

    public void rotateLeft() {
        player.transform.Rotate(0,10.0f,0);
    }

    public void rotateRight() {
        player.transform.Rotate(0,-10.0f,0);
    }

    public void grow() {
        player.transform.localScale = player.transform.localScale + sizeChangeValue;
    }

    public void small() {
        player.transform.localScale = player.transform.localScale - sizeChangeValue;
    }

    public void resetPlayer() {
        player.transform.position = startPosition;
        player.transform.rotation = startRotation;
        player.transform.localScale = startScale;
    }
}

