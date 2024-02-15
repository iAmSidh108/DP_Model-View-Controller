 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;

    void Start()
    {
        tankSpawner = FindObjectOfType<TankSpawner>();
        gameObject.SetActive(true);
    }

    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.GreenTank);
        gameObject.SetActive(false);
    }

    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.BlueTank);
        gameObject.SetActive(false);
    }

    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.RedTank);
        gameObject.SetActive(false);
    }




    
}
