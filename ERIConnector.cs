public class ERIConnector : MonoBehaviour // TypeDefIndex: 7224
{	// Fields
	public float roadWidth1; // 0x18
	public float leftIndentInner1; // 0x1C
	public float leftIndent1; // 0x20
	public float leftUVXInner1; // 0x24
	public float leftUVX1; // 0x28
	public float rightUVX1; // 0x2C
	public float rightUVXInner1; // 0x30
	public float rightIndentInner1; // 0x34
	public float rightIndent1; // 0x38
	public float cornerRadius1; // 0x3C
	public int cornerSegments1; // 0x40
	public float angle1; // 0x44
	public float prevAngle1; // 0x48
	public Material road1Material; // 0x50
	public Material road1MaterialActive; // 0x58
	public int roadType1; // 0x60
	public double roadType1ID; // 0x68
	public ERTexture road1ERTexture; // 0x70
	private float ᙃ; // 0x78
	private float ᙄ; // 0x7C
	private float ᙅ; // 0x80
	private float 4AAAA; // 0x84
	public float road1Stretch; // 0x88
	public int road1StretchType; // 0x8C
	public int subdivide1; // 0x90
	public float roadWidth2; // 0x94
	public float leftIndentInner2; // 0x98
	public float leftIndent2; // 0x9C
	public float leftUVXInner2; // 0xA0
	public float leftUVX2; // 0xA4
	public float rightUVX2; // 0xA8
	public float rightUVXInner2; // 0xAC
	public float rightIndentInner2; // 0xB0
	public float rightIndent2; // 0xB4
	public float cornerRadius2; // 0xB8
	public int cornerSegments2; // 0xBC
	public float angle2; // 0xC0
	public float prevAngle2; // 0xC4
	public Material road2Material; // 0xC8
	public Material road2MaterialActive; // 0xD0
	public int roadType2; // 0xD8
	public double roadType2ID; // 0xE0
	public ERTexture road2ERTexture; // 0xE8
	private float 5AAA1; // 0xF0
	private float 6AAAA; // 0xF4
	private float 7AAA1; // 0xF8
	private float 8AAAA; // 0xFC
	public float road2Stretch; // 0x100
	public int road2StretchType; // 0x104
	public int subdivide2; // 0x108
	public float resolution; // 0x10C
	public int crossingStructure; // 0x110
	public bool blend; // 0x114
	public int textureType; // 0x118
	public int roadStructureType; // 0x11C
	public string[] crossingStructureStrings; // 0x120
	public bool clampUVs; // 0x128
	public float attachAngle; // 0x12C
	public List<QDQDOOQQDQODD> roadTypesDynamic; // 0x130
	public List<Vector3> splinePoints1; // 0x138
	public List<Vector3> splinePoints2; // 0x140
	public List<int> roadShapeMaterialInts1; // 0x148
	public List<int> roadShapeMaterialInts2; // 0x150
	public List<Vector3> leftRoundingPoints1; // 0x158
	public List<Vector3> centerPoints1; // 0x160
	public List<Vector3> rightRoundingPoints1; // 0x168
	public List<Vector3> leftPointsIndents1; // 0x170
	public List<Vector3> rightPointsIndents1; // 0x178
	public List<Vector3> middlePoints1; // 0x180
	public List<Vector3> leftPoints13; // 0x188
	public List<Vector3> rightPoints12; // 0x190
	public List<Vector2> leftRoundingPointsUV1; // 0x198
	private List<Vector2> 9AAA1; // 0x1A0
	public List<Vector2> rightRoundingPointsUV1; // 0x1A8
	public List<Vector2> leftPointsIndentsUV1; // 0x1B0
	public List<Vector2> rightPointsIndentsUV1; // 0x1B8
	public List<Vector3> leftRoundingPoints2; // 0x1C0
	public List<Vector3> centerPoints2; // 0x1C8
	public List<Vector3> rightRoundingPoints2; // 0x1D0
	public List<Vector3> leftPointsIndents2; // 0x1D8
	public List<Vector3> rightPointsIndents2; // 0x1E0
	public List<Vector3> middlePoints2; // 0x1E8
	public List<Vector3> rightPoints23; // 0x1F0
	public List<Vector2> leftRoundingPointsUV2; // 0x1F8
	private List<Vector2> BAAAA; // 0x200
	public List<Vector2> rightRoundingPointsUV2; // 0x208
	public List<Vector2> leftPointsIndentsUV2; // 0x210
	public List<Vector2> rightPointsIndentsUV2; // 0x218
	public List<Vector3> priorityConnectionPoints; // 0x220
	public List<Vector2> priorityConnectionPointsUV; // 0x228
	public float minAngle12; // 0x230
	public float minAngle13; // 0x234
	public float minAngle23; // 0x238
	public Vector2 cpUV1; // 0x23C
	public Vector2 cpUV2; // 0x244
	public Vector2 cpUV3; // 0x24C
	public List<Vector3> ll1; // 0x258
	public List<Vector3> ll2; // 0x260
	public List<Vector3> ll3; // 0x268
	public List<Vector3> ll4; // 0x270
	public Vector3 l1Start; // 0x278
	public Vector3 l1End; // 0x284
	public Vector3 l2Start; // 0x290
	public Vector3 l2End; // 0x29C
	public Vector3 l3Start; // 0x2A8
	public Vector3 l3End; // 0x2B4
	public Vector3 r1Start; // 0x2C0
	public Vector3 r1End; // 0x2CC
	public Vector3 r2Start; // 0x2D8
	public Vector3 r2End; // 0x2E4
	public Vector3 r3Start; // 0x2F0
	public Vector3 r3End; // 0x2FC
	public Vector3 ip12; // 0x308
	public Vector3 ip23; // 0x314
	public Vector3 ip13; // 0x320
	public Vector3 ip13Left; // 0x32C
	public Vector3 ip12right; // 0x338
	public Vector3 ip23right; // 0x344
	public Vector3 cp1Left; // 0x350
	public Vector3 cp1Right; // 0x35C
	public Vector3 cp2Left; // 0x368
	public Vector3 cp2Right; // 0x374
	public Vector3 cp3Left; // 0x380
	public Vector3 cp3Right; // 0x38C
	public bool lock1; // 0x398
	public bool lock2; // 0x399
	public bool lock3; // 0x39A
	private float CAAA1; // 0x39C
	private float 00AAA; // 0x3A0
	public ERModularRoad road1; // 0x3A8
	public ERModularRoad road2; // 0x3B0
	public List<Vector2> roadShape1; // 0x3B8
	public List<Vector2> roadShape2; // 0x3C0
	public List<float> roadShapeUVs1; // 0x3C8
	public List<float> roadShapeUVs2; // 0x3D0
	public List<Material> roadMaterials1; // 0x3D8
	public List<Material> roadMaterials2; // 0x3E0
	public List<Vector3> leftPoints; // 0x3E8
	public List<Vector3> rightPoints; // 0x3F0
	public float connectorLength1; // 0x3F8
	public float connectorLength2; // 0x3FC
	public float blendDistance; // 0x400
	public int blendSection; // 0x404
	public bool triangleStrip; // 0x408
	public float triangleStripDistance; // 0x40C
	public float triangleStripUVStart; // 0x410
	public float triangleStripUVEnd; // 0x414
	public Material triangleStripMaterial; // 0x418
	public Material blendMaterial; // 0x420
	public Material transitionMaterial; // 0x428
	public bool transitionSwap; // 0x430
	public int proceduralMaterialIndex; // 0x434
	public bool presetSwapped; // 0x438
	public float t1; // 0x43C
	public float t2; // 0x440
	public GameObject go1; // 0x448
	public GameObject go2; // 0x450
	public GameObject go3; // 0x458
	public GameObject go4; // 0x460
	public ERCrossingPrefabs prefabScript; // 0x468
	public List<Vector3> surfaceVecs; // 0x470
	public Vector3 testPoint; // 0x478
	public GameObject surfaceMesh; // 0x488
	public ERModularBase baseScript; // 0x490
	public Vector3 centerDir; // 0x498
	public Vector3 cp1; // 0x4A4
	public Vector3 cp2; // 0x4B0
	public Vector3 cp3; // 0x4BC
	public Vector3 cp4; // 0x4C8
	public Vector3 tv; // 0x4D4
	public List<Vector3> tvecs; // 0x4E0

	// Methods

	// RVA: 0x999410 Offset: 0x998810 VA: 0x180999410
	public void UpdateERTexture(int road) { }

	// RVA: 0x9908D0 Offset: 0x98FCD0 VA: 0x1809908D0
	public void OCQOQCDCQC(ERModularRoad sourceRoad) { }

	// RVA: 0x98B620 Offset: 0x98AA20 VA: 0x18098B620
	public void GetIConnectionData(List<Vector3> vecs1, List<bool> conInts1, List<bool> conInts2, bool reversed1, bool reversed2, int road2Start) { }

	// RVA: 0x98DF30 Offset: 0x98D330 VA: 0x18098DF30
	public void GetLeftRightInts(List<Vector2> roadShape, ref int mostLeftInt, ref int mostRightInt) { }

	// RVA: 0x996FC0 Offset: 0x9963C0 VA: 0x180996FC0
	public void OQQCQCCODO(List<Vector3> splinePoints, List<Vector3> splinePointsOther, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<List<int>> tris, List<Vector2> roadShape, List<float> roadShapeUVs, List<int> roadShapeMaterialInts, float uvRatio, float stretchRatio, float stretchType, ref List<Vector3> leftPoints, ref List<Vector3> rightPoints, bool reversed, Vector3 cDir, int firstSecond, int startEnd) { }

	// RVA: 0x995E40 Offset: 0x995240 VA: 0x180995E40
	public List<Vector2> OODCQQQQCQ(float startY, List<Vector3> splinePoints, List<float> roadShapeUVs, float uvRatio, bool reversed, float sourceUV) { }

	// RVA: 0x990070 Offset: 0x98F470 VA: 0x180990070
	public void OCOQOQOCOQ(ref List<Color> colors, List<Vector3> splinePoints1, List<Vector3> splinePoints2, List<Vector2> roadShape1, List<Vector2> roadShape2) { }

	// RVA: 0x995930 Offset: 0x994D30 VA: 0x180995930
	public void ODDCCDQDCO(ref List<Vector3> targetArray, List<Vector3> otherArray) { }

	// RVA: 0x9985D0 Offset: 0x9979D0 VA: 0x1809985D0
	public void SetUVS(List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> centerPoints, List<Vector3> rightPointsIndents, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> leftPointsIndentsUV, ref List<Vector2> centerPointsUV, ref List<Vector2> rightPointsIndentsUV, ref List<Vector2> rightRoundingPointsUV, ref Vector2 cp, float leftIndentUVX, float rightIndentUVX) { }

	// RVA: 0x9959E0 Offset: 0x994DE0 VA: 0x1809959E0
	public Mesh ODDDOCDCQO() { }

	// RVA: 0x98FD30 Offset: 0x98F130 VA: 0x18098FD30
	private void OCOQOCDCCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	// RVA: 0x990430 Offset: 0x98F830 VA: 0x180990430
	private void OCQODCOQDO(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	// RVA: 0x998CE0 Offset: 0x9980E0 VA: 0x180998CE0
	private List<int> Triangulate(List<Vector3> vecs, List<Vector3> edges) { }

	// RVA: 0x996AD0 Offset: 0x995ED0 VA: 0x180996AD0
	public List<Vector3> OQDDOOOOQD(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float tension, float res, float distance, ref float tValue) { }

	// RVA: 0x996790 Offset: 0x995B90 VA: 0x180996790
	public void OQCDDQOCOD(ref List<Vector3> splinePoints, float distance) { }

	// RVA: 0x98B130 Offset: 0x98A530 VA: 0x18098B130
	public void Clear() { }

	// RVA: 0x9961B0 Offset: 0x9955B0 VA: 0x1809961B0
	public void OOODDOCOOO() { }

	// RVA: 0x9966B0 Offset: 0x995AB0 VA: 0x1809966B0
	public void OOOQQDDCCQ(ERTexture roadERTexture, ref float roadWidth, ref float leftIndent, ref float rightIndent, ref float leftUVX, ref float rightUVX, ref float leftIndentInner, ref float rightIndentInner, ref float roadOuterUVXInner, float cornerRadius) { }

	// RVA: 0x98E060 Offset: 0x98D460 VA: 0x18098E060
	public static void OCDCCQQQCO(List<Vector3> leftPoints, List<Vector3> rightPoints, ref GameObject surfaceMesh, Transform tr, ref List<Vector3> surfaceVecs, float indentLeftStart, float indentLeftEnd, float surroundingLeftStart, float surroundingLeftEnd, float indentRightStart, float indentRightEnd, float surroundingRightStart, float surroundingRightEnd, ERModularBase baseScript, bool hasMesh) { }

	// RVA: 0x9995D0 Offset: 0x9989D0 VA: 0x1809995D0
	public void .ctor() { }

}

