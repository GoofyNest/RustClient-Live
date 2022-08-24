public class ERMarker // TypeDefIndex: 7286
{
	public bool activeSplineNode; 
	public float leftIndent; 
	public int leftIndentAlignment; 
	public float rightIndent; 
	public int rightIndentAlignment; 
	public float leftSurrounding; 
	public float rightSurrounding; 
	public bool bridgeObject; 
	public float bridgeStartLevelDistance; 
	public float bridgeEndLevelDistance; 
	public float rotation; 
	public Vector3 position; 
	public int controlType; 
	public int rotations; 
	public float circularRadius; 
	public float circularAngle; 
	public int circularSegments; 
	public float splineStrength; 
	public Vector3 direction; 
	public Vector3 direction1; 
	public bool followTerrainContours; 
	public int startSplinePoint; 
	public float startDistance; 
	public float startUVY; 
	public float totalDistance; 
	public string totalDistanceString; 
	public string angleString; 
	public float rotationCenter; 
	public List<ERSOMarker> soData; 
	public ERMarkerControlType controllerType; 
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
	public List<Vector2> roadShape; 
	public List<Vector3> roadShapeVecsGlobal; 
	public float markerStartUVY; 
	public Vector3 perpDir; 
	public Vector3 perpDirRotated; 


	public void .ctor(Vector3 pos, ERModularRoad scr, int element) { }

	public void SetControlType(ERMarkerControlType type) { }

}

