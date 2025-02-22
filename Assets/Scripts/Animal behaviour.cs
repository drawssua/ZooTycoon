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
        Debug.Log("* clap clap clap*");
    }
}

public class Fox : Animal
{
    public void Howl()
    {
        Debug.Log("ARUFFF");
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
        Debug.Log("Tweet");
    }
}

public class Jugi : Animal
{
    public float reactionTime;
    public float cutenessFactor;

    public void Glomp()
    {
        Debug.Log("glomp");
    }

    public void BeCute()
    {
        cutenessFactor = float.MaxValue;
    }
}
