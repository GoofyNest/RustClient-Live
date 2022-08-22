public class VendingMachineMapMarker : MapMarker // TypeDefIndex: 9613
{	public string markerShopName; // 0x178
	public VendingMachine server_vendingMachine; // 0x180
	public VendingMachine client_vendingMachine; // 0x188
	public uint client_vendingMachineNetworkID; // 0x190
	public GameObjectRef clusterMarkerObj; // 0x198

	public override MapMarker.ClusterType ShouldCluster { get; }
	public override float GetClusterRadius { get; }
	public override GameObjectRef GetClusterUIMarker { get; }


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void DestroyShared() { }

	public override void SetupUIMarker(GameObject marker) { }

	public override MapMarker.ClusterType get_ShouldCluster() { }

	public override float get_GetClusterRadius() { }

	public override GameObjectRef get_GetClusterUIMarker() { }

	public override void SetupUIMarkerCluster(GameObject marker, List<MapMarker> markers) { }

	public void .ctor() { }

}

