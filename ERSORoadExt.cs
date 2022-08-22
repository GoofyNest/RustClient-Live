public class ERSORoadExt : ScriptableObject // TypeDefIndex: 7229
{	public SideObject sideObject; // 0x18
	public double id; // 0x20
	public bool active; // 0x28
	public List<Vector3> vecPositions; // 0x30
	public bool toggleActive; // 0x38
	public bool autoGenerate; // 0x39
	public bool markerActive; // 0x3A
	public float m_distance; // 0x3C
	public float xPosition; // 0x40
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float oldXPosition; // 0x44
	public float yPosition; // 0x48
	public Vector3 randomRotation; // 0x4C
	public float randomMinRotation; // 0x58
	public float randomMaxRotation; // 0x5C
	public float minRandomRotationDistance; // 0x60
	public float maxRandomRotationDistance; // 0x64
	public bool distanceChange; // 0x68
	public bool xPosChange; // 0x69
	public bool yPosChange; // 0x6A
	public bool rotationAngleChange; // 0x6B
	public bool rotationDistanceChange; // 0x6C
	public bool lockRandomRotations; // 0x6D
	public bool randomXPositionChange; // 0x6E
	public bool randomYPositionChange; // 0x6F
	public bool xPositionDistanceChange; // 0x70
	public float randomXPosition; // 0x74
	public float randomMinXPosition; // 0x78
	public float randomMaxXPosition; // 0x7C
	public float minRandomXPositionDistance; // 0x80
	public float maxRandomXPositionDistance; // 0x84
	public Vector3 boxColliderScale; // 0x88
	public bool yPositionDistanceChange; // 0x94
	public float randomYPosition; // 0x98
	public float randomMinYPosition; // 0x9C
	public float randomMaxYPosition; // 0xA0
	public float minRandomYPositionDistance; // 0xA4
	public float maxRandomYPositionDistance; // 0xA8
	public GameObject sourceObject; // 0xB0
	public List<ERSOSection> sections; // 0xB8
	public List<GameObject> objects; // 0xC0
	public bool clampToMarkers; // 0xC8


	public void Init(SideObject so) { }

	public static ERSORoadExt CreateInstance(SideObject so) { }

	public static void Copy(ERSORoadExt source, ERSORoadExt target) { }

	public void .ctor() { }

}

