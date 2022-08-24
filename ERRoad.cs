public class ERRoad // TypeDefIndex: 7183
{
	public ERModularRoad roadScript; 
	public GameObject gameObject; 
	public string str; 


public void .ctor() { }

public void .ctor(ERModularRoad scr) { }

public void AddInititialMarkers(Vector3 pos) { }

public void AddMarker(Vector3 pos) { }

public void ClampUVs(bool value) { }

public void FlipTexture() { }

public void AddMarkers(Vector3[] pos) { }

public void InsertMarker(Vector3 pos) { }

public void InsertMarkerAt(Vector3 pos, int index) { }

public void DeleteMarker(int i) { }

public void SetLayer(int layer) { }

public void SetTag(string tag) { }

public void SetWidth(float width) { }

public float GetWidth() { }

public ERRoadType GetRoadType(ERRoadType[] roadTypes) { }

public ERRoadType GetRoadType() { }

public bool SetRoadType(ERRoadType roadType) { }

public bool SetMarkerControlType(int marker, ERMarkerControlType type) { }

public bool SetSplineStrength(int marker, float strength) { }

public float GetSplineStrength(int marker) { }

public void IsSideObject(bool isSideObject) { }

public ERRoad InsertIConnector(int index) { }

public ERRoad InsertIConnector(int index, string connectionName) { }

public ERRoad InsertIConnector(int index, string connectionName, out ERConnection connection) { }

private ERRoad InsertIConnectorCore(int index, ref ERCrossingPrefabs pScript) { }

public ERRoad SplitRoad(int markerIndex) { }

	[EditorBrowsableAttribute] 
private ERModularRoad SplitRoadExt(int markerIndex) { }

public void SetSideObjects(List<ERSORoadExt> soDataExt) { }

public void SetSplatmap(bool active) { }

public void SetSplatmap(bool active, int splatIndex, int expand, int smoothLevel, float opacity) { }

public void SetMaterial(Material mat) { }

public void SetMarkerPosition(int marker, Vector3 vec) { }

public void SetResolution(float res) { }

public void IsStatic(bool value) { }

public bool IsStatic() { }

public float GetResolution() { }

public void SetAngleThreshold(float res) { }

public float GetAngleTreshold(float res) { }

public bool ClosedTrack(bool value) { }

public void FollowTerrainContours(bool value) { }

	[ObsoleteAttribute] 
public void SetFollowTerrainContoursOffset(float value) { }

public void FollowTerrainContourThreshold(float value) { }

public void FollowTerrainContours(int markerIndex, bool value) { }

public bool IsClosedTrack() { }

public void SetMarkerPositions(Vector3[] vecs) { }

public void SetMarkerPositions(Vector3[] vecs, int index) { }

public Vector3 GetMarkerPosition(int marker) { }

public Vector3[] GetMarkerPositions() { }

public int GetMarkerCount() { }

public void SetMarkerTilting(float value, int index) { }

public float GetMarkerTilting(int index) { }

public void SetMarkerTiltingCenter(float value, int index) { }

public float GetRadius(int markerIndex) { }

public float GetMarkerTiltingCenter(int index) { }

public Color GetVertexColor(int index) { }

public void SetVertexColor(int index, Color color) { }

public void SetDistances() { }

public Vector3 GetPosition(float distance, ref int currentElement) { }

public Vector3 GetLookatSmooth(float distance, int currentElement) { }

	[ObsoleteAttribute] 
public Vector3 GetLookatAtDistanceSmooth(float distance, ref int currentElement) { }

public int GetMarkerByPoint(int el) { }

public Vector3[] GetSplinePointsCenter() { }

public Vector3[] GetSplinePointsRightSide() { }

public Vector3[] GetSplinePointsRightSideExt() { }

public Vector3[] GetSplinePointsLeftSide() { }

public float SetIndent(float value, int marker) { }

public float SetIndent(float value, int marker, ERRoadSide type) { }

	[ObsoleteAttribute] 
public float SetRightIndent(float value, int marker) { }

	[ObsoleteAttribute] 
public float SetLeftIndent(float value, int marker) { }

public float SetSurrounding(float value, int marker) { }

public float SetSurrounding(float value, int marker, ERRoadSide type) { }

public void SetIndentAlignment(ERIndentAlignment value, int marker, ERRoadSide type) { }

public ERIndentAlignment GetIndentAlignment(int marker, ERRoadSide type) { }

	[ObsoleteAttribute] 
public float SetRightSurrouding(float value, int marker) { }

	[ObsoleteAttribute] 
public float SetLeftSurrouding(float value, int marker) { }

public Vector3[] GetRightIndentPoints() { }

public Vector3[] GetLeftIndentPoints() { }

public Vector3[] GetRightSurroundingPoints() { }

public Vector3[] GetLeftSurroudingPoints() { }

	[ObsoleteAttribute] 
public float GetLength() { }

public float GetDistance() { }

public float GetDistance(int markerIndex) { }

public void SideObjectSetActive(SideObject obj, bool value) { }

public void SideObjectMarkerSetActive(SideObject obj, int marker, bool value) { }

public void SideObjectMarkerSetActive(SideObject obj, int[] markers, bool value) { }

public void SetSideObjectOffset(SideObject obj, int marker, OffsetPosition position, float value) { }

public void SetTerrainDeformation(bool value) { }

public void SetTerrainDeformation(int markerIndex, bool value) { }

public void SetMeshCollider(bool flag) { }

public void Refresh() { }

public ERConnection GetConnectionAtStart() { }

public GameObject GetConnectionObjectAtStart() { }

public ERConnection GetConnectionAtStart(out int connectionIndex) { }

public ERConnection GetConnectionObjectAtEnd() { }

public ERConnection GetConnectionAtEnd() { }

public ERConnection GetConnectionAtEnd(out int connectionIndex) { }

public GameObject GetConnectionObjectAtEnd(out int connection) { }

public bool ConnectionCheck(ERCrossingPrefabs prefab, int index, int startEnd) { }

public bool ConnectToStart(ERConnection connectionObject, int connectionIndex) { }

public bool ConnectToStart(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

public bool ConnectToStartExt(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

public bool ConnectToEnd(ERConnection connectionObject, int connectionIndex) { }

public bool ConnectToEnd(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

public bool ConnectToEndEx(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

public ERConnection AttachToStart(ERConnection connectionObject) { }

public ERConnection AttachToEnd(ERConnection connectionObject) { }

public ERConnection AttachToStart(ERConnection OQQCOQOCDO, int connectionIndex) { }

public ERConnection AttachToEnd(ERConnection connectionInstance, int connectionIndex) { }

public bool ConnectionMatch(ERConnection connection) { }

public void SetCustomMarkerPoints(int markerIndex, List<Vector3> points) { }

public ERConnection InsertConnector(ERConnection connectionObject, int markerIndex, int connectionIndex1, int connectionIndex2, out ERRoad road) { }

public void UnConnectStart() { }

public void UnConnectEnd() { }

public bool ConnectionMatch(ERConnection connection, int connectionIndex) { }

public void SnapToTerrain(bool flag) { }

public void SnapToTerrain(bool flag, float offset) { }

public string GetName() { }

public void SetName(string name) { }

public Vector2[] GetShapeNodes() { }

public Vector2[] GetRoadShapeNodes(int markerIndex) { }

public void SetRoadShapeNodes(int markerIndex, Vector2[] nodes) { }

public void SetRoadShapeNodes(int[] markerIndexes, Vector2[] nodes) { }

public void Clear() { }

public void Destroy() { }

}

