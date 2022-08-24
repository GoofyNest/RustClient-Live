public class ERMarkerExt : ScriptableObject // TypeDefIndex: 7262
{
	public bool activeSplineNode; 
	public float leftIndent; 
	public int leftIndentAlignment; 
	public float rightIndent; 
	public int rightIndentAlignment; 
	public float leftSurrounding; 
	public float rightSurrounding; 
	public float radius; 
	public bool bridgeObject; 
	public float bridgeStartLevelDistance; 
	public float bridgeEndLevelDistance; 
	public float rotation; 
	public Vector3 position; 
	public Vector3 oldPosition; 
	public Vector3 positionTmp; 
	public int controlType; 
	public int controlTypeTmp; 
	public int rotations; 
	public float circularRadius; 
	public float circularAngle; 
	public int circularSegments; 
	public float splineStrength; 
	public Vector3 direction; 
	public Vector3 direction1; 
	public Vector3 rl; 
	public Vector3 rr; 
	public bool followTerrainContours; 
	public int startSplinePoint; 
	public float startDistance; 
	public float startUVY; 
	public float totalDistance; 
	public string totalDistanceString; 
	public string angleString; 
	public string gradeString; 
	public float rotationCenter; 
	public List<ERSOMarkerExt> soData; 
	public ERMarkerControlType controllerType; 
	public float randomYPosition; 
	public float randomMinYPosition; 
	public float randomMaxYPosition; 
	public float minRandomYPositionDistance; 
	public float maxRandomYPositionDistance; 
	public float randomMinRotation; 
	public float randomMaxRotation; 
	public float minRandomRotationDistance; 
	public float maxRandomRotationDistance; 
	public float prevLeftIndent; 
	public float prevRightIndent; 
	public float prevLeftSurrounding; 
	public float prevRightSurrounding; 
	public int prevControlType; 
	public bool attachExit; 
	public int exitType; 
	public int exitGeometryType; 
	public int startExitInt; 
	public int endExitInt; 
	public float startExitOffset; 
	public float extrusionDistance; 
	public int extrusionType; 
	public float fixedDistance; 
	public float connectionAngle; 
	public float connectionRadius; 
	public Material exitMaterial; 
	public Material connectionMaterial; 
	public int exitRoadType; 
	public int connectionRoadType; 
	public List<List<Vector3>> exitOuterVerticesExtrusion; 
	public List<List<Vector3>> exitOuterVerticesFixed; 
	public List<List<Vector3>> exitOuterVerticesCurve; 
	public List<Vector3> exitInnerVertices; 
	public Color customColor; 
	public List<Vector2> roadShape; 
	public List<Vector3> roadShapeVecsGlobal; 
	public float roadShapeDistanceMin; 
	public float roadShapeDistanceMax; 
	public Vector3 perpDir; 
	public Vector3 perpDirRotated; 
	public float markerStartUVY; 
	public List<Vector3> customPoints; 


	public void Init(Vector3 pos, ERModularRoad scr, int element) { }

	public static ERMarkerExt CreateInstance(Vector3 pos, ERModularRoad scr, int element) { }

	public void SetControlType(ERMarkerControlType type) { }

	public string[] SoNames() { }

	public static void OOQQCOQDQC(ERMarkerExt source, ERMarkerExt target, string name) { }

	public void .ctor() { }

}

