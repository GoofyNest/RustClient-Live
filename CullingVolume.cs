public class CullingVolume : MonoBehaviour, IClientComponent // TypeDefIndex: 9841
{	// Fields
	[TooltipAttribute] // RVA: 0x9F040 Offset: 0x9E440 VA: 0x18009F040
	public GameObject OccludeeRoot; // 0x18
	[TooltipAttribute] // RVA: 0x9F0B0 Offset: 0x9E4B0 VA: 0x18009F0B0
	public bool Invert; // 0x20
	[TooltipAttribute] // RVA: 0x9F120 Offset: 0x9E520 VA: 0x18009F120
	public bool Portal; // 0x21
	[TooltipAttribute] // RVA: 0x9F200 Offset: 0x9E600 VA: 0x18009F200
	public List<CullingVolume> Connections; // 0x28
	private Transform root; // 0x30
	private Bounds bounds; // 0x38
	private List<LODComponent> components; // 0x50
	private List<LightOccludee> lights; // 0x58
	private float lastSeen; // 0x60

	// Methods

	// RVA: 0x5206F0 Offset: 0x51FAF0 VA: 0x1805206F0
	protected void Awake() { }

	// RVA: 0x520FC0 Offset: 0x5203C0 VA: 0x180520FC0
	protected void Start() { }

	// RVA: 0x520FD0 Offset: 0x5203D0 VA: 0x180520FD0
	private void UpdateBounds() { }

	// RVA: 0x521360 Offset: 0x520760 VA: 0x180521360
	private void UpdateTrigger() { }

	// RVA: 0x521020 Offset: 0x520420 VA: 0x180521020
	private void UpdateComponents() { }

	// RVA: 0x5211F0 Offset: 0x5205F0 VA: 0x1805211F0
	private void UpdateLights() { }

	// RVA: 0x520C10 Offset: 0x520010 VA: 0x180520C10
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x520AB0 Offset: 0x51FEB0 VA: 0x180520AB0
	public void MarkSeen(bool recursive = True) { }

	// RVA: 0x521490 Offset: 0x520890 VA: 0x180521490
	public bool UpdateVisible(bool recursive = True) { }

	// RVA: 0x520A80 Offset: 0x51FE80 VA: 0x180520A80
	private bool IsVisible() { }

	// RVA: 0x520D90 Offset: 0x520190 VA: 0x180520D90
	private void SetVisible(bool state) { }

	// RVA: 0x5215F0 Offset: 0x5209F0 VA: 0x1805215F0
	public void .ctor() { }

}

