public class ERSideWalkInstance // TypeDefIndex: 7222
{
	public ERSideWalk sidewalk; 
	public GameObject swObject; 
	public double id; 
	[HideInInspector] 
	public float start; 
	[HideInInspector] 
	public float end; 
	[HideInInspector] 
	public Vector3 startPos; 
	[HideInInspector] 
	public Vector3 endPos; 


	public void .ctor(ERSideWalk msidewalk, float mStart, float mEnd, Vector3 mStartPos, Vector3 mEndPos, ERModularRoad road, string side) { }

	public void CreateObject(ERModularRoad road, string side) { }

	public void GetObject(ERModularRoad road, string side) { }

}

