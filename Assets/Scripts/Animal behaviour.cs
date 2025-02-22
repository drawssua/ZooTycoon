using JetBrains.Annotations;
using UnityEngine;

public class Animal
{
    public float weight;
    public float speed;
    public Color color;
    public int age;
    public float hunger;

    public void Eat()
    {
        hunger = 0.0f;
    }

    public void Breathe()
    {

    }

    public void Drink()
    {

    }

    public void CreateChildren()
    {

    }
}

public class Seal : Animal
{
    public void Clap()
    {
        int hMin = 0;
        int hMax = 1;
        int Hunger = 1;
        Debug.Log("* clap clap clap*");
       
        if (Hunger == hMin)
        {
            Debug.Log("seal: I AM HUNGRY");
        }
        else if(Hunger == hMax)
        {
            Debug.Log("seal: I am not to hungry");
        }
    }
}

public class Fox : Animal
{
    public void Howl()
    {
        int hMin = 0;
        int hMax = 1;
        int Hunger = 1;
        Debug.Log("ARUFFF");
       
        if (Hunger == hMin)
        {
            Debug.Log("Fox: I AM HUNGRY");
        }
        else if (Hunger == hMax)
        {
            Debug.Log("Fox: I am not to hungry");
        }
    }
}

public class Dove : Animal
{
    public Quaternion Rotate()
    {
        return Quaternion.Euler(0.0f, 0.0f, 90.0f);
    }

    public void Tweet()
    {
        int hMin = 0;
        int hMax = 1;
        int Hunger = 0;
        Debug.Log("Tweet");
     
        if (Hunger == hMin)
        {
            Debug.Log("Dove: I AM HUNGRY");
        }
        else if (Hunger == hMax)
        {
            Debug.Log("Dove: I am not to hungry");
        }
    }
}

public class Jugi : Animal
{
    public float reactionTime;
    public float cutenessFactor;
    
    public void Glomp()
    {
        int hMin = 0;
        int hMax = 1;
        int Hunger = 0;
        Debug.Log("glomp");
        
        if (Hunger == hMin)
        {
            Debug.Log("Jugi: I AM HUNGRY");
        }
        else if (Hunger== hMax)
        {
            Debug.Log("Jugi: I am not to hungry");
        }
    }

    public void BeCute()
    {
        cutenessFactor = float.MaxValue;
    }
}
