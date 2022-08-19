public class ERRoadNetwork // TypeDefIndex: 7273
{	// Fields
	public ERModularBase roadNetwork; // 0x10
	public bool isInBuildMode; // 0x18
	public string str; // 0x20
	public static ERRoadNetwork.RoadUpdateCallback onRoadUpdate; // 0x0
	public static ERRoadNetwork.BuildModeCallback onBuildModeEnter; // 0x8
	public static ERRoadNetwork.EditModeCallback onEditModeEnter; // 0x10

	// Methods

	// RVA: 0xB3C2C0 Offset: 0xB3B6C0 VA: 0x180B3C2C0
	public static void OnBuildModeEnter() { }

	// RVA: 0xB3C4A0 Offset: 0xB3B8A0 VA: 0x180B3C4A0
	public static void OnEditModeEnter() { }

	// RVA: 0xB3C680 Offset: 0xB3BA80 VA: 0x180B3C680
	public static void OnRoadUpdated(ERRoad road) { }

	// RVA: 0xB3CEC0 Offset: 0xB3C2C0 VA: 0x180B3CEC0
	public void .ctor() { }

	// RVA: 0xB3B480 Offset: 0xB3A880 VA: 0x180B3B480
	public void GetTerrainData() { }

	// RVA: 0xB3B4B0 Offset: 0xB3A8B0 VA: 0x180B3B4B0
	public ERTrafficDirection GetTrafficDirection() { }

	// RVA: 0xB3CAE0 Offset: 0xB3BEE0 VA: 0x180B3CAE0
	public void Translate(Vector3 pos) { }

	// RVA: 0xB374F0 Offset: 0xB368F0 VA: 0x180B374F0
	public void CenterPivotPoints() { }

	// RVA: 0xB3B060 Offset: 0xB3A460 VA: 0x180B3B060
	public ERRoad[] GetRoads() { }

	// RVA: 0xB3AEE0 Offset: 0xB3A2E0 VA: 0x180B3AEE0
	public ERRoad GetRoadByName(string name) { }

	// RVA: 0xB3ADA0 Offset: 0xB3A1A0 VA: 0x180B3ADA0
	public ERRoad GetRoadByGameObject(GameObject go) { }

	// RVA: 0xB39740 Offset: 0xB38B40 VA: 0x180B39740
	public ERRoad CreateRoad(string roadName) { }

	// RVA: 0xB38CA0 Offset: 0xB380A0 VA: 0x180B38CA0
	public ERRoad CreateRoad(string roadName, Vector3[] markers) { }

	// RVA: 0xB38DE0 Offset: 0xB381E0 VA: 0x180B38DE0
	public ERRoad CreateRoad(string roadName, ERRoadType roadType) { }

	// RVA: 0xB391B0 Offset: 0xB385B0 VA: 0x180B391B0
	public ERRoad CreateRoad(string roadName, ERRoadType roadType, Vector3[] markers) { }

	// RVA: 0xB3B510 Offset: 0xB3A910 VA: 0x180B3B510
	public ERModularRoad InitRoad(string roadName, ERRoadType roadType, Material roadMaterial) { }

	// RVA: 0xB37150 Offset: 0xB36550 VA: 0x180B37150
	public void AddInititialMarkers(ERRoad road, Vector3[] markers) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void AddIntersection(ERCrossingPrefabs crossing, GameObject crossingPrefab) { }

	// RVA: 0xB37350 Offset: 0xB36750 VA: 0x180B37350
	public void BuildRoadNetwork(bool splatmaps, bool trees, bool detail, ERRoad[] roads) { }

	// RVA: 0xB37300 Offset: 0xB36700 VA: 0x180B37300
	public void BuildRoadNetwork(bool splatmaps, bool trees, bool detail) { }

	// RVA: 0xB372B0 Offset: 0xB366B0 VA: 0x180B372B0
	public void BuildRoadNetwork() { }

	// RVA: 0xB39830 Offset: 0xB38C30 VA: 0x180B39830
	public void DoBuildRoadNetwork() { }

	// RVA: 0xB3C6E0 Offset: 0xB3BAE0 VA: 0x180B3C6E0
	public void RestoreRoadNetwork() { }

	// RVA: 0xB3B040 Offset: 0xB3A440 VA: 0x180B3B040
	public ERRoadType[] GetRoadTypes() { }

	// RVA: 0xB3B020 Offset: 0xB3A420 VA: 0x180B3B020
	public ERRoadType GetRoadTypeByName(string name) { }

	// RVA: 0xB3B1C0 Offset: 0xB3A5C0 VA: 0x180B3B1C0
	public SideObject GetSideObjectByName(string name) { }

	// RVA: 0xB372A0 Offset: 0xB366A0 VA: 0x180B372A0
	public ERRoadType AddRoadType() { }

	// RVA: 0xB3B4E0 Offset: 0xB3A8E0 VA: 0x180B3B4E0
	public void HideWhiteSurfaces(bool flag) { }

	// RVA: 0xB3AC10 Offset: 0xB3A010 VA: 0x180B3AC10
	public ERConnection[] GetConnections() { }

	// RVA: 0xB3A7F0 Offset: 0xB39BF0 VA: 0x180B3A7F0
	public ERConnection GetConnectionByName(string name) { }

	// RVA: 0xB3BEE0 Offset: 0xB3B2E0 VA: 0x180B3BEE0
	public ERConnection[] LoadConnections() { }

	[ObsoleteAttribute] // RVA: 0x893A0 Offset: 0x887A0 VA: 0x1800893A0
	// RVA: 0xB3B1E0 Offset: 0xB3A5E0 VA: 0x180B3B1E0
	public ERConnection GetSourceConnectionByName(string name) { }

	// RVA: 0xB3A970 Offset: 0xB39D70 VA: 0x180B3A970
	public ERConnection GetConnectionPrefabByName(string name) { }

	// RVA: 0xB3BB40 Offset: 0xB3AF40 VA: 0x180B3BB40
	public ERConnection InstantiateConnection(ERConnection OQQCOQOCDO, string name, Vector3 position, Vector3 euler) { }

	// RVA: 0xB3C720 Offset: 0xB3BB20 VA: 0x180B3C720
	public void SetRaiseOffset(float value) { }

	// RVA: 0xB3C1D0 Offset: 0xB3B5D0 VA: 0x180B3C1D0
	public ERRoad OODOOOQQCO(ERRoad road) { }

	// RVA: 0xB3AD80 Offset: 0xB3A180 VA: 0x180B3AD80
	public float GetRaiseOffset() { }

	// RVA: 0xB381E0 Offset: 0xB375E0 VA: 0x180B381E0
	public void ClampUVs(bool clamp) { }

	// RVA: 0xB38570 Offset: 0xB37970 VA: 0x180B38570
	public ERRoad ConnectRoads(ERRoad road1, ERRoad road2) { }

	// RVA: 0xB38200 Offset: 0xB37600 VA: 0x180B38200
	public ERRoad ConnectRoads(ERRoad road1, int marker1, ERRoad road2, int marker2) { }

	// RVA: 0xB380C0 Offset: 0xB374C0 VA: 0x180B380C0
	private bool CheckRoads(ERRoad road1, ERRoad road2, ref string str) { }

	// RVA: 0xB3C950 Offset: 0xB3BD50 VA: 0x180B3C950
	public static void SetTerrainNormals(Mesh m, GameObject go) { }

	// RVA: 0xB3C6D0 Offset: 0xB3BAD0 VA: 0x180B3C6D0
	public void Refresh() { }

	// RVA: 0xB3A790 Offset: 0xB39B90 VA: 0x180B3A790
	public void FinalizeObjects() { }

}

public sealed class ERRoadNetwork.RoadUpdateCallback : MulticastDelegate // TypeDefIndex: 7274
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497240 Offset: 0x496640 VA: 0x180497240 Slot: 12
	public virtual void Invoke(ERRoad road) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(ERRoad road, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ERRoadNetwork.BuildModeCallback : MulticastDelegate // TypeDefIndex: 7275
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497060 Offset: 0x496460 VA: 0x180497060 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ERRoadNetwork.EditModeCallback : MulticastDelegate // TypeDefIndex: 7276
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497060 Offset: 0x496460 VA: 0x180497060 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

