public class TreeMarkerData : PrefabAttribute, IServerComponent // TypeDefIndex: 9677
{	public TreeMarkerData.GenerationArc[] GenerationArcs; // 0x98
	public TreeMarkerData.MarkerLocation[] Markers; // 0xA0
	public Vector3 GenerationStartPoint; // 0xA8
	public float GenerationRadius; // 0xB4
	public float MaxY; // 0xB8
	public float MinY; // 0xBC
	public bool ProcessAngleChecks; // 0xC0


	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

public struct TreeMarkerData.MarkerLocation // TypeDefIndex: 9678
{	public Vector3 LocalPosition; // 0x0
	public Vector3 LocalNormal; // 0xC

}

public struct TreeMarkerData.GenerationArc // TypeDefIndex: 9679
{	public Vector3 CentrePoint; // 0x0
	public float Radius; // 0xC
	public Vector3 Rotation; // 0x10
	public int OverrideCount; // 0x1C

}

