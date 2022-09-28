public class SoundSource : MonoBehaviour, IClientComponentEx, ILOD, ISoundBudgetedUpdate // TypeDefIndex: 10715
{
	[HeaderAttribute] 
	public bool handleOcclusionChecks; 
	public LayerMask occlusionLayerMask; 
	public List<SoundSource.OcclusionPoint> occlusionPoints; 
	public bool isOccluded; 
	public float occlusionAmount; 
	public float lodDistance; 
	public bool inRange; 
	private bool wasInRange; 
	private LODCell cell; 
	private float lastOcclusionCheck; 
	private float occlusionCheckInterval; 
	private int lastOcclusionPointIdx; 
	private Ray ray; 
	private List<RaycastHit> hits; 


	private void OnDrawGizmosSelected() { }

	private void OnValidate() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void DoUpdate() { }

	public void DoOcclusionCheck() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	public bool IsSyncedToParent() { }

	public void .ctor() { }

}

public class SoundSource.OcclusionPoint // TypeDefIndex: 10716
{
	public Vector3 offset; 
	public bool isOccluded; 


	public void .ctor() { }

}

