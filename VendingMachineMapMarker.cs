public class VendingMachineMapMarker : MapMarker // TypeDefIndex: 11349
{
	public string markerShopName; 
	public VendingMachine server_vendingMachine; 
	public VendingMachine client_vendingMachine; 
	public uint client_vendingMachineNetworkID; 
	public GameObjectRef clusterMarkerObj; 

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

