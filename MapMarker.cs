public class MapMarker : BaseEntity // TypeDefIndex: 11330
{
	public AppMarkerType appType; 
	public GameObjectRef markerObj; 
	public static readonly List<MapMarker> mapMarkers; 

	public virtual MapMarker.ClusterType ShouldCluster { get; }
	public virtual GameObjectRef GetClusterUIMarker { get; }
	public virtual float GetClusterRadius { get; }


	public static void Init() { }

	public virtual void SetupUIMarker(GameObject marker) { }

	public virtual MapMarker.ClusterType get_ShouldCluster() { }

	public virtual GameObjectRef get_GetClusterUIMarker() { }

	public virtual float get_GetClusterRadius() { }

	public virtual void SetupUIMarkerCluster(GameObject marker, List<MapMarker> markers) { }

	public static void UpdateInterface() { }

	public override void PostNetworkUpdate() { }

	public override void InitShared() { }

	public override void DestroyShared() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum MapMarker.ClusterType // TypeDefIndex: 11331
{
	public int value__; 
	public const MapMarker.ClusterType None = 0;
	public const MapMarker.ClusterType Vending = 1;

}

