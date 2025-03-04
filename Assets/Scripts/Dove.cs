using UnityEngine;

public class Dove : Animal
{
    protected override void SetRandomTargetPosition()
    {
        Vector2 referencePos = Habitat.transform.position;

        float minX = referencePos.x - 1f;
        float maxX = referencePos.x + 1f;
        float minY = referencePos.y - 1f;
        float maxY = referencePos.y + 1f;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        targetPosition = new Vector2(randomX, randomY);
    }
    protected override void MyAge()
    {
        age = 5;
        Debug.Log("Dove's Age: " + age);
    }
}

