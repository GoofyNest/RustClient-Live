public class ERLaneConnector // TypeDefIndex: 7243
{
	public Vector3 connectorStart; 
	public Vector3 connectorEnd; 
	public Vector3 connectorStartLocal; 
	public Vector3 connectorEndLocal; 
	public Vector3[] points; 
	public int startLaneIndex; 
	public int endLaneIndex; 
	public int endConnectionIndex; 
	public ERLane laneType; 
	public ERDirectionType laneDirection; 
	public float startOffset; 
	public float endOffset; 
	public float strength; 
	public bool mainConnection; 
	public bool stop; 
	public float speedLimit; 
	public float minSpeed; 
	public float maxSpeed; 


public static ERLaneConnector CreateInstance() { }

public static List<ERLaneConnector> GetLaneConnectors(ERLaneData laneData, int index) { }

public void .ctor() { }

}

