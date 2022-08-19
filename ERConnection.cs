public class ERConnection // TypeDefIndex: 7257
{	// Fields
	public string name; // 0x10
	public ERCrossingPrefabs prefabScript; // 0x18
	public GameObject gameObject; // 0x20
	public ERConnectionData[] connectionData; // 0x28
	public static string str; // 0x0

	// Methods

	// RVA: 0xB7C490 Offset: 0xB7B890 VA: 0x180B7C490
	public void .ctor(GameObject go, string g_name) { }

	// RVA: 0xB79BC0 Offset: 0xB78FC0 VA: 0x180B79BC0
	public static ERConnection Create(GameObject go) { }

	// RVA: 0xB7BAC0 Offset: 0xB7AEC0 VA: 0x180B7BAC0
	public void SetPosition(Vector3 pos) { }

	// RVA: 0xB7B220 Offset: 0xB7A620 VA: 0x180B7B220
	public string GetName() { }

	// RVA: 0xB7BA30 Offset: 0xB7AE30 VA: 0x180B7BA30
	public void SetName(string name) { }

	// RVA: 0xB7BD80 Offset: 0xB7B180 VA: 0x180B7BD80
	public void SetRotation(Vector3 euler) { }

	// RVA: 0xB79CE0 Offset: 0xB790E0 VA: 0x180B79CE0
	public void Destroy() { }

	// RVA: 0xB7C2B0 Offset: 0xB7B6B0 VA: 0x180B7C2B0
	public void UnConnect(int connectionIndex) { }

	// RVA: 0xB7A330 Offset: 0xB79730 VA: 0x180B7A330
	public ERConnectionData[] GetConnectionData() { }

	// RVA: 0xB7ADD0 Offset: 0xB7A1D0 VA: 0x180B7ADD0
	public Vector3 GetLocalConnectionPosition(int connectionIndex) { }

	// RVA: 0xB7AFD0 Offset: 0xB7A3D0 VA: 0x180B7AFD0
	public Vector3[] GetLocalConnectionPositions() { }

	// RVA: 0xB7A740 Offset: 0xB79B40 VA: 0x180B7A740
	public Vector3[] GetConnectionWorldPositions() { }

	// RVA: 0xB7A600 Offset: 0xB79A00 VA: 0x180B7A600
	public Vector3 GetConnectionWorldPosition(int connectionIndex) { }

	// RVA: 0xB79DD0 Offset: 0xB791D0 VA: 0x180B79DD0
	public int FindNearestConnectionIndex(Vector3 position) { }

	// RVA: 0xB7C040 Offset: 0xB7B440 VA: 0x180B7C040
	public bool SwapTurn() { }

	// RVA: 0xB7B910 Offset: 0xB7AD10 VA: 0x180B7B910
	public bool RotateConnections() { }

	// RVA: 0xB79F10 Offset: 0xB79310 VA: 0x180B79F10
	public ERRoad GetConnectedRoad(int index, out ConnectedTo connectedTo) { }

	// RVA: 0xB7A980 Offset: 0xB79D80 VA: 0x180B7A980
	public ERLaneConnector[] GetLaneData(int connectionIndex) { }

	// RVA: 0xB7AA70 Offset: 0xB79E70 VA: 0x180B7AA70
	public ERLaneConnector[] GetLaneData(int connectionIndex, int lane) { }

	// RVA: 0xB7A2E0 Offset: 0xB796E0 VA: 0x180B7A2E0
	public int GetConnectionCount() { }

	// RVA: 0xB79BA0 Offset: 0xB78FA0 VA: 0x180B79BA0
	public void AverageNormals(bool flag) { }

	// RVA: 0xB7B470 Offset: 0xB7A870 VA: 0x180B7B470
	public bool RecalculateNormals() { }

	// RVA: 0xB7B570 Offset: 0xB7A970 VA: 0x180B7B570
	public bool RecalculateTangents() { }

	// RVA: 0xB7B670 Offset: 0xB7AA70 VA: 0x180B7B670
	public void Refresh() { }

	// RVA: 0xB7B2B0 Offset: 0xB7A6B0 VA: 0x180B7B2B0
	public bool IsFlexConnector() { }

	// RVA: 0xB7C450 Offset: 0xB7B850 VA: 0x180B7C450
	private static void .cctor() { }

}

