public class ERMarkerExt : ScriptableObject // TypeDefIndex: 7262
{	public bool activeSplineNode; // 0x18
	public float leftIndent; // 0x1C
	public int leftIndentAlignment; // 0x20
	public float rightIndent; // 0x24
	public int rightIndentAlignment; // 0x28
	public float leftSurrounding; // 0x2C
	public float rightSurrounding; // 0x30
	public float radius; // 0x34
	public bool bridgeObject; // 0x38
	public float bridgeStartLevelDistance; // 0x3C
	public float bridgeEndLevelDistance; // 0x40
	public float rotation; // 0x44
	public Vector3 position; // 0x48
	public Vector3 oldPosition; // 0x54
	public Vector3 positionTmp; // 0x60
	public int controlType; // 0x6C
	public int controlTypeTmp; // 0x70
	public int rotations; // 0x74
	public float circularRadius; // 0x78
	public float circularAngle; // 0x7C
	public int circularSegments; // 0x80
	public float splineStrength; // 0x84
	public Vector3 direction; // 0x88
	public Vector3 direction1; // 0x94
	public Vector3 rl; // 0xA0
	public Vector3 rr; // 0xAC
	public bool followTerrainContours; // 0xB8
	public int startSplinePoint; // 0xBC
	public float startDistance; // 0xC0
	public float startUVY; // 0xC4
	public float totalDistance; // 0xC8
	public string totalDistanceString; // 0xD0
	public string angleString; // 0xD8
	public string gradeString; // 0xE0
	public float rotationCenter; // 0xE8
	public List<ERSOMarkerExt> soData; // 0xF0
	public ERMarkerControlType controllerType; // 0xF8
	public float randomYPosition; // 0xFC
	public float randomMinYPosition; // 0x100
	public float randomMaxYPosition; // 0x104
	public float minRandomYPositionDistance; // 0x108
	public float maxRandomYPositionDistance; // 0x10C
	public float randomMinRotation; // 0x110
	public float randomMaxRotation; // 0x114
	public float minRandomRotationDistance; // 0x118
	public float maxRandomRotationDistance; // 0x11C
	public float prevLeftIndent; // 0x120
	public float prevRightIndent; // 0x124
	public float prevLeftSurrounding; // 0x128
	public float prevRightSurrounding; // 0x12C
	public int prevControlType; // 0x130
	public bool attachExit; // 0x134
	public int exitType; // 0x138
	public int exitGeometryType; // 0x13C
	public int startExitInt; // 0x140
	public int endExitInt; // 0x144
	public float startExitOffset; // 0x148
	public float extrusionDistance; // 0x14C
	public int extrusionType; // 0x150
	public float fixedDistance; // 0x154
	public float connectionAngle; // 0x158
	public float connectionRadius; // 0x15C
	public Material exitMaterial; // 0x160
	public Material connectionMaterial; // 0x168
	public int exitRoadType; // 0x170
	public int connectionRoadType; // 0x174
	public List<List<Vector3>> exitOuterVerticesExtrusion; // 0x178
	public List<List<Vector3>> exitOuterVerticesFixed; // 0x180
	public List<List<Vector3>> exitOuterVerticesCurve; // 0x188
	public List<Vector3> exitInnerVertices; // 0x190
	public Color customColor; // 0x198
	public List<Vector2> roadShape; // 0x1A8
	public List<Vector3> roadShapeVecsGlobal; // 0x1B0
	public float roadShapeDistanceMin; // 0x1B8
	public float roadShapeDistanceMax; // 0x1BC
	public Vector3 perpDir; // 0x1C0
	public Vector3 perpDirRotated; // 0x1CC
	public float markerStartUVY; // 0x1D8
	public List<Vector3> customPoints; // 0x1E0


	public void Init(Vector3 pos, ERModularRoad scr, int element) { }

	public static ERMarkerExt CreateInstance(Vector3 pos, ERModularRoad scr, int element) { }

	public void SetControlType(ERMarkerControlType type) { }

	public string[] SoNames() { }

	public static void OOQQCOQDQC(ERMarkerExt source, ERMarkerExt target, string name) { }

	public void .ctor() { }

}

