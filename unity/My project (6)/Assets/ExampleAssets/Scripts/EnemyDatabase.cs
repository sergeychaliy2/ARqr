using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class NewBehaviourScript : MonoBehaviour
{
    Interface IDeviceLoader
    {
        GetDevice(int id_device):DeviceInfo{}
}


class ScriptableLoader():IDeviceLoader
{
    GetDevice(id_device);
}

class DeviceInfo (){
    int year = 0;
    int life = 0;
    int serie = 0;

    public DeviceInfo(int_year, int _life, int _serie)
    {
        this.year = _year;
        this.life = _life;
        this.serie = _serie;
    }
}
*/

[CreateAssetMenu(menuName = "Databases/Device", fileName = "Device")]
public class EnemyDatabase : ScriptableObject
{
    [SerializeField, HideInInspector] private List<EnemyData> enemyList;
    [SerializeField] private EnemyData currentEnemy;

    private int currentIndex = 0;


    public void addDevice(){

            if (enemyList == null)
            {
                enemyList = new List<EnemyData>();

                currentEnemy = new EnemyData();
                enemyList.Add(currentEnemy);
                currentIndex = enemyList.Count - 1;
            }
    }

    public EnemyData GetPrev(){

        if (currentIndex > 0)
        {
            currentIndex--;
            currentEnemy = this[currentIndex];
            return CurrentEnemy;
        }
    }

    public EnemyData GetNext(){

        if (currentIndex < enemyList.Count - 1)
        {
            currentIndex++;
            currentEnemy = this[currentIndex];
            return CurrentEnemy;
        }
    }
    public void ClearDatabase()
    {
        enemyList.Clear();
        enemyList.Add(new EnemyData());
        currentEnemy = enemyList[0];
        currentIndex = 0;
    }

    public EnemyData GetRandomElement()
    {
        int random = Random.Range(0, enemyList.Count);
        return enemyList[random];
    }

    public void RemoveCurrentElement()
    {
        if (currentIndex > 0)
        {
            currentEnemy = enemyList[--currentIndex];
            enemyList.RemoveAt(++currentIndex);
        }
        else
        {
            enemyList.Clear();
            currentEnemy = null;
        }

    }

    public EnemyData this[int index]
    {
        get
        {
            if (enemyList != null && index >= 0 && index < enemyList.Count)
                return enemyList[index];
            return null;
        }
        set {

             if (enemyList == null)
                 enemyList = new List<EnemyData>();

             if (index >=0 && index < enemyList.Count && value != null)
                enemyList[index] = value;
           
             else Debug.LogError("переданное значение = null");
        }
            
        
    }
}
