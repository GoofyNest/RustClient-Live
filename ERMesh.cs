public class ERMesh // TypeDefIndex: 7220
{
	public List<int> vecsInt; 
	public List<Vector3> vecs; 
	public List<Vector2> uv; 
	public List<Vector2> uv2; 
	public List<Color> colors; 
	public List<Vector3> normals; 
	public List<Vector4> tangents; 
	public List<int> triangles; 
	public List<int> triangles2; 
	public List<int> startVecsInt; 
	public List<Vector3> startVecs; 
	public List<Vector2> startUv; 
	public List<Vector2> startUv2; 
	public List<Color> startColors; 
	public List<Vector3> startNormals; 
	public List<Vector4> startTangents; 
	public List<int> startTriangles; 
	public List<int> startTriangles2; 
	public List<int> endVecsInt; 
	public List<Vector3> endVecs; 
	public List<Vector2> endUv; 
	public List<Vector2> endUv2; 
	public List<Color> endColors; 
	public List<Vector3> endNormals; 
	public List<Vector4> endTangents; 
	public List<int> endTriangles; 
	public List<int> endTriangles2; 
	public List<int> suVecsInt; 
	public List<Vector3> suVecs; 
	public List<Vector2> suUv; 
	public List<Vector2> suUv2; 
	public List<Color> suColors; 
	public List<Vector3> suNormals; 
	public List<Vector4> suTangents; 
	public List<int> suTriangles; 
	public List<int> suTriangles2; 
	public List<int> sdVecsInt; 
	public List<Vector3> sdVecs; 
	public List<Vector2> sdUv; 
	public List<Vector2> sdUv2; 
	public List<Color> sdColors; 
	public List<Vector3> sdNormals; 
	public List<Vector4> sdTangents; 
	public List<int> sdTriangles; 
	public List<int> sdTriangles2; 
	public List<Material> materials; 
	public List<Vector3> sVecs; 
	public List<Vector2> sUv; 
	public List<Vector2> sUv2; 
	public List<Color> sColors; 
	public List<Vector3> sNormals; 
	public List<Vector4> sTangents; 
	public List<int> sTriangles; 
	public List<Vector3> sTerrainNormals; 
	public List<List<Vector3>> sVecsGroups; 
	public List<List<Vector2>> sUvGroups; 
	public List<List<Vector2>> sUv2Groups; 
	public List<List<Color>> sColorsGroups; 
	public List<List<Vector3>> sNormalsGroups; 
	public List<List<Vector4>> sTangentsGroups; 
	public List<List<int>> sTrianglesGroups; 
	public List<List<Vector3>> sTerrainNormalsGroups; 
	public List<Vector3> sStartVecs; 
	public List<Vector2> sStartUv; 
	public List<Vector2> sStartUv2; 
	public List<Color> sStartColors; 
	public List<Vector3> sStartNormals; 
	public List<Vector4> sStartTangents; 
	public List<int> sStartTriangles; 
	public List<Vector3> sEndVecs; 
	public List<Vector2> sEndUv; 
	public List<Vector2> sEndUv2; 
	public List<Color> sEndColors; 
	public List<Vector3> sEndNormals; 
	public List<Vector4> sEndTangents; 
	public List<int> sEndTriangles; 
	public List<Vector3> sSuVecs; 
	public List<Vector2> sSuUv; 
	public List<Vector2> sSuUv2; 
	public List<Color> sSuColors; 
	public List<Vector3> sSuNormals; 
	public List<Vector4> sSuTangents; 
	public List<int> sSuTriangles; 
	public List<Vector3> sSdVecs; 
	public List<Vector2> sSdUv; 
	public List<Vector2> sSdUv2; 
	public List<Color> sSdColors; 
	public List<Vector3> sSdNormals; 
	public List<Vector4> sSdTangents; 
	public List<int> sSdTriangles; 
	public int startEndVecCount; 
	public int middleStartVecCount; 
	public int middleEndVecCount; 
	public int endStartVecCount; 
	public List<Vector3> middleEndVecs; 
	public List<int> startEndInts; 
	public List<int> middleStartInts; 
	public List<int> middleEndInts; 
	public List<int> middleStartStartInts; 
	public List<int> middleEndEndInts; 
	public List<int> endStartInts; 
	public List<int> startEndIntsNC; 
	public List<int> middleStartStartIntsNC; 
	public List<int> middleStartIntsNC; 
	public List<int> middleEndIntsNC; 
	public List<int> middleEndEndIntsNC; 
	public List<int> endStartIntsNC; 
	public int OQOQODDQCCInt; 
	public int ODQCDQCCODInt; 
	public int middleLeftInt; 
	public int middleRightInt; 
	public int endLeftInt; 
	public int endRightInt; 
	public List<int> normalArray1; 
	public List<int> normalArray2; 
	public List<List<int>> normalArray1Group; 
	public List<List<int>> normalArray2Group; 
	public int vecCount; 
	public List<float> zValues; 
	public List<ZIndexArray> zValueVecIndexes; 
	public List<float> zValuesStart; 
	public List<ZIndexArray> zValueVecIndexesStart; 
	public List<float> zValuesEnd; 
	public List<ZIndexArray> zValueVecIndexesEnd; 
	public List<float> zValuesStepUp; 
	public List<ZIndexArray> zValueVecIndexesStepUp; 
	public List<float> zValuesStepDown; 
	public List<ZIndexArray> zValueVecIndexesStepDown; 
	public float minZ; 
	public float minMiddleZ; 
	public float maxZ; 
	public float maxMiddleZ; 
	public float totalZDistance; 
	public float offset1; 
	public float offset2; 
	public List<int> vertexBatches; 
	public List<int> triangleBatches; 
	public int lodIndex; 
	public bool castShadows; 
	public string name; 
	public bool terrainMesh; 


	public void OCQQQCQQDD() { }

	public void .ctor(GameObject m_go, SideObject soScript, float minZ, Transform sourceTransform, Vector3 scale, Mesh m, Material mat, float startMin = 0, bool rotate180 = False) { }

	private void OCDCDCQQDQ(GameObject m_go, SideObject soScript, float minZ, Transform sourceTransform, Vector3 scale, Mesh m, Material mat, float startMin, bool namingConvention) { }

	private void OCDCQCQQOC(List<Vector3> vecs, ref List<ZIndexArray> zValueVecIndexes, ref List<float> zValues) { }

	public void GetMiddleSementInfo(List<Vector3> vecs, ref float minMiddleZ, ref float maxMiddleZ, ref List<int> middleStartInts, ref List<int> middleEndInts) { }

	public void GetMiddleEdges(List<Vector3> vecs, float z, ref List<int> edgeInts) { }

	public bool OOCDOCOCQO(Vector3 v, int index, List<float> zV, ref List<ZIndexArray> zVIndexes) { }

	public void OCDQOQOCCD(int index, Vector3 v, ref List<int> vecsInts, ref List<Vector3> vecs, ref List<Vector2> uv, ref List<Vector2> uv2, ref List<Vector3> normals, ref List<Color> colors, ref List<Vector4> tangents, Vector2 sourceUv, Vector2 sourceUv2, Vector3 sourceNormal, Color sourceColor, Vector4 sourceTangent, ref int tri) { }

	public void ODDDDDQDOQ(int index, ref List<int> vecsInts) { }

	public void InEdgePairArray(int index1, int index2, ref List<CRedge> vecsInts) { }

	public void OQCDQOQOCQ(float adjustZ) { }

	public void OCDDCDODQQ(ref List<List<int>> groups, List<int> triInts, List<int> edgeInts) { }

	public void OOQOCOQOOO(List<CRedge> edges, ref int curInt) { }

	public bool OCCCOQOCQO(List<CRedge> edges, int index, int curInt) { }

	public bool ODDDDDQDOQ(int index, List<int> edgeInts) { }

	public bool OCDOQODCCQ(List<CRedge> edges, int index1, int index2) { }

	public void MatchEdgePairs(List<CRedge> startEdgePairs, List<CRedge> endEdgePairs, ref List<int> startInts, ref List<int> endInts, ref List<int> startIntsNC, ref List<int> endIntsNC, List<Vector3> startVecs, List<Vector3> endVecs, List<Vector3> startNormals, List<Vector3> normals, ref int OQOQODDQCCInt, ref int ODQCDQCCODInt) { }

	public void OQOCDDCQDD(List<List<int>> startGroups, List<List<int>> endGroups, ref List<int> startInts, ref List<int> endInts, List<Vector3> startVecs, List<Vector3> endVecs) { }

	public void ODDDOCDCQO(ERModularRoad roadScr, GameObject go, SideObject so, ERModularBase scr, bool mirrored, int sectionListIndex, List<int> sectionIndexes, int autoSectionStart) { }

	public static bool OQCQCDQDOO(ERModularRoad rd, int listIndex, int listItemIndex, SideObject so, bool mirrored) { }

	private void OODCCOCQOC(GameObject go, SideObject so, ERModularBase scr, List<Vector3> sVecs, List<Vector2> sUv, List<Vector2> sUv2, List<Color> sColors, List<Vector3> sNormals, List<Vector4> sTangents, List<int> sTriangles, List<int> normalArray1, List<int> normalArray2, List<Material> materials, List<Vector3> sTerrainNormals) { }

	private void OCOCOQQOOO(ref int vecCount, ref List<int> intList, List<Vector3> vecsList, float zValue) { }

	private void OCODQQOCDD(ref List<int> targetIntList, List<int> sourceIntList, List<Vector3> targetVecs, List<Vector3> sourceVecs) { }

	public void Clear() { }

}

