﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] float gravity;
    [SerializeField] float deceleration;

    int rockAmount = 0;

    void Awake()
    {
        DontDestroyOnLoad(this);
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;
    }

    public float GetGravity()
    {
        return gravity;
    }

    public float GetDeceleration()
    {
        return deceleration;
    }

    public int GetRockAmount()
    {
        return rockAmount;
    }

    public void AddRockAmount(int amount)
    {
        rockAmount += amount;
    }

}
