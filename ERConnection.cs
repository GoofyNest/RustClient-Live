public class ERConnection // TypeDefIndex: 7265
{
	public string name; 
	public ERCrossingPrefabs prefabScript; 
	public GameObject gameObject; 
	public ERConnectionData[] connectionData; 
	public static string str; 


	public void .ctor(GameObject go, string g_name) { }

	public static ERConnection Create(GameObject go) { }

	public void SetPosition(Vector3 pos) { }

	public string GetName() { }

	public void SetName(string name) { }

	public void SetRotation(Vector3 euler) { }

	public void Destroy() { }

	public void UnConnect(int connectionIndex) { }

	public ERConnectionData[] GetConnectionData() { }

	public Vector3 GetLocalConnectionPosition(int connectionIndex) { }

	public Vector3[] GetLocalConnectionPositions() { }

	public Vector3[] GetConnectionWorldPositions() { }

	public Vector3 GetConnectionWorldPosition(int connectionIndex) { }

	public int FindNearestConnectionIndex(Vector3 position) { }

	public bool SwapTurn() { }

	public bool RotateConnections() { }

	public ERRoad GetConnectedRoad(int index, out ConnectedTo connectedTo) { }

	public ERLaneConnector[] GetLaneData(int connectionIndex) { }

	public ERLaneConnector[] GetLaneData(int connectionIndex, int lane) { }

	public int GetConnectionCount() { }

	public void AverageNormals(bool flag) { }

	public bool RecalculateNormals() { }

	public bool RecalculateTangents() { }

	public void Refresh() { }

	public bool IsFlexConnector() { }

	private static void .cctor() { }

}

