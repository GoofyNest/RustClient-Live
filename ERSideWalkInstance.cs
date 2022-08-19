public class ERSideWalkInstance // TypeDefIndex: 7222
{	// Fields
	public ERSideWalk sidewalk; // 0x10
	public GameObject swObject; // 0x18
	public double id; // 0x20
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float start; // 0x28
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float end; // 0x2C
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3 startPos; // 0x30
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3 endPos; // 0x3C

	// Methods

	// RVA: 0xA587A0 Offset: 0xA57BA0 VA: 0x180A587A0
	public void .ctor(ERSideWalk msidewalk, float mStart, float mEnd, Vector3 mStartPos, Vector3 mEndPos, ERModularRoad road, string side) { }

	// RVA: 0xA58400 Offset: 0xA57800 VA: 0x180A58400
	public void CreateObject(ERModularRoad road, string side) { }

	// RVA: 0xA58620 Offset: 0xA57A20 VA: 0x180A58620
	public void GetObject(ERModularRoad road, string side) { }

}

