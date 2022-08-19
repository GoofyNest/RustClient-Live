public class MapMarker : BaseEntity // TypeDefIndex: 9594
{	// Fields
	public AppMarkerType appType; // 0x168
	public GameObjectRef markerObj; // 0x170
	public static readonly List<MapMarker> mapMarkers; // 0x0

	// Properties
	public virtual MapMarker.ClusterType ShouldCluster { get; }
	public virtual GameObjectRef GetClusterUIMarker { get; }
	public virtual float GetClusterRadius { get; }

	// Methods

	// RVA: 0x581BE0 Offset: 0x580FE0 VA: 0x180581BE0
	public static void Init() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 131
	public virtual void SetupUIMarker(GameObject marker) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 132
	public virtual MapMarker.ClusterType get_ShouldCluster() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 133
	public virtual GameObjectRef get_GetClusterUIMarker() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 134
	public virtual float get_GetClusterRadius() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 135
	public virtual void SetupUIMarkerCluster(GameObject marker, List<MapMarker> markers) { }

	// RVA: 0x581DA0 Offset: 0x5811A0 VA: 0x180581DA0
	public static void UpdateInterface() { }

	// RVA: 0x581C50 Offset: 0x581050 VA: 0x180581C50 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x581AF0 Offset: 0x580EF0 VA: 0x180581AF0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x581A50 Offset: 0x580E50 VA: 0x180581A50 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x581EE0 Offset: 0x5812E0 VA: 0x180581EE0
	public void .ctor() { }

	// RVA: 0x581E80 Offset: 0x581280 VA: 0x180581E80
	private static void .cctor() { }

}

public enum MapMarker.ClusterType // TypeDefIndex: 9595
{	// Fields
	public int value__; // 0x0
	public const MapMarker.ClusterType None = 0;
	public const MapMarker.ClusterType Vending = 1;

}

