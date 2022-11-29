public class ERIConnector : MonoBehaviour // TypeDefIndex: 7236
{
	public float roadWidth1; 
	public float leftIndentInner1; 
	public float leftIndent1; 
	public float leftUVXInner1; 
	public float leftUVX1; 
	public float rightUVX1; 
	public float rightUVXInner1; 
	public float rightIndentInner1; 
	public float rightIndent1; 
	public float cornerRadius1; 
	public int cornerSegments1; 
	public float angle1; 
	public float prevAngle1; 
	public Material road1Material; 
	public Material road1MaterialActive; 
	public int roadType1; 
	public double roadType1ID; 
	public ERTexture road1ERTexture; 
	private float ᙃ; 
	private float ᙄ; 
	private float ᙅ; 
	private float 4AAAA; 
	public float road1Stretch; 
	public int road1StretchType; 
	public int subdivide1; 
	public float roadWidth2; 
	public float leftIndentInner2; 
	public float leftIndent2; 
	public float leftUVXInner2; 
	public float leftUVX2; 
	public float rightUVX2; 
	public float rightUVXInner2; 
	public float rightIndentInner2; 
	public float rightIndent2; 
	public float cornerRadius2; 
	public int cornerSegments2; 
	public float angle2; 
	public float prevAngle2; 
	public Material road2Material; 
	public Material road2MaterialActive; 
	public int roadType2; 
	public double roadType2ID; 
	public ERTexture road2ERTexture; 
	private float 5AAA1; 
	private float 6AAAA; 
	private float 7AAA1; 
	private float 8AAAA; 
	public float road2Stretch; 
	public int road2StretchType; 
	public int subdivide2; 
	public float resolution; 
	public int crossingStructure; 
	public bool blend; 
	public int textureType; 
	public int roadStructureType; 
	public string[] crossingStructureStrings; 
	public bool clampUVs; 
	public float attachAngle; 
	public List<QDQDOOQQDQODD> roadTypesDynamic; 
	public List<Vector3> splinePoints1; 
	public List<Vector3> splinePoints2; 
	public List<int> roadShapeMaterialInts1; 
	public List<int> roadShapeMaterialInts2; 
	public List<Vector3> leftRoundingPoints1; 
	public List<Vector3> centerPoints1; 
	public List<Vector3> rightRoundingPoints1; 
	public List<Vector3> leftPointsIndents1; 
	public List<Vector3> rightPointsIndents1; 
	public List<Vector3> middlePoints1; 
	public List<Vector3> leftPoints13; 
	public List<Vector3> rightPoints12; 
	public List<Vector2> leftRoundingPointsUV1; 
	private List<Vector2> 9AAA1; 
	public List<Vector2> rightRoundingPointsUV1; 
	public List<Vector2> leftPointsIndentsUV1; 
	public List<Vector2> rightPointsIndentsUV1; 
	public List<Vector3> leftRoundingPoints2; 
	public List<Vector3> centerPoints2; 
	public List<Vector3> rightRoundingPoints2; 
	public List<Vector3> leftPointsIndents2; 
	public List<Vector3> rightPointsIndents2; 
	public List<Vector3> middlePoints2; 
	public List<Vector3> rightPoints23; 
	public List<Vector2> leftRoundingPointsUV2; 
	private List<Vector2> BAAAA; 
	public List<Vector2> rightRoundingPointsUV2; 
	public List<Vector2> leftPointsIndentsUV2; 
	public List<Vector2> rightPointsIndentsUV2; 
	public List<Vector3> priorityConnectionPoints; 
	public List<Vector2> priorityConnectionPointsUV; 
	public float minAngle12; 
	public float minAngle13; 
	public float minAngle23; 
	public Vector2 cpUV1; 
	public Vector2 cpUV2; 
	public Vector2 cpUV3; 
	public List<Vector3> ll1; 
	public List<Vector3> ll2; 
	public List<Vector3> ll3; 
	public List<Vector3> ll4; 
	public Vector3 l1Start; 
	public Vector3 l1End; 
	public Vector3 l2Start; 
	public Vector3 l2End; 
	public Vector3 l3Start; 
	public Vector3 l3End; 
	public Vector3 r1Start; 
	public Vector3 r1End; 
	public Vector3 r2Start; 
	public Vector3 r2End; 
	public Vector3 r3Start; 
	public Vector3 r3End; 
	public Vector3 ip12; 
	public Vector3 ip23; 
	public Vector3 ip13; 
	public Vector3 ip13Left; 
	public Vector3 ip12right; 
	public Vector3 ip23right; 
	public Vector3 cp1Left; 
	public Vector3 cp1Right; 
	public Vector3 cp2Left; 
	public Vector3 cp2Right; 
	public Vector3 cp3Left; 
	public Vector3 cp3Right; 
	public bool lock1; 
	public bool lock2; 
	public bool lock3; 
	private float CAAA1; 
	private float 00AAA; 
	public ERModularRoad road1; 
	public ERModularRoad road2; 
	public List<Vector2> roadShape1; 
	public List<Vector2> roadShape2; 
	public List<float> roadShapeUVs1; 
	public List<float> roadShapeUVs2; 
	public List<Material> roadMaterials1; 
	public List<Material> roadMaterials2; 
	public List<Vector3> leftPoints; 
	public List<Vector3> rightPoints; 
	public float connectorLength1; 
	public float connectorLength2; 
	public float blendDistance; 
	public int blendSection; 
	public bool triangleStrip; 
	public float triangleStripDistance; 
	public float triangleStripUVStart; 
	public float triangleStripUVEnd; 
	public Material triangleStripMaterial; 
	public Material blendMaterial; 
	public Material transitionMaterial; 
	public bool transitionSwap; 
	public int proceduralMaterialIndex; 
	public bool presetSwapped; 
	public float t1; 
	public float t2; 
	public GameObject go1; 
	public GameObject go2; 
	public GameObject go3; 
	public GameObject go4; 
	public ERCrossingPrefabs prefabScript; 
	public List<Vector3> surfaceVecs; 
	public Vector3 testPoint; 
	public GameObject surfaceMesh; 
	public ERModularBase baseScript; 
	public Vector3 centerDir; 
	public Vector3 cp1; 
	public Vector3 cp2; 
	public Vector3 cp3; 
	public Vector3 cp4; 
	public Vector3 tv; 
	public List<Vector3> tvecs; 


	public void UpdateERTexture(int road) { }

	public void OCQOQCDCQC(ERModularRoad sourceRoad) { }

	public void GetIConnectionData(List<Vector3> vecs1, List<bool> conInts1, List<bool> conInts2, bool reversed1, bool reversed2, int road2Start) { }

	public void GetLeftRightInts(List<Vector2> roadShape, ref int mostLeftInt, ref int mostRightInt) { }

	public void OQQCQCCODO(List<Vector3> splinePoints, List<Vector3> splinePointsOther, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<List<int>> tris, List<Vector2> roadShape, List<float> roadShapeUVs, List<int> roadShapeMaterialInts, float uvRatio, float stretchRatio, float stretchType, ref List<Vector3> leftPoints, ref List<Vector3> rightPoints, bool reversed, Vector3 cDir, int firstSecond, int startEnd) { }

	public List<Vector2> OODCQQQQCQ(float startY, List<Vector3> splinePoints, List<float> roadShapeUVs, float uvRatio, bool reversed, float sourceUV) { }

	public void OCOQOQOCOQ(ref List<Color> colors, List<Vector3> splinePoints1, List<Vector3> splinePoints2, List<Vector2> roadShape1, List<Vector2> roadShape2) { }

	public void ODDCCDQDCO(ref List<Vector3> targetArray, List<Vector3> otherArray) { }

	public void SetUVS(List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> centerPoints, List<Vector3> rightPointsIndents, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> leftPointsIndentsUV, ref List<Vector2> centerPointsUV, ref List<Vector2> rightPointsIndentsUV, ref List<Vector2> rightRoundingPointsUV, ref Vector2 cp, float leftIndentUVX, float rightIndentUVX) { }

	public Mesh ODDDOCDCQO() { }

	private void OCOQOCDCCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	private void OCQODCOQDO(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	private List<int> Triangulate(List<Vector3> vecs, List<Vector3> edges) { }

	public List<Vector3> OQDDOOOOQD(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float tension, float res, float distance, ref float tValue) { }

	public void OQCDDQOCOD(ref List<Vector3> splinePoints, float distance) { }

	public void Clear() { }

	public void OOODDOCOOO() { }

	public void OOOQQDDCCQ(ERTexture roadERTexture, ref float roadWidth, ref float leftIndent, ref float rightIndent, ref float leftUVX, ref float rightUVX, ref float leftIndentInner, ref float rightIndentInner, ref float roadOuterUVXInner, float cornerRadius) { }

	public static void OCDCCQQQCO(List<Vector3> leftPoints, List<Vector3> rightPoints, ref GameObject surfaceMesh, Transform tr, ref List<Vector3> surfaceVecs, float indentLeftStart, float indentLeftEnd, float surroundingLeftStart, float surroundingLeftEnd, float indentRightStart, float indentRightEnd, float surroundingRightStart, float surroundingRightEnd, ERModularBase baseScript, bool hasMesh) { }

	public void .ctor() { }

}

