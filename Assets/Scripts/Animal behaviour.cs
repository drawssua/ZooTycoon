using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class  Animals
{
    public float position;
    public float speed;

public class Behaviour
{ 
    public float Hmin = 0.0f;
    public float Hmax = 100.0f;
    public float Hrandom = Random.value;
}
public abstract class HUNGER
{
    public float Hmin = 0.0f;
    public float Hmax = 100.0f;
    public float Hrandom = Random.value;
}
    public void move()
    {
        
    }

    public void drink()
    {
       
    }
    public void createChildren()
    {
       
    }
    public void hunger()
    {
        if (Hrandom <= Hmin)
        {
            Debug.Log("I am HUNGRY");
        }
        else if (Hrandom >= Hmax) 
        {
            Debug.Log("I am not to hungry");
        } 
         
    }
}
public class seal : Animals
{
    public void Roar()
    {
        float Hmin = 0.0f;
        float Hmax = 100.0f;
        float Hrandom = Random.value;
        Debug.Log("RAWWWRRRRR (idk)");
        if (Hrandom <= Hmin)
        {
            Debug.Log("I am HUNGRY");
        }
        else if (Hrandom >= Hmax)
        {
            Debug.Log("I am not to hungry");
        }
    }
}
public class fox : Animals
{
    public void Howl()
    {
        float Hmin = 0.0f;
    float Hmax = 100.0f;
    float Hrandom = Random.value;
    Debug.Log("ARRUUUUUU");
        if (Hrandom <= Hmin)
        {
            Debug.Log("I am HUNGRY");
        }
        else if (Hrandom >= Hmax)
        {
            Debug.Log("I am not to hungry");
        }
    }
}
public class dove : Animals
{
    public void chirp()
    {
        float Hmin = 0.0f;
        float Hmax = 100.0f;
        float Hrandom = Random.value;
        Debug.Log("CHEP CHEP CHEP");
        if (Hrandom <= Hmin)
        {
            Debug.Log("I am HUNGRY");
        }
        else if (Hrandom >= Hmax)
        {
            Debug.Log("I am not to hungry");
        }
    }
}
public class jugi : Animals
{
    public void bark()
    {
        float Hmin = 0.0f;
        float Hmax = 100.0f;
        float Hrandom = Random.value;
        Debug.Log("woooooffffff");
        if (Hrandom <= Hmin)
        {
            Debug.Log("I am HUNGRY");
        }
        else if (Hrandom >= Hmax)
        {
            Debug.Log("I am not to hungry");
        }
    }
}
