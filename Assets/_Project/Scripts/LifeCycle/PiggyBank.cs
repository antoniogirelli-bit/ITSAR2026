using System;
using System.Collections;
using UnityEngine;
// salvadanaio dgitale
public class PiggyBank : MonoBehaviour
{
    [SerializeField] int maxCapacity = 50;
    [SerializeField] int currentValue;
    [SerializeField] BankAccount bankAccount;       // classe e variabile

    private void Awake()
    {
        currentValue = 0;
    }

    private void Start()
    {
        StartCoroutine(AddMoneyToPiggyBank());
    }

    IEnumerator AddMoneyToPiggyBank()
    {
        yield return new WaitForSeconds(1);
        currentValue++;
        if (currentValue == maxCapacity)
        {
            AddToAccount();
        }
        StartCoroutine(AddMoneyToPiggyBank());
    }

    void AddToAccount()
    {
        if (bankAccount)
        {
            bankAccount.AddMoneyToBank(currentValue);
            Debug.Log($"MONEY IN THE BANK: {bankAccount.BankValue}");       // $ = serve per nelle string {variabile}
            currentValue = 0;
        }
    }
}