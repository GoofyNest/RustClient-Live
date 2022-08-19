public class WaypointSet : MonoBehaviour, IServerComponent // TypeDefIndex: 12136
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<WaypointSet.Waypoint> _points; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WaypointSet.NavModes navMode; // 0x20

	// Properties
	public List<WaypointSet.Waypoint> Points { get; set; }
	public WaypointSet.NavModes NavMode { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public List<WaypointSet.Waypoint> get_Points() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Points(List<WaypointSet.Waypoint> value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public WaypointSet.NavModes get_NavMode() { }

	// RVA: 0x4CFC10 Offset: 0x4CF010 VA: 0x1804CFC10
	private void OnDrawGizmos() { }

	// RVA: 0x4D0100 Offset: 0x4CF500 VA: 0x1804D0100
	public void .ctor() { }

}

public enum WaypointSet.NavModes // TypeDefIndex: 12137
{	// Fields
	public int value__; // 0x0
	public const WaypointSet.NavModes Loop = 0;
	public const WaypointSet.NavModes PingPong = 1;

}

public struct WaypointSet.Waypoint // TypeDefIndex: 12138
{	// Fields
	public Transform Transform; // 0x0
	public float WaitTime; // 0x8
	public Transform[] LookatPoints; // 0x10
	public bool IsOccupied; // 0x18

}

