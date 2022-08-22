public class ERSideWalkInstance // TypeDefIndex: 7222
{	public ERSideWalk sidewalk; // 0x10
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


	public void .ctor(ERSideWalk msidewalk, float mStart, float mEnd, Vector3 mStartPos, Vector3 mEndPos, ERModularRoad road, string side) { }

	public void CreateObject(ERModularRoad road, string side) { }

	public void GetObject(ERModularRoad road, string side) { }

}

