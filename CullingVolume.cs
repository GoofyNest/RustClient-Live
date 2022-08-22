public class CullingVolume : MonoBehaviour, IClientComponent // TypeDefIndex: 9841
{	[TooltipAttribute] // RVA: 0x9F040 Offset: 0x9E440 VA: 0x18009F040
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


	protected void Awake() { }

	protected void Start() { }

	private void UpdateBounds() { }

	private void UpdateTrigger() { }

	private void UpdateComponents() { }

	private void UpdateLights() { }

	protected void OnDrawGizmosSelected() { }

	public void MarkSeen(bool recursive = True) { }

	public bool UpdateVisible(bool recursive = True) { }

	private bool IsVisible() { }

	private void SetVisible(bool state) { }

	public void .ctor() { }

}

