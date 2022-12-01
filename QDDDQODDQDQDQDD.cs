public class QDDDQODDQDQDQDD : MonoBehaviour // TypeDefIndex: 7275
{
	public static Vector3 testPoint;
	public static ERCrossings cScr;
	public static List<Vector3> ll1;
	public static List<Vector3> ll2;
	public static List<Vector3> ll3;
	public static List<Vector3> ll4;
	public static int crossingStructure;
	public static List<QDQDOOQQDQODD> roadTypesDynamic;
	public static ERModularBase baseScript;
	public static List<ERConnectionSibling> siblings;
	public static Vector3 crossPointCenter;
	public static ERCrossingPrefabs prefabScript;
	public static ERConnectionSibling primaryPriorityConnection;
	public static ERConnectionSibling secondPriorityConnection;
	private static float ᙃ;
	private static float ᙄ;
	public static List<Vector3> debugEdges;
	public static List<Vector3> debugvecs;


	public static List<QDQDOOQQDQODD> OQQCDQOQCD(List<QDQDOOQQDQODD> roadTypes, bool all) { }

	public static void OQODQQQCOC(ERCrossings scr) { }

	public static void ODODCOOQDO() { }

	public static bool OCODDQQOCQ(List<ERConnectionSibling> siblings, int thisSibling, int OtherSibling, int startLane) { }

	public static void OQCDQDQOOO(bool hasLaneControlData) { }

	public static ERLaneConnector OCODCDQQOQ(ERCrossings scr, int startConnectionIndex, int startLaneIndex, int endConnectionIndex, int endLaneIndex, bool stop) { }

	public static void OQQDCODOQD(ERCrossingPrefabs scr, ref ERLaneConnector conn, int startConnectionIndex) { }

	public static bool OQQQQQODQD(Vector3 left, Vector3 rightStart, Vector3 rightEnd, ref float angle1, float prevAngle1, float angle2, bool flag) { }

	public static Vector3 OODQQDCDCD(float distance, float angle) { }

	public static void OQDOCDCQCD(Vector3 cp, float roadWidth, ref Vector3 lStart, ref Vector3 lEnd, ref Vector3 rStart, ref Vector3 rEnd, float largestRadius) { }

	public static void GetOCOCQCDDCD(Vector3 cp, float radius, int cornerSegments, Vector3 leftPoint, Vector3 rightPoint, ref List<Vector3> leftpoints, ref List<Vector3> rightpoints, bool flag) { }

	private static void OOCCQCDQQC(List<Vector3> rightPoints1, List<Vector3> leftPoints1, List<Vector3> leftPoints2, List<Vector3> rightPoints2, ref List<Vector3> outerpoints, ref List<Vector3> innerpoints, float dist) { }

	private void OOOQOQODDD(ref float uvRatio, ref List<Vector3> priorityLeftPoints, ref List<Vector3> priorityRightPoints, ref List<Vector3> rightRoundingPoints, ref List<Vector3> leftRoundingPoints, ref List<Vector3> leftRoundingPointsOther, ref List<Vector3> rightRoundingPointsOther) { }

	private static bool OOCOCOCDQD(float radius, int cornerSegments, Vector3 startPoint, Vector3 endPoint, ref List<Vector3> points, ref List<Vector3> priorityPoints, float curvature, bool swapflag, bool priorityIsSingleSection, Vector3 prioritySectionDir, int leftright, bool leftRightCheck, ref int mainIndex, ref bool insertFlag) { }

	private static void MatchLeftRights(ref List<Vector3> leftRoundingPoints, Vector3 lStart, ref List<Vector3> rightRoundingPoints, Vector3 rStart) { }

	public static void OOCDCOQDDO(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<List<Vector3>> roadVecs, List<Vector2> roadShape, int leftFixedPoint, int rightFixedPoint, int middleIndex, Vector3 cp, Vector3 cp1, ref List<Vector3> priorityPointsMain, ERConnectionSibling prioritySibling, bool isSecondary) { }

	public static bool OOCOCCQDCQ(Vector3 v, List<Vector3> points, int firstIndex, int lastIndex) { }

	public static void OODQCOCOQD(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<List<Vector3>> roadVecs, List<Vector2> roadShape, int leftFixedPoint, int rightFixedPoint, int middleIndex, Vector3 cp, Vector3 cp1) { }

	public static void OQQDQCQCDQ(List<Vector3> roundingPoints, ref List<Vector3> pointsIndents, float indent, Vector3 lp, Vector3 rp, bool leftSide) { }

	public static void OOQQOOOQOO(ref List<Vector3> centerPoints, List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> rightRoundingPoints, List<Vector3> rightPointsIndents, Vector3 cp) { }

	public static void OOCCDOCDDC(ref List<Vector3> centerPoints, List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> rightRoundingPoints, List<Vector3> rightPointsIndents) { }

	public static void MatchInnerOCOCQCDDCD(ref List<Vector3> innerArray, List<Vector3> startVecs, List<Vector3> endVecs) { }

	public static void ODDCCDQDCO(ref List<Vector3> targetArray, List<Vector3> otherArray) { }

	public static void ERODOCDOOCCC(List<List<Vector3>> roadVecs, List<float> shapeUVs, ref List<List<Vector2>> uvs, List<Vector3> priorityPointsMain, ref List<Vector2> priorityPointsMainUVs, Vector2 cp, float uvRatio, ERConnectionSibling sibling, bool primarySection) { }

	public static void OCQODCQDOD(List<Vector3> leftRoundingPoints, List<Vector3> leftPointsIndents, List<Vector3> centerPoints, List<Vector3> rightPointsIndents, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> leftPointsIndentsUV, ref List<Vector2> centerPointsUV, ref List<Vector2> rightPointsIndentsUV, ref List<Vector2> rightRoundingPointsUV, ref Vector2 cp, float leftIndentUVX, float rightIndentUVX) { }

	public static void OCOQCCQCCC(List<Vector3> leftRoundingPoints, List<Vector3> rightRoundingPoints, ref List<Vector2> leftRoundingPointsUV, ref List<Vector2> rightRoundingPointsUV) { }

	public static void OOCDCQQQCD(ref List<Vector3> leftRoundingPoints, ref List<Vector3> rightRoundingPoints, ref List<Vector3> centerPoints, ref Vector3 cpLeft, ref Vector3 cpRight, List<Vector3> priorityRoad, float cornerRadius, float cornerSegments, Vector3 lStart, Vector3 lEnd, Vector3 rStart, Vector3 rEnd, float leftIndent, float leftIndentUVX, float rightIndent, float rightIndentUVX) { }

	public static void OOOQCOOQDD(List<Vector3> outerPoints, Vector3 pos, ref float uvX, float indentUVX, float indentdist, int leftright) { }

	public static void OCOCCCCDOO(ref List<Vector3> indentPoints, List<Vector3> outerPoints, List<Vector3> priorityConnectionPoints, int leftright) { }

	public static void OQDQCQCDQQ(ref List<Vector3> centerPoints, List<Vector3> priorityConnectionPoints) { }

	public static void ODDDOCDCQO(List<ERConnectionSibling> priorityRoads, List<ERConnectionSibling> primaryRoads) { }

	public static void OQOQDQDOOO(Transform tr, ERConnectionSibling sibling, int index) { }

	public static void ODODQCDCOD(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	public static void ODDCQODOCD(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	private static void OQCDQQOCOC(int curLeft, int endLeft, int curRight, int endRight, List<Vector3> vecs, ref List<int> tris, ERConnectionSibling sibling) { }

	private static void OOOQCQDCDD(int curLeft, int endLeft, int curRight, int endRight, List<int> rightInts, List<Vector3> vecs, ref List<int> tris, ERConnectionSibling sibling) { }

	public static void OCDOQDDCQC(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	public static void OOCCQCDDDQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, List<List<Vector3>> vecsData, List<List<Vector2>> uvsData, List<Vector3> priorityPointsMain, List<Vector2> priorityPointsMainUVs, ref List<Color> colors, List<bool> originalShapeVecs, ref List<int> connInts, int totalVecs, ref List<int> secondPriorityInts, bool singleSectionFlag, ERConnectionSibling sibling) { }

	public static void OQCQQDDDCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV) { }

	public static void OCDCQDDDCC(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV) { }

	public static void ForkPriorityOCODCOCODQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, List<Vector3> mleftPoints, List<Vector3> rightPoints, List<Vector3> centerPoints, Vector3 leftPoint, Vector3 rightPoint, List<Vector2> leftRoundingPointsUV, List<Vector2> rightRoundingPointsUV, List<Vector2> centerPointsUV, Vector2 cpUV, List<Vector3> leftPointsIndents, List<Vector2> leftPointsIndentsUV, List<Vector3> rightPointsIndents, List<Vector2> rightPointsIndentsUV, List<Vector3> mainPoints, List<Vector2> mainPointsUV) { }

	private void OCOQOCDCCQ(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	private static void MergeMeshDataExt(ref List<List<int>> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs, Material mat, ref List<Material> mats) { }

	private void OCQODCOQDO(ref List<int> tris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs1, ref List<Vector2> uvs2, ref List<Color> colors, ref List<int> trisTmp, ref List<Vector3> vecsTmp, ref List<Vector2> uvsTmp, ref List<Vector2> uvsTmp1, ref List<Vector2> uvsTmp2, ref List<Color> colorsTmp, bool skipMiddles, bool weldVecs) { }

	public static List<int> Triangulate(List<Vector3> vecs, List<Vector3> edges) { }

	public static void OCQDDOQCOQ(QDOODOQQDQODD connection, ERConnectionSibling sibling, int index, int total) { }

	public static void OOCQCOOOOO(List<ERConnectionSibling> siblings, int index) { }

	public static bool OQQQQQQQCD(QDQDOOQQDQODD roadType) { }

	public static Vector3 OOQCQDQCOO(int index, Vector3 p0, Vector3 p1, Vector3 p2) { }

	public static void Clear() { }

	public static void OOODDOCOOO() { }

	public static void OOOQQDDCCQ(ERTexture roadERTexture, ref float roadWidth, ref float leftIndent, ref float rightIndent, ref float leftUVX, ref float rightUVX, ref float leftIndentInner, ref float rightIndentInner, ref float roadOuterUVXInner, float cornerRadius) { }

	public static void OQOCODDDDC(int connection, QDQDOOQQDQODD roadType) { }

	public static float OOCDQCOCQO(Vector3 v1, Vector3 v2, Vector3 n) { }

	public static Vector3 OQOQODOOCD(Vector3 dirPos1, Vector3 dirPos2, Vector3 currentPos, List<Vector3> vecs, int startend) { }

	public static Vector3 ODQQOCDCOC(Vector3 currentPos, List<Vector3> vecs, ref int index, int startend) { }

	public static bool OQQOCCCOCD(Vector3 p1, Vector3 p2, Vector3 v) { }

	public void .ctor() { }

	private static void .cctor() { }

}

