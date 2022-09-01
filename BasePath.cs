public class BasePath : MonoBehaviour // TypeDefIndex: 8861
{
	public List<BasePathNode> nodes; 
	public List<PathInterestNode> interestZones; 
	public List<PathSpeedZone> speedZones; 


	public void Start() { }

	private void AddChildren() { }

	private void ClearChildren() { }

	public static void AutoGenerateLinks(BasePath path) { }

	public void GetNodesNear(Vector3 point, ref List<BasePathNode> nearNodes, float dist = 10) { }

	public BasePathNode GetClosestToPoint(Vector3 point) { }

	public PathInterestNode GetRandomInterestNodeAwayFrom(Vector3 from, float dist = 10) { }

	public void .ctor() { }

}

