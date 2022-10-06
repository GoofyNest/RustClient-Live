public class CullingVolume : MonoBehaviour, IClientComponent // TypeDefIndex: 11552
{
	[TooltipAttribute] 
	public GameObject OccludeeRoot; 
	[TooltipAttribute] 
	public bool Invert; 
	[TooltipAttribute] 
	public bool Portal; 
	[TooltipAttribute] 
	public List<CullingVolume> Connections; 
	private Transform root; 
	private Bounds bounds; 
	private List<LODComponent> components; 
	private List<LightOccludee> lights; 
	private float lastSeen; 


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

