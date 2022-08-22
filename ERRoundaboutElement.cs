public class ERRoundaboutElement // TypeDefIndex: 7174
{	public float roadWidth; // 0x10
	public float prevRoadWidth; // 0x14
	public int roundingSegments; // 0x18
	public bool lockLeftRightRoundingRadius; // 0x1C
	public float leftRoundingRadius; // 0x20
	public float prevLeftRoundingRadius; // 0x24
	public float rightRoundingRadius; // 0x28
	public float prevRightRoundingRadius; // 0x2C
	public float connectionLength; // 0x30
	public int centerInt; // 0x34
	public int prevCenterInt; // 0x38
	public float positionPercentage; // 0x3C
	public int leftOuterInt; // 0x40
	public int rightOuterInt; // 0x44
	public int intsFromCenter; // 0x48
	public List<Vector3> leftOuterSegments; // 0x50
	public List<Vector3> leftInnerSegments; // 0x58
	public List<Vector3> rightOuterSegments; // 0x60
	public List<Vector3> rightInnerSegments; // 0x68
	public List<Vector2> leftOuterSegmentsUVs; // 0x70
	public List<Vector2> leftInnerSegmentsUVs; // 0x78
	public List<Vector2> rightOuterSegmentsUVs; // 0x80
	public List<Vector2> rightInnerSegmentsUVs; // 0x88
	public List<List<Vector3>> leftSidewalkV3; // 0x90
	public List<List<Vector3>> rightSidewalkV3; // 0x98
	public List<List<Vector2>> leftSidewalkUV; // 0xA0
	public List<List<Vector2>> rightSidewalkUV; // 0xA8
	public List<List<int>> leftSidewalkTris; // 0xB0
	public List<List<int>> rightSidewalkTris; // 0xB8
	public List<int> leftSidewalkNormalsStart; // 0xC0
	public List<int> leftSidewalkNormalsEnd; // 0xC8
	public List<int> rightSidewalkNormalsStart; // 0xD0
	public List<int> rightSidewalkNormalsEnd; // 0xD8
	public List<List<int>> roadConnectionTris; // 0xE0
	public List<Vector3> leftSidewalkSourceVecs; // 0xE8
	public List<Vector3> rightSidewalkSourceVecs; // 0xF0
	public Vector3 outerCenterPoint; // 0xF8
	public List<Vector3> innerRoundaboutPoints; // 0x108
	public List<Vector2> innerRoundaboutUVs; // 0x110
	public bool leftFlag; // 0x118
	public bool rightFlag; // 0x119
	public bool blendFlag; // 0x11A
	public Material roadMaterial; // 0x120
	public Material connectionMaterial; // 0x128
	public int prefabElement; // 0x130
	public List<int> connectionVecInts; // 0x138
	public List<int> fullConnectionVecInts; // 0x140
	public Vector3 centerPoint; // 0x148
	public Vector3 controlPointV3; // 0x154
	public List<Vector2> roadShapeVecs; // 0x160
	public string roadShapeVecsString; // 0x168
	public List<float> roadShapeUVY; // 0x170
	public List<int> blendCornerPointInts; // 0x178
	public List<float> blendCornerPointWeights; // 0x180
	public Vector3 sceneSelectionV3; // 0x188
	public Vector3 sceneSelectionV3Global; // 0x194
	public List<Vector3> rightIndentvecs; // 0x1A0
	public List<Vector3> rightSurroundingvecs; // 0x1A8
	public List<Vector3> leftIndentvecs; // 0x1B0
	public List<Vector3> leftSurroundingvecs; // 0x1B8
	public int rightIndentBorderInt; // 0x1C0
	public int leftIndentBorderInt; // 0x1C4
	public double roadType; // 0x1C8
	public double prevRoadType; // 0x1D0
	public double roadTypeTimestamp; // 0x1D8
	public double prevTimestamp; // 0x1E0


	public void .ctor() { }

}

