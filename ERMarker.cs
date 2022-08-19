public class ERMarker // TypeDefIndex: 7286
{	// Fields
	public bool activeSplineNode; // 0x10
	public float leftIndent; // 0x14
	public int leftIndentAlignment; // 0x18
	public float rightIndent; // 0x1C
	public int rightIndentAlignment; // 0x20
	public float leftSurrounding; // 0x24
	public float rightSurrounding; // 0x28
	public bool bridgeObject; // 0x2C
	public float bridgeStartLevelDistance; // 0x30
	public float bridgeEndLevelDistance; // 0x34
	public float rotation; // 0x38
	public Vector3 position; // 0x3C
	public int controlType; // 0x48
	public int rotations; // 0x4C
	public float circularRadius; // 0x50
	public float circularAngle; // 0x54
	public int circularSegments; // 0x58
	public float splineStrength; // 0x5C
	public Vector3 direction; // 0x60
	public Vector3 direction1; // 0x6C
	public bool followTerrainContours; // 0x78
	public int startSplinePoint; // 0x7C
	public float startDistance; // 0x80
	public float startUVY; // 0x84
	public float totalDistance; // 0x88
	public string totalDistanceString; // 0x90
	public string angleString; // 0x98
	public float rotationCenter; // 0xA0
	public List<ERSOMarker> soData; // 0xA8
	public ERMarkerControlType controllerType; // 0xB0
	public bool attachExit; // 0xB4
	public int exitType; // 0xB8
	public int exitGeometryType; // 0xBC
	public int startExitInt; // 0xC0
	public int endExitInt; // 0xC4
	public float startExitOffset; // 0xC8
	public float extrusionDistance; // 0xCC
	public int extrusionType; // 0xD0
	public float fixedDistance; // 0xD4
	public float connectionAngle; // 0xD8
	public float connectionRadius; // 0xDC
	public Material exitMaterial; // 0xE0
	public Material connectionMaterial; // 0xE8
	public int exitRoadType; // 0xF0
	public int connectionRoadType; // 0xF4
	public List<List<Vector3>> exitOuterVerticesExtrusion; // 0xF8
	public List<List<Vector3>> exitOuterVerticesFixed; // 0x100
	public List<List<Vector3>> exitOuterVerticesCurve; // 0x108
	public List<Vector3> exitInnerVertices; // 0x110
	public List<Vector2> roadShape; // 0x118
	public List<Vector3> roadShapeVecsGlobal; // 0x120
	public float markerStartUVY; // 0x128
	public Vector3 perpDir; // 0x12C
	public Vector3 perpDirRotated; // 0x138

	// Methods

	// RVA: 0x99C1E0 Offset: 0x99B5E0 VA: 0x18099C1E0
	public void .ctor(Vector3 pos, ERModularRoad scr, int element) { }

	// RVA: 0x99C190 Offset: 0x99B590 VA: 0x18099C190
	public void SetControlType(ERMarkerControlType type) { }

}

