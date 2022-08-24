public class ERSORoadExt : ScriptableObject // TypeDefIndex: 7229
{
	public SideObject sideObject; 
	public double id; 
	public bool active; 
	public List<Vector3> vecPositions; 
	public bool toggleActive; 
	public bool autoGenerate; 
	public bool markerActive; 
	public float m_distance; 
	public float xPosition; 
	[HideInInspector] 
	public float oldXPosition; 
	public float yPosition; 
	public Vector3 randomRotation; 
	public float randomMinRotation; 
	public float randomMaxRotation; 
	public float minRandomRotationDistance; 
	public float maxRandomRotationDistance; 
	public bool distanceChange; 
	public bool xPosChange; 
	public bool yPosChange; 
	public bool rotationAngleChange; 
	public bool rotationDistanceChange; 
	public bool lockRandomRotations; 
	public bool randomXPositionChange; 
	public bool randomYPositionChange; 
	public bool xPositionDistanceChange; 
	public float randomXPosition; 
	public float randomMinXPosition; 
	public float randomMaxXPosition; 
	public float minRandomXPositionDistance; 
	public float maxRandomXPositionDistance; 
	public Vector3 boxColliderScale; 
	public bool yPositionDistanceChange; 
	public float randomYPosition; 
	public float randomMinYPosition; 
	public float randomMaxYPosition; 
	public float minRandomYPositionDistance; 
	public float maxRandomYPositionDistance; 
	public GameObject sourceObject; 
	public List<ERSOSection> sections; 
	public List<GameObject> objects; 
	public bool clampToMarkers; 


public void Init(SideObject so) { }

public static ERSORoadExt CreateInstance(SideObject so) { }

public static void Copy(ERSORoadExt source, ERSORoadExt target) { }

public void .ctor() { }

}

