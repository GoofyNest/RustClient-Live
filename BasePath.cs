public class BasePath : MonoBehaviour // TypeDefIndex: 8858
{	// Fields
	public List<BasePathNode> nodes; // 0x18
	public List<PathInterestNode> interestZones; // 0x20
	public List<PathSpeedZone> speedZones; // 0x28

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Start() { }

	// RVA: 0xA30F80 Offset: 0xA30380 VA: 0x180A30F80
	private void AddChildren() { }

	// RVA: 0xA31660 Offset: 0xA30A60 VA: 0x180A31660
	private void ClearChildren() { }

	// RVA: 0xA31180 Offset: 0xA30580 VA: 0x180A31180
	public static void AutoGenerateLinks(BasePath path) { }

	// RVA: 0xA31A70 Offset: 0xA30E70 VA: 0x180A31A70
	public void GetNodesNear(Vector3 point, ref List<BasePathNode> nearNodes, float dist = 10) { }

	// RVA: 0xA317B0 Offset: 0xA30BB0 VA: 0x180A317B0
	public BasePathNode GetClosestToPoint(Vector3 point) { }

	// RVA: 0xA31D10 Offset: 0xA31110 VA: 0x180A31D10
	public PathInterestNode GetRandomInterestNodeAwayFrom(Vector3 from, float dist = 10) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

