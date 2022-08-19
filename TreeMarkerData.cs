public class TreeMarkerData : PrefabAttribute, IServerComponent // TypeDefIndex: 9677
{	// Fields
	public TreeMarkerData.GenerationArc[] GenerationArcs; // 0x98
	public TreeMarkerData.MarkerLocation[] Markers; // 0xA0
	public Vector3 GenerationStartPoint; // 0xA8
	public float GenerationRadius; // 0xB4
	public float MaxY; // 0xB8
	public float MinY; // 0xBC
	public bool ProcessAngleChecks; // 0xC0

	// Methods

	// RVA: 0x9FD1F0 Offset: 0x9FC5F0 VA: 0x1809FD1F0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x9FD250 Offset: 0x9FC650 VA: 0x1809FD250
	public void .ctor() { }

}

public struct TreeMarkerData.MarkerLocation // TypeDefIndex: 9678
{	// Fields
	public Vector3 LocalPosition; // 0x0
	public Vector3 LocalNormal; // 0xC

}

public struct TreeMarkerData.GenerationArc // TypeDefIndex: 9679
{	// Fields
	public Vector3 CentrePoint; // 0x0
	public float Radius; // 0xC
	public Vector3 Rotation; // 0x10
	public int OverrideCount; // 0x1C

}

