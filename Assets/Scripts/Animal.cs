using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public int age;
    //Random Movement in Habitat
    public class Field
    {
        public float width;
        public float height;
    }

    public Field field;
    public float moveSpeed = 1f;

    public GameObject Habitat;

    protected Vector2 targetPosition;

    protected abstract void SetRandomTargetPosition();

    protected abstract void MyAge();

    void Start()
    {
        SetRandomTargetPosition();
        MyAge();
    }

    void Update()
    {
        MoveTowardsTarget();
    }

    void MoveTowardsTarget()
    {
        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        else
        {
            SetRandomTargetPosition();
        }
    }
}

//    public void Eat()
//    {
//        hunger = 0.0f;
//    }

//    public void Breathe()
//    {

//    }

//    public void Drink()
//    {

//    }

//    public void CreateChildren()
//    {

//    }
//}
