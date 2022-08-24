public class BasePathFinder // TypeDefIndex: 8966
{
	private static Vector3[] preferedTopologySamples; 
	private static Vector3[] topologySamples; 
	private Vector3 chosenPosition; 
private const float halfPI = 0,01745329;


public virtual Vector3 GetRandomPatrolPoint() { }

public virtual AIMovePoint GetBestRoamPoint(Vector3 anchorPos, Vector3 currentPos, Vector3 currentDirection, float anchorClampDistance, float lookupMaxRange = 20) { }

public void DebugDraw() { }

public virtual Vector3 GetRandomPositionAround(Vector3 position, float minDistFrom = 0, float maxDistFrom = 2) { }

public static Vector3 GetPointOnCircle(Vector3 center, float radius, float degrees) { }

public void .ctor() { }

private static void .cctor() { }

}

