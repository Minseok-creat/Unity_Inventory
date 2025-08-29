using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Info")]
    [SerializeField] protected string name;
    public string Name { get =>  name; set => name = value; }

    [SerializeField] protected string job;
    public string Job { get => job; set => job = value; }

    [SerializeField] protected string description;
    public string Description { get => description; set => description = value; }

    [Header("Currency")]
    [SerializeField] protected int gold;
    public int Gold 
    { 
        get => gold; 
        set => gold = Mathf.Max(0, value);
    }

    [Header("Level")]
    [SerializeField] protected int level;
    public int Level 
    { 
        get => level; 
        set => level = Mathf.Max(0, value); 
    }

    [SerializeField] protected int currentEXP;
    public int CurrentEXP 
    { 
        get => currentEXP; 
        set => currentEXP = Mathf.Max(0,value); 
    }

    [SerializeField] protected int maxEXP;
    public int MaxEXP 
    { 
        get => maxEXP; 
        set => maxEXP = Mathf.Max(0, value); 
    }

    [Header("Character Stat")]
    [SerializeField] private float baseAttack;
    public float BaseAttack
    {
        get => baseAttack;
        set => baseAttack = Mathf.Max(0, value);
    }

    [SerializeField] private float baseDefense;
    public float BaseDefense
    {
        get => baseDefense;
        set => baseDefense = Mathf.Max(0, value);
    }

    [SerializeField] private int baseHP;
    public int BaseHP
    {
        get => BaseHP;
        set => BaseHP = Mathf.Max(0, value);
    }

    [SerializeField] protected float baseCriticalPercent;
    public float BaseCriticalPercent
    {
        get => BaseCriticalPercent;
        set => BaseCriticalPercent = Mathf.Max(0, value);
    }

    public void AddEXP(int exp)
    {

    }

    public void AddGold(int gold)
    {

    }


}
