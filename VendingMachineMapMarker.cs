public class VendingMachineMapMarker : MapMarker // TypeDefIndex: 9613
{	// Fields
	public string markerShopName; // 0x178
	public VendingMachine server_vendingMachine; // 0x180
	public VendingMachine client_vendingMachine; // 0x188
	public uint client_vendingMachineNetworkID; // 0x190
	public GameObjectRef clusterMarkerObj; // 0x198

	// Properties
	public override MapMarker.ClusterType ShouldCluster { get; }
	public override float GetClusterRadius { get; }
	public override GameObjectRef GetClusterUIMarker { get; }

	// Methods

	// RVA: 0xAD3D80 Offset: 0xAD3180 VA: 0x180AD3D80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD3D40 Offset: 0xAD3140 VA: 0x180AD3D40 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xAD4160 Offset: 0xAD3560 VA: 0x180AD4160 Slot: 131
	public override void SetupUIMarker(GameObject marker) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 132
	public override MapMarker.ClusterType get_ShouldCluster() { }

	// RVA: 0xAD42B0 Offset: 0xAD36B0 VA: 0x180AD42B0 Slot: 134
	public override float get_GetClusterRadius() { }

	// RVA: 0xAD42C0 Offset: 0xAD36C0 VA: 0x180AD42C0 Slot: 133
	public override GameObjectRef get_GetClusterUIMarker() { }

	// RVA: 0xAD3ED0 Offset: 0xAD32D0 VA: 0x180AD3ED0 Slot: 135
	public override void SetupUIMarkerCluster(GameObject marker, List<MapMarker> markers) { }

	// RVA: 0xAD4250 Offset: 0xAD3650 VA: 0x180AD4250
	public void .ctor() { }

}

