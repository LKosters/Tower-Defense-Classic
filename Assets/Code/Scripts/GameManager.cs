using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager main;
    public Transform startPoint;
    public Transform[] path;

    private void Awake()
    {
        main = this;
    }
}
