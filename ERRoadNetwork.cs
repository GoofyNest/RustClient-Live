public class ERRoadNetwork // TypeDefIndex: 7273
{	public ERModularBase roadNetwork; // 0x10
	public bool isInBuildMode; // 0x18
	public string str; // 0x20
	public static ERRoadNetwork.RoadUpdateCallback onRoadUpdate; // 0x0
	public static ERRoadNetwork.BuildModeCallback onBuildModeEnter; // 0x8
	public static ERRoadNetwork.EditModeCallback onEditModeEnter; // 0x10


	public static void OnBuildModeEnter() { }

	public static void OnEditModeEnter() { }

	public static void OnRoadUpdated(ERRoad road) { }

	public void .ctor() { }

	public void GetTerrainData() { }

	public ERTrafficDirection GetTrafficDirection() { }

	public void Translate(Vector3 pos) { }

	public void CenterPivotPoints() { }

	public ERRoad[] GetRoads() { }

	public ERRoad GetRoadByName(string name) { }

	public ERRoad GetRoadByGameObject(GameObject go) { }

	public ERRoad CreateRoad(string roadName) { }

	public ERRoad CreateRoad(string roadName, Vector3[] markers) { }

	public ERRoad CreateRoad(string roadName, ERRoadType roadType) { }

	public ERRoad CreateRoad(string roadName, ERRoadType roadType, Vector3[] markers) { }

	public ERModularRoad InitRoad(string roadName, ERRoadType roadType, Material roadMaterial) { }

	public void AddInititialMarkers(ERRoad road, Vector3[] markers) { }

	public void AddIntersection(ERCrossingPrefabs crossing, GameObject crossingPrefab) { }

	public void BuildRoadNetwork(bool splatmaps, bool trees, bool detail, ERRoad[] roads) { }

	public void BuildRoadNetwork(bool splatmaps, bool trees, bool detail) { }

	public void BuildRoadNetwork() { }

	public void DoBuildRoadNetwork() { }

	public void RestoreRoadNetwork() { }

	public ERRoadType[] GetRoadTypes() { }

	public ERRoadType GetRoadTypeByName(string name) { }

	public SideObject GetSideObjectByName(string name) { }

	public ERRoadType AddRoadType() { }

	public void HideWhiteSurfaces(bool flag) { }

	public ERConnection[] GetConnections() { }

	public ERConnection GetConnectionByName(string name) { }

	public ERConnection[] LoadConnections() { }

	[ObsoleteAttribute] // RVA: 0x893A0 Offset: 0x887A0 VA: 0x1800893A0
	public ERConnection GetSourceConnectionByName(string name) { }

	public ERConnection GetConnectionPrefabByName(string name) { }

	public ERConnection InstantiateConnection(ERConnection OQQCOQOCDO, string name, Vector3 position, Vector3 euler) { }

	public void SetRaiseOffset(float value) { }

	public ERRoad OODOOOQQCO(ERRoad road) { }

	public float GetRaiseOffset() { }

	public void ClampUVs(bool clamp) { }

	public ERRoad ConnectRoads(ERRoad road1, ERRoad road2) { }

	public ERRoad ConnectRoads(ERRoad road1, int marker1, ERRoad road2, int marker2) { }

	private bool CheckRoads(ERRoad road1, ERRoad road2, ref string str) { }

	public static void SetTerrainNormals(Mesh m, GameObject go) { }

	public void Refresh() { }

	public void FinalizeObjects() { }

}

public sealed class ERRoadNetwork.RoadUpdateCallback : MulticastDelegate // TypeDefIndex: 7274
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ERRoad road) { }

	public virtual IAsyncResult BeginInvoke(ERRoad road, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ERRoadNetwork.BuildModeCallback : MulticastDelegate // TypeDefIndex: 7275
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ERRoadNetwork.EditModeCallback : MulticastDelegate // TypeDefIndex: 7276
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

