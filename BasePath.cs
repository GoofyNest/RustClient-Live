public class BasePath : MonoBehaviour // TypeDefIndex: 8858
{	public List<BasePathNode> nodes; // 0x18
	public List<PathInterestNode> interestZones; // 0x20
	public List<PathSpeedZone> speedZones; // 0x28


	public void Start() { }

	private void AddChildren() { }

	private void ClearChildren() { }

	public static void AutoGenerateLinks(BasePath path) { }

	public void GetNodesNear(Vector3 point, ref List<BasePathNode> nearNodes, float dist = 10) { }

	public BasePathNode GetClosestToPoint(Vector3 point) { }

	public PathInterestNode GetRandomInterestNodeAwayFrom(Vector3 from, float dist = 10) { }

	public void .ctor() { }

}

