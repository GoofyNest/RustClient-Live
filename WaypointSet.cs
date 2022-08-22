public class WaypointSet : MonoBehaviour, IServerComponent // TypeDefIndex: 12136
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<WaypointSet.Waypoint> _points; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WaypointSet.NavModes navMode; // 0x20

	public List<WaypointSet.Waypoint> Points { get; set; }
	public WaypointSet.NavModes NavMode { get; }


	public List<WaypointSet.Waypoint> get_Points() { }

	public void set_Points(List<WaypointSet.Waypoint> value) { }

	public WaypointSet.NavModes get_NavMode() { }

	private void OnDrawGizmos() { }

	public void .ctor() { }

}

public enum WaypointSet.NavModes // TypeDefIndex: 12137
{	public int value__; // 0x0
	public const WaypointSet.NavModes Loop = 0;
	public const WaypointSet.NavModes PingPong = 1;

}

public struct WaypointSet.Waypoint // TypeDefIndex: 12138
{	public Transform Transform; // 0x0
	public float WaitTime; // 0x8
	public Transform[] LookatPoints; // 0x10
	public bool IsOccupied; // 0x18

}

