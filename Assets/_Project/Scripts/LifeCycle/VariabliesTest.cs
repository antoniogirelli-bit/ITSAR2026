using System;
using System.Collections.Generic;
using UnityEngine;

public class VariablesTest : MonoBehaviour
{
    [SerializeField]  int shopIndex = 8;             // NUMERO INTERO -> int x = n;

    [SerializeField]  float shopRevenues = 50.5f;    // NUMERO DECIMALE -> Float x = n.df;
    [SerializeField]  bool shopOpen = false;         // 
    public enum ShopState { OPENING, SELLING, RESTOCKING, CLOSING }   // enum -> ottimi per delle machine a stati, come RPG/RNG_AAC
    [SerializeField]  ShopState shopStateBase = ShopState.OPENING;
    [SerializeField]  ShopState shopStateAdvanced = ShopState.RESTOCKING;

    [SerializeField]  string shopName = "gun-shop";

    // array bool+[] > nome variabile -> da 0 a 4 = 5
    [SerializeField]  int[] productArray = new int[5];
    [SerializeField]  List<int> productList = new List<int>();

    // keys = nome prodotto; float = prezzo prodotto
    [SerializeField]  Dictionary<string, float> productDictionary = new Dictionary<string, float>();

     HashSet<Product> productHashSet = new HashSet<Product>();

    [SerializeField]  List<Product> productsList = new List<Product>();
}

[Serializable]
public class Product
{
    public string Name;     // Name = pubblico - name = privato
    public float Price;
}
