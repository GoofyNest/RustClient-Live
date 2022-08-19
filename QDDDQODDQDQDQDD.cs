public class QDDDQODDQDQDQDD : MonoBehaviour // TypeDefIndex: 7261
{	// Fields
	public static Vector3 testPoint; // 0x0
	public static ERCrossings cScr; // 0x10
	public static List<Vector3> ll1; // 0x18
	public static List<Vector3> ll2; // 0x20
	public static List<Vector3> ll3; // 0x28
	public static List<Vector3> ll4; // 0x30
	public static int crossingStructure; // 0x38
	public static List<QDQDOOQQDQODD> roadTypesDynamic; // 0x40
	public static ERModularBase baseScript; // 0x48
	public static List<ERConnectionSibling> siblings; // 0x50
	public static Vector3 crossPointCenter; // 0x58
	public static ERCrossingPrefabs prefabScript; // 0x68
	public static ERConnectionSibling primaryPriorityConnection; // 0x70
	public static ERConnectionSibling secondPriorityConnection; // 0x78
	private static float ᙃ; // 0x80
	private static float ᙄ; // 0x84
	public static List<Vector3> debugEdges; // 0x88
	public static List<Vector3> debugvecs; // 0x90

	// Methods

	// RVA: 0xD1D790 Offset: 0xD1CB90 VA: 0x180D1D790
	public static List<QDQDOOQQDQODD> OQQCDQOQCD(List<QDQDOOQQDQODD> roadTypes, bool all) { }

	// RVA: 0xD1C830 Offset: 0xD1BC30 VA: 0x180D1C830
	public static void OQODQQQCOC(ERCrossings scr) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void ODODCOOQDO() { }

	// RVA: 0xD06630 Offset: 0xD05A30 VA: 0x180D06630
	public static bool OCODDQQOCQ(List<ERConnectionSibling> siblings, int thisSibling, int OtherSibling, int startLane) { }

	// RVA: 0xD18550 Offset: 0xD17950 VA: 0x180D18550
	public static void OQCDQDQOOO(bool hasLaneControlData) { }

	// RVA: 0xD06550 Offset: 0xD05950 VA: 0x180D06550
	public static ERLaneConnector OCODCDQQOQ(ERCrossings scr, int startConnectionIndex, int startLaneIndex, int endConnectionIndex, int endLaneIndex, bool stop) { }

	// RVA: 0xD1D9A0 Offset: 0xD1CDA0 VA: 0x180D1D9A0
	public static void OQQDCODOQD(ERCrossingPrefabs scr, ref ERLaneConnector conn, int startConnectionIndex) { }

	// RVA: 0xD20820 Offset: 0xD1FC20 VA: 0x180D20820
	public static bool OQQQQQODQD(Vector3 left, Vector3 rightStart, Vector3 rightEnd, ref float angle1, float prevAngle1, float angle2, bool flag) { }

	// RVA: 0xD16560 Offset: 0xD15960 VA: 0x180D16560
	public static Vector3 OODQQDCDCD(float distance, float angle) { }

	// RVA: 0xD1C030 Offset: 0xD1B430 VA: 0x180D1C030
	public static void OQDOCDCQCD(Vector3 cp, float roadWidth, ref Vector3 lStart, ref Vector3 lEnd, ref Vector3 rStart, ref Vector3 rEnd, float largestRadius) { }

	// RVA: 0xD02230 Offset: 0xD01630 VA: 0x180D02230
	public static void GetOCOCQCDDCD(Vector3 cp, float radius, int cornerSegments, Vector3 leftPoint, Vector3 rightPoint, ref List<Vector3> leftpoints, ref List<Vector3> rightpoints, bool flag) { }

	// RVA: 0xD0F2B0 Offset: 0xD0E6B0 VA: 0x180D0F2B0
	private static void OOCCQCDQQC(List<Vector3> rightPoints1, List<Vector3> leftPoints1, List<Vector3> leftPoints2, List<Vector3> rightPoints2, ref List<Vector3> outerpoints, ref List<Vector3> innerpoints, float dist) { }

	// RVA: 0xD16E40 Offset: 0xD16240 VA: 0x180D16E40
	private void OOOQOQODDD(ref float uvRatio, ref List<Vector3> priorityLeftPoints, ref List<Vector3> priorityRightPoints, ref List<Vector3> rightRoundingPoints, ref List<Vector3> leftRoundingPoints, ref List<Vector3> leftRoundingPointsOther, ref List<Vector3> rightRoundingPointsOther) { }

	// RVA: 0xD12010 Offset: 0xD11410 VA: 0x180D12010
	private static bool OOCOCOCDQD(float radius, int cornerSegments, Vector3 startPoint, Vector3 endPoint, ref List<Vector3> points, ref List<Vector3> priorityPoints, float curvature, bool swapflag, bool priorityIsSingleSection, Vector3 prioritySectionDir, int leftright, bool leftRightCheck, ref int mainIndex, ref bool insertFlag) { }

	// RVA: 0xD02F60 Offset: 0xD02360 VA: 0x180D02F60
	private static void MatchLeftRights(ref List<Vector3> leftRoundingPoints, Vector3 lStart, ref List<Vector3> rightRoundingPoints, Vector3 rStart) { }

	// RVA: 0xD0FD50 Offset: 0xD0F150 VA: 0x180D0FD50
	public static void OOCDCOQDDO(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<List<Vector3>> roadVecs, List<Vector2> roadShape, int leftFixedPoint, int rightFixedPoint, int middleIndex, Vector3 cp, Vector3 cp1, ref List<Vector3> priorityPointsMain, ERConnectionSibling prioritySibling, bool isSecondary) { }

	// RVA: 0xD11ED0 Offset: 0xD112D0 VA: 0x180D11ED0
	public static bool OOCOCCQDCQ(Vector3 v, List<Vector3> points, int firstIndex, int lastIndex) { }

	// RVA: 0xD15BD0 Offset: 0xD14FD0 VA: 0x180D15BD0
	public static void OODQCOCOQD(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<List<Vector3>> roadVecs, List<Vector2> roadShape, int leftFixedPoint, int rightFixedPoint, int middleIndex, Vector3 cp, Vector3 cp1) { }

	// RVA: 0xD20290 Offset: 0xD1F690 VA: 0x180D20290
	public static void OQQDQCQCDQ(List<Vector3> roundingPoints, ref List<Vector3> pointsIndents, float indent, Vector3 lp, Vector3 rp, bool leftSide) { }

	// RVA: 0xD18120 Offset: 0xD17520 VA: 0x180D18120
	public static void OOQQOOOQOO(ref List<Vector3> centerPoints, List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> rightRoundingPoints, List<Vector3> rightPointsIndents, Vector3 cp) { }

	// RVA: 0xD0E730 Offset: 0xD0DB30 VA: 0x180D0E730
	public static void OOCCDOCDDC(ref List<Vector3> centerPoints, List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> rightRoundingPoints, List<Vector3> rightPointsIndents) { }

	// RVA: 0xD02C60 Offset: 0xD02060 VA: 0x180D02C60
	public static void MatchInnerOCOCQCDDCD(ref List<Vector3> innerArray, List<Vector3> startVecs, List<Vector3> endVecs) { }

	// RVA: 0xD09B40 Offset: 0xD08F40 VA: 0x180D09B40
	public static void ODDCCDQDCO(ref List<Vector3> targetArray, List<Vector3> otherArray) { }

	// RVA: 0xD007F0 Offset: 0xCFFBF0 VA: 0x180D007F0
	public static void ERODOCDOOCCC(List<List<Vector3>> roadVecs, List<float> shapeUVs, ref List<List<Vector2>> uvs, List<Vector3> priorityPointsMain, ref List<Vector2> priorityPointsMainUVs, Vector2 cp, float uvRatio, ERConnectionSibling sibling, bool primarySection) { }

	// RVA: 0xD09440 Offset: 0xD08840 VA: 0x180D09440
	public static void OCQODCQDOD(List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> centerPoints, List<Vector3> rightPointsIndents, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> leftPointsIndentsUV, ref List<Vector2> centerPointsUV, ref List<Vector2> rightPointsIndentsUV, ref List<Vector2> rightRoundingPointsUV, ref Vector2 cp, float leftIndentUVX, float rightIndentUVX) { }

	// RVA: 0xD06C20 Offset: 0xD06020 VA: 0x180D06C20
	public static void OCOQCCQCCC(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> rightRoundingPointsUV) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void OOCDCQQQCD(ref List<Vector3> leftRoundingPoints, ref List<Vector3> rightRoundingPoints, ref List<Vector3> centerPoints, ref Vector3 cpLeft, ref Vector3 cpRight, List<Vector3> priorityRoad, float cornerRadius, float cornerSegments, Vector3 lStart, Vector3 lEnd, Vector3 rStart, Vector3 rEnd, float leftIndent, float leftIndentUVX, float rightIndent, float rightIndentUVX) { }

	// RVA: 0xD166B0 Offset: 0xD15AB0 VA: 0x180D166B0
	public static void OOOQCOOQDD(List<Vector3> outerPoints, Vector3 pos, ref float uvX, float indentUVX, float indentdist, int leftright) { }

	// RVA: 0xD05ED0 Offset: 0xD052D0 VA: 0x180D05ED0
	public static void OCOCCCCDOO(ref List<Vector3> indentPoints, List<Vector3> outerPoints, List<Vector3> priorityConnectionPoints, int leftright) { }

	// RVA: 0xD1C4F0 Offset: 0xD1B8F0 VA: 0x180D1C4F0
	public static void OQDQCQCDQQ(ref List<Vector3> centerPoints, List<Vector3> priorityConnectionPoints) { }

	// RVA: 0xD0AB90 Offset: 0xD09F90 VA: 0x180D0AB90
	public static void ODDDOCDCQO(List<ERConnectionSibling> priorityRoads, List<ERConnectionSibling> primaryRoads) { }

	// RVA: 0xD1CED0 Offset: 0xD1C2D0 VA: 0x180D1CED0
	public static void OQOQDQDOOO(Transform tr, ERConnectionSibling sibling, int index) { }

	// RVA: 0xD0C720 Offset: 0xD0BB20 VA: 0x180D0C720
	public static void ODODQCDCOD(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD09BF0 Offset: 0xD08FF0 VA: 0x180D09BF0
	public static void ODDCQODOCD(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD1B7B0 Offset: 0xD1ABB0 VA: 0x180D1B7B0
	private static void OQCDQQOCOC(int curLeft, int endLeft, int curRight, int endRight, List<Vector3> vecs, ref List<int> tris, ERConnectionSibling sibling) { }

	// RVA: 0xD16A80 Offset: 0xD15E80 VA: 0x180D16A80
	private static void OOOQCQDCDD(int curLeft, int endLeft, int curRight, int endRight, List<int> rightInts, List<Vector3> vecs, ref List<int> tris, ERConnectionSibling sibling) { }

	// RVA: 0xD03C70 Offset: 0xD03070 VA: 0x180D03C70
	public static void OCDOQDDCQC(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD0EAE0 Offset: 0xD0DEE0 VA: 0x180D0EAE0
	public static void OOCCQCDDDQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	// RVA: 0xD1BB10 Offset: 0xD1AF10 VA: 0x180D1BB10
	public static void OQCQQDDDCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV) { }

	// RVA: 0xD03AA0 Offset: 0xD02EA0 VA: 0x180D03AA0
	public static void OCDCQDDDCC(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV) { }

	// RVA: 0xD01CC0 Offset: 0xD010C0 VA: 0x180D01CC0
	public static void ForkPriorityOCODCOCODQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV, List<Vector3> mainPoints, List<Vector2> mainPointsUV) { }

	// RVA: 0xD07190 Offset: 0xD06590 VA: 0x180D07190
	private void OCOQOCDCCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	// RVA: 0xD03450 Offset: 0xD02850 VA: 0x180D03450
	private static void MergeMeshDataExt(ref List<List<int>> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs, Material mat, ref List<Material> mats) { }

	// RVA: 0xD08FA0 Offset: 0xD083A0 VA: 0x180D08FA0
	private void OCQODCOQDO(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	// RVA: 0xD20B20 Offset: 0xD1FF20 VA: 0x180D20B20
	public static List<int> Triangulate(List<Vector3> vecs, List<Vector3> edges) { }

	// RVA: 0xD074D0 Offset: 0xD068D0 VA: 0x180D074D0
	public static void OCQDDOQCOQ(QDOODOQQDQODD connection, ERConnectionSibling sibling, int index, int total) { }

	// RVA: 0xD13FA0 Offset: 0xD133A0 VA: 0x180D13FA0
	public static void OOCQCOOOOO(List<ERConnectionSibling> siblings, int index) { }

	// RVA: 0xD20A00 Offset: 0xD1FE00 VA: 0x180D20A00
	public static bool OQQQQQQQCD(QDQDOOQQDQODD roadType) { }

	// RVA: 0xD17C60 Offset: 0xD17060 VA: 0x180D17C60
	public static Vector3 OOQCQDQCOO(int index, Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0xD006E0 Offset: 0xCFFAE0 VA: 0x180D006E0
	public static void Clear() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void OOODDOCOOO() { }

	// RVA: 0xD175C0 Offset: 0xD169C0 VA: 0x180D175C0
	public static void OOOQQDDCCQ(ERTexture roadERTexture, ref float roadWidth, ref float leftIndent, ref float rightIndent, ref float leftUVX, ref float rightUVX, ref float leftIndentInner, ref float rightIndentInner, ref float roadOuterUVXInner, float cornerRadius) { }

	// RVA: 0xD1C750 Offset: 0xD1BB50 VA: 0x180D1C750
	public static void OQOCODDDDC(int connection, QDQDOOQQDQODD roadType) { }

	// RVA: 0xD11D70 Offset: 0xD11170 VA: 0x180D11D70
	public static float OOCDQCOCQO(Vector3 v1, Vector3 v2, Vector3 n) { }

	// RVA: 0xD1D280 Offset: 0xD1C680 VA: 0x180D1D280
	public static Vector3 OQOQODOOCD(Vector3 dirPos1, Vector3 dirPos2, Vector3 currentPos, List<Vector3> vecs, int startend) { }

	// RVA: 0xD0E210 Offset: 0xD0D610 VA: 0x180D0E210
	public static Vector3 ODQQOCDCOC(Vector3 currentPos, List<Vector3> vecs, ref int index, int startend) { }

	// RVA: 0xD206F0 Offset: 0xD1FAF0 VA: 0x180D206F0
	public static bool OQQOCCCOCD(Vector3 p1, Vector3 p2, Vector3 v) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0xD21260 Offset: 0xD20660 VA: 0x180D21260
	private static void .cctor() { }

}

