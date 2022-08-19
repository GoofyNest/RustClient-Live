public class ERRoad // TypeDefIndex: 7183
{	// Fields
	public ERModularRoad roadScript; // 0x10
	public GameObject gameObject; // 0x18
	public string str; // 0x20

	// Methods

	// RVA: 0xB47260 Offset: 0xB46660 VA: 0x180B47260
	public void .ctor() { }

	// RVA: 0xB472B0 Offset: 0xB466B0 VA: 0x180B472B0
	public void .ctor(ERModularRoad scr) { }

	// RVA: 0xB3E380 Offset: 0xB3D780 VA: 0x180B3E380
	public void AddInititialMarkers(Vector3 pos) { }

	// RVA: 0xB3E400 Offset: 0xB3D800 VA: 0x180B3E400
	public void AddMarker(Vector3 pos) { }

	// RVA: 0xB3ED50 Offset: 0xB3E150 VA: 0x180B3ED50
	public void ClampUVs(bool value) { }

	// RVA: 0xB40260 Offset: 0xB3F660 VA: 0x180B40260
	public void FlipTexture() { }

	// RVA: 0xB3E500 Offset: 0xB3D900 VA: 0x180B3E500
	public void AddMarkers(Vector3[] pos) { }

	// RVA: 0xB43F60 Offset: 0xB43360 VA: 0x180B43F60
	public void InsertMarker(Vector3 pos) { }

	// RVA: 0xB43EA0 Offset: 0xB432A0 VA: 0x180B43EA0
	public void InsertMarkerAt(Vector3 pos, int index) { }

	// RVA: 0xB3FF60 Offset: 0xB3F360 VA: 0x180B3FF60
	public void DeleteMarker(int i) { }

	// RVA: 0xB44870 Offset: 0xB43C70 VA: 0x180B44870
	public void SetLayer(int layer) { }

	// RVA: 0xB46890 Offset: 0xB45C90 VA: 0x180B46890
	public void SetTag(string tag) { }

	// RVA: 0xB46A90 Offset: 0xB45E90 VA: 0x180B46A90
	public void SetWidth(float width) { }

	// RVA: 0xB432F0 Offset: 0xB426F0 VA: 0x180B432F0
	public float GetWidth() { }

	// RVA: 0xB42F80 Offset: 0xB42380 VA: 0x180B42F80
	public ERRoadType GetRoadType(ERRoadType[] roadTypes) { }

	// RVA: 0xB42F30 Offset: 0xB42330 VA: 0x180B42F30
	public ERRoadType GetRoadType() { }

	// RVA: 0xB45830 Offset: 0xB44C30 VA: 0x180B45830
	public bool SetRoadType(ERRoadType roadType) { }

	// RVA: 0xB44A30 Offset: 0xB43E30 VA: 0x180B44A30
	public bool SetMarkerControlType(int marker, ERMarkerControlType type) { }

	// RVA: 0xB465B0 Offset: 0xB459B0 VA: 0x180B465B0
	public bool SetSplineStrength(int marker, float strength) { }

	// RVA: 0xB431B0 Offset: 0xB425B0 VA: 0x180B431B0
	public float GetSplineStrength(int marker) { }

	// RVA: 0xB43FD0 Offset: 0xB433D0 VA: 0x180B43FD0
	public void IsSideObject(bool isSideObject) { }

	// RVA: 0xB43D00 Offset: 0xB43100 VA: 0x180B43D00
	public ERRoad InsertIConnector(int index) { }

	// RVA: 0xB43E40 Offset: 0xB43240 VA: 0x180B43E40
	public ERRoad InsertIConnector(int index, string connectionName) { }

	// RVA: 0xB43D20 Offset: 0xB43120 VA: 0x180B43D20
	public ERRoad InsertIConnector(int index, string connectionName, out ERConnection connection) { }

	// RVA: 0xB438F0 Offset: 0xB42CF0 VA: 0x180B438F0
	private ERRoad InsertIConnectorCore(int index, ref ERCrossingPrefabs pScript) { }

	// RVA: 0xB46F20 Offset: 0xB46320 VA: 0x180B46F20
	public ERRoad SplitRoad(int markerIndex) { }

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	// RVA: 0xB46E50 Offset: 0xB46250 VA: 0x180B46E50
	private ERModularRoad SplitRoadExt(int markerIndex) { }

	// RVA: 0xB45A30 Offset: 0xB44E30 VA: 0x180B45A30
	public void SetSideObjects(List<ERSORoadExt> soDataExt) { }

	// RVA: 0xB46520 Offset: 0xB45920 VA: 0x180B46520
	public void SetSplatmap(bool active) { }

	// RVA: 0xB46540 Offset: 0xB45940 VA: 0x180B46540
	public void SetSplatmap(bool active, int splatIndex, int expand, int smoothLevel, float opacity) { }

	// RVA: 0xB44FE0 Offset: 0xB443E0 VA: 0x180B44FE0
	public void SetMaterial(Material mat) { }

	// RVA: 0xB44B30 Offset: 0xB43F30 VA: 0x180B44B30
	public void SetMarkerPosition(int marker, Vector3 vec) { }

	// RVA: 0xB453A0 Offset: 0xB447A0 VA: 0x180B453A0
	public void SetResolution(float res) { }

	// RVA: 0xB43FF0 Offset: 0xB433F0 VA: 0x180B43FF0
	public void IsStatic(bool value) { }

	// RVA: 0xB44030 Offset: 0xB43430 VA: 0x180B44030
	public bool IsStatic() { }

	// RVA: 0xB42DA0 Offset: 0xB421A0 VA: 0x180B42DA0
	public float GetResolution() { }

	// RVA: 0xB44300 Offset: 0xB43700 VA: 0x180B44300
	public void SetAngleThreshold(float res) { }

	// RVA: 0xB40790 Offset: 0xB3FB90 VA: 0x180B40790
	public float GetAngleTreshold(float res) { }

	// RVA: 0xB3F200 Offset: 0xB3E600 VA: 0x180B3F200
	public bool ClosedTrack(bool value) { }

	// RVA: 0xB40500 Offset: 0xB3F900 VA: 0x180B40500
	public void FollowTerrainContours(bool value) { }

	[ObsoleteAttribute] // RVA: 0x893A0 Offset: 0x887A0 VA: 0x1800893A0
	// RVA: 0xB404D0 Offset: 0xB3F8D0 VA: 0x180B404D0
	public void SetFollowTerrainContoursOffset(float value) { }

	// RVA: 0xB404D0 Offset: 0xB3F8D0 VA: 0x180B404D0
	public void FollowTerrainContourThreshold(float value) { }

	// RVA: 0xB40700 Offset: 0xB3FB00 VA: 0x180B40700
	public void FollowTerrainContours(int markerIndex, bool value) { }

	// RVA: 0xB43FB0 Offset: 0xB433B0 VA: 0x180B43FB0
	public bool IsClosedTrack() { }

	// RVA: 0xB44BE0 Offset: 0xB43FE0 VA: 0x180B44BE0
	public void SetMarkerPositions(Vector3[] vecs) { }

	// RVA: 0xB44D60 Offset: 0xB44160 VA: 0x180B44D60
	public void SetMarkerPositions(Vector3[] vecs, int index) { }

	// RVA: 0xB423E0 Offset: 0xB417E0 VA: 0x180B423E0
	public Vector3 GetMarkerPosition(int marker) { }

	// RVA: 0xB424B0 Offset: 0xB418B0 VA: 0x180B424B0
	public Vector3[] GetMarkerPositions() { }

	// RVA: 0xB42390 Offset: 0xB41790 VA: 0x180B42390
	public int GetMarkerCount() { }

	// RVA: 0xB44F40 Offset: 0xB44340 VA: 0x180B44F40
	public void SetMarkerTilting(float value, int index) { }

	// RVA: 0xB426D0 Offset: 0xB41AD0 VA: 0x180B426D0
	public float GetMarkerTilting(int index) { }

	// RVA: 0xB44E80 Offset: 0xB44280 VA: 0x180B44E80
	public void SetMarkerTiltingCenter(float value, int index) { }

	// RVA: 0xB42CD0 Offset: 0xB420D0 VA: 0x180B42CD0
	public float GetRadius(int markerIndex) { }

	// RVA: 0xB42640 Offset: 0xB41A40 VA: 0x180B42640
	public float GetMarkerTiltingCenter(int index) { }

	// RVA: 0xB43240 Offset: 0xB42640 VA: 0x180B43240
	public Color GetVertexColor(int index) { }

	// RVA: 0xB469F0 Offset: 0xB45DF0 VA: 0x180B469F0
	public void SetVertexColor(int index, Color color) { }

	// RVA: 0xB44440 Offset: 0xB43840 VA: 0x180B44440
	public void SetDistances() { }

	// RVA: 0xB427F0 Offset: 0xB41BF0 VA: 0x180B427F0
	public Vector3 GetPosition(float distance, ref int currentElement) { }

	// RVA: 0xB418A0 Offset: 0xB40CA0 VA: 0x180B418A0
	public Vector3 GetLookatSmooth(float distance, int currentElement) { }

	[ObsoleteAttribute] // RVA: 0x893A0 Offset: 0x887A0 VA: 0x1800893A0
	// RVA: 0xB41070 Offset: 0xB40470 VA: 0x180B41070
	public Vector3 GetLookatAtDistanceSmooth(float distance, ref int currentElement) { }

	// RVA: 0xB421A0 Offset: 0xB415A0 VA: 0x180B421A0
	public int GetMarkerByPoint(int el) { }

	// RVA: 0xB43070 Offset: 0xB42470 VA: 0x180B43070
	public Vector3[] GetSplinePointsCenter() { }

	// RVA: 0xB43160 Offset: 0xB42560 VA: 0x180B43160
	public Vector3[] GetSplinePointsRightSide() { }

	// RVA: 0xB43110 Offset: 0xB42510 VA: 0x180B43110
	public Vector3[] GetSplinePointsRightSideExt() { }

	// RVA: 0xB430C0 Offset: 0xB424C0 VA: 0x180B430C0
	public Vector3[] GetSplinePointsLeftSide() { }

	// RVA: 0xB44770 Offset: 0xB43B70 VA: 0x180B44770
	public float SetIndent(float value, int marker) { }

	// RVA: 0xB44660 Offset: 0xB43A60 VA: 0x180B44660
	public float SetIndent(float value, int marker, ERRoadSide type) { }

	[ObsoleteAttribute] // RVA: 0x893A0 Offset: 0x887A0 VA: 0x1800893A0
	// RVA: 0xB453D0 Offset: 0xB447D0 VA: 0x180B453D0
	public float SetRightIndent(float value, int marker) { }

	[ObsoleteAttribute] // RVA: 0x893A0 Offset: 0x887A0 VA: 0x1800893A0
	// RVA: 0xB448C0 Offset: 0xB43CC0 VA: 0x180B448C0
	public float SetLeftIndent(float value, int marker) { }

	// RVA: 0xB46680 Offset: 0xB45A80 VA: 0x180B46680
	public float SetSurrounding(float value, int marker) { }

	// RVA: 0xB46780 Offset: 0xB45B80 VA: 0x180B46780
	public float SetSurrounding(float value, int marker, ERRoadSide type) { }

	// RVA: 0xB44630 Offset: 0xB43A30 VA: 0x180B44630
	public void SetIndentAlignment(ERIndentAlignment value, int marker, ERRoadSide type) { }

	// RVA: 0xB40FB0 Offset: 0xB403B0 VA: 0x180B40FB0
	public ERIndentAlignment GetIndentAlignment(int marker, ERRoadSide type) { }

	[ObsoleteAttribute] // RVA: 0x893A0 Offset: 0x887A0 VA: 0x1800893A0
	// RVA: 0xB45490 Offset: 0xB44890 VA: 0x180B45490
	public float SetRightSurrouding(float value, int marker) { }

	[ObsoleteAttribute] // RVA: 0x893A0 Offset: 0x887A0 VA: 0x1800893A0
	// RVA: 0xB44980 Offset: 0xB43D80 VA: 0x180B44980
	public float SetLeftSurrouding(float value, int marker) { }

	// RVA: 0xB42DC0 Offset: 0xB421C0 VA: 0x180B42DC0
	public Vector3[] GetRightIndentPoints() { }

	// RVA: 0xB40FD0 Offset: 0xB403D0 VA: 0x180B40FD0
	public Vector3[] GetLeftIndentPoints() { }

	// RVA: 0xB42E10 Offset: 0xB42210 VA: 0x180B42E10
	public Vector3[] GetRightSurroundingPoints() { }

	// RVA: 0xB41020 Offset: 0xB40420 VA: 0x180B41020
	public Vector3[] GetLeftSurroudingPoints() { }

	[ObsoleteAttribute] // RVA: 0x893A0 Offset: 0x887A0 VA: 0x1800893A0
	// RVA: 0xB40F90 Offset: 0xB40390 VA: 0x180B40F90
	public float GetLength() { }

	// RVA: 0xB40F90 Offset: 0xB40390 VA: 0x180B40F90
	public float GetDistance() { }

	// RVA: 0xB40F00 Offset: 0xB40300 VA: 0x180B40F00
	public float GetDistance(int markerIndex) { }

	// RVA: 0xB46CF0 Offset: 0xB460F0 VA: 0x180B46CF0
	public void SideObjectSetActive(SideObject obj, bool value) { }

	// RVA: 0xB46C00 Offset: 0xB46000 VA: 0x180B46C00
	public void SideObjectMarkerSetActive(SideObject obj, int marker, bool value) { }

	// RVA: 0xB46B10 Offset: 0xB45F10 VA: 0x180B46B10
	public void SideObjectMarkerSetActive(SideObject obj, int[] markers, bool value) { }

	// RVA: 0xB45950 Offset: 0xB44D50 VA: 0x180B45950
	public void SetSideObjectOffset(SideObject obj, int marker, OffsetPosition position, float value) { }

	// RVA: 0xB46910 Offset: 0xB45D10 VA: 0x180B46910
	public void SetTerrainDeformation(bool value) { }

	// RVA: 0xB46940 Offset: 0xB45D40 VA: 0x180B46940
	public void SetTerrainDeformation(int markerIndex, bool value) { }

	// RVA: 0xB45160 Offset: 0xB44560 VA: 0x180B45160
	public void SetMeshCollider(bool flag) { }

	// RVA: 0xB44060 Offset: 0xB43460 VA: 0x180B44060
	public void Refresh() { }

	// RVA: 0xB40A10 Offset: 0xB3FE10 VA: 0x180B40A10
	public ERConnection GetConnectionAtStart() { }

	// RVA: 0xB40E60 Offset: 0xB40260 VA: 0x180B40E60
	public GameObject GetConnectionObjectAtStart() { }

	// RVA: 0xB40B30 Offset: 0xB3FF30 VA: 0x180B40B30
	public ERConnection GetConnectionAtStart(out int connectionIndex) { }

	// RVA: 0xB40C70 Offset: 0xB40070 VA: 0x180B40C70
	public ERConnection GetConnectionObjectAtEnd() { }

	// RVA: 0xB407B0 Offset: 0xB3FBB0 VA: 0x180B407B0
	public ERConnection GetConnectionAtEnd() { }

	// RVA: 0xB408D0 Offset: 0xB3FCD0 VA: 0x180B408D0
	public ERConnection GetConnectionAtEnd(out int connectionIndex) { }

	// RVA: 0xB40D90 Offset: 0xB40190 VA: 0x180B40D90
	public GameObject GetConnectionObjectAtEnd(out int connection) { }

	// RVA: 0xB3F940 Offset: 0xB3ED40 VA: 0x180B3F940
	public bool ConnectionCheck(ERCrossingPrefabs prefab, int index, int startEnd) { }

	// RVA: 0xB3F8C0 Offset: 0xB3ECC0 VA: 0x180B3F8C0
	public bool ConnectToStart(ERConnection connectionObject, int connectionIndex) { }

	// RVA: 0xB3F830 Offset: 0xB3EC30 VA: 0x180B3F830
	public bool ConnectToStart(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB3F630 Offset: 0xB3EA30 VA: 0x180B3F630
	public bool ConnectToStartExt(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB3F510 Offset: 0xB3E910 VA: 0x180B3F510
	public bool ConnectToEnd(ERConnection connectionObject, int connectionIndex) { }

	// RVA: 0xB3F590 Offset: 0xB3E990 VA: 0x180B3F590
	public bool ConnectToEnd(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB3F300 Offset: 0xB3E700 VA: 0x180B3F300
	public bool ConnectToEndEx(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB3EBA0 Offset: 0xB3DFA0 VA: 0x180B3EBA0
	public ERConnection AttachToStart(ERConnection connectionObject) { }

	// RVA: 0xB3E620 Offset: 0xB3DA20 VA: 0x180B3E620
	public ERConnection AttachToEnd(ERConnection connectionObject) { }

	// RVA: 0xB3E9F0 Offset: 0xB3DDF0 VA: 0x180B3E9F0
	public ERConnection AttachToStart(ERConnection OQQCOQOCDO, int connectionIndex) { }

	// RVA: 0xB3E7F0 Offset: 0xB3DBF0 VA: 0x180B3E7F0
	public ERConnection AttachToEnd(ERConnection connectionInstance, int connectionIndex) { }

	// RVA: 0xB3FE40 Offset: 0xB3F240 VA: 0x180B3FE40
	public bool ConnectionMatch(ERConnection connection) { }

	// RVA: 0xB44330 Offset: 0xB43730 VA: 0x180B44330
	public void SetCustomMarkerPoints(int markerIndex, List<Vector3> points) { }

	// RVA: 0xB43380 Offset: 0xB42780 VA: 0x180B43380
	public ERConnection InsertConnector(ERConnection connectionObject, int markerIndex, int connectionIndex1, int connectionIndex2, out ERRoad road) { }

	// RVA: 0xB471B0 Offset: 0xB465B0 VA: 0x180B471B0
	public void UnConnectStart() { }

	// RVA: 0xB470E0 Offset: 0xB464E0 VA: 0x180B470E0
	public void UnConnectEnd() { }

	// RVA: 0xB3FD30 Offset: 0xB3F130 VA: 0x180B3FD30
	public bool ConnectionMatch(ERConnection connection, int connectionIndex) { }

	// RVA: 0xB46DC0 Offset: 0xB461C0 VA: 0x180B46DC0
	public void SnapToTerrain(bool flag) { }

	// RVA: 0xB46E00 Offset: 0xB46200 VA: 0x180B46E00
	public void SnapToTerrain(bool flag, float offset) { }

	// RVA: 0xB42760 Offset: 0xB41B60 VA: 0x180B42760
	public string GetName() { }

	// RVA: 0xB452F0 Offset: 0xB446F0 VA: 0x180B452F0
	public void SetName(string name) { }

	// RVA: 0xB42FD0 Offset: 0xB423D0 VA: 0x180B42FD0
	public Vector2[] GetShapeNodes() { }

	// RVA: 0xB42E60 Offset: 0xB42260 VA: 0x180B42E60
	public Vector2[] GetRoadShapeNodes(int markerIndex) { }

	// RVA: 0xB456C0 Offset: 0xB44AC0 VA: 0x180B456C0
	public void SetRoadShapeNodes(int markerIndex, Vector2[] nodes) { }

	// RVA: 0xB45540 Offset: 0xB44940 VA: 0x180B45540
	public void SetRoadShapeNodes(int[] markerIndexes, Vector2[] nodes) { }

	// RVA: 0xB3ED80 Offset: 0xB3E180 VA: 0x180B3ED80
	public void Clear() { }

	// RVA: 0xB3FFD0 Offset: 0xB3F3D0 VA: 0x180B3FFD0
	public void Destroy() { }

}

