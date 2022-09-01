public class WaypointSet : MonoBehaviour, IServerComponent // TypeDefIndex: 12164
{
	[SerializeField] 
	private List<WaypointSet.Waypoint> _points; 
	[SerializeField] 
	private WaypointSet.NavModes navMode; 

	public List<WaypointSet.Waypoint> Points { get; set; }
	public WaypointSet.NavModes NavMode { get; }


	public List<WaypointSet.Waypoint> get_Points() { }

	public void set_Points(List<WaypointSet.Waypoint> value) { }

	public WaypointSet.NavModes get_NavMode() { }

	private void OnDrawGizmos() { }

	public void .ctor() { }

}

public enum WaypointSet.NavModes // TypeDefIndex: 12165
{
	public int value__; 
	public const WaypointSet.NavModes Loop = 0;
	public const WaypointSet.NavModes PingPong = 1;

}

public struct WaypointSet.Waypoint // TypeDefIndex: 12166
{
	public Transform Transform; 
	public float WaitTime; 
	public Transform[] LookatPoints; 
	public bool IsOccupied; 

}

