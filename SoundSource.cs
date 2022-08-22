public class SoundSource : MonoBehaviour, IClientComponentEx, ILOD, ISoundBudgetedUpdate // TypeDefIndex: 9043
{	[HeaderAttribute] // RVA: 0xD0300 Offset: 0xCF700 VA: 0x1800D0300
	public bool handleOcclusionChecks; // 0x18
	public LayerMask occlusionLayerMask; // 0x1C
	public List<SoundSource.OcclusionPoint> occlusionPoints; // 0x20
	public bool isOccluded; // 0x28
	public float occlusionAmount; // 0x2C
	public float lodDistance; // 0x30
	public bool inRange; // 0x34
	private bool wasInRange; // 0x35
	private LODCell cell; // 0x38
	private float lastOcclusionCheck; // 0x40
	private float occlusionCheckInterval; // 0x44
	private int lastOcclusionPointIdx; // 0x48
	private Ray ray; // 0x4C
	private List<RaycastHit> hits; // 0x68


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

public class SoundSource.OcclusionPoint // TypeDefIndex: 9044
{	public Vector3 offset; // 0x10
	public bool isOccluded; // 0x1C


	public void .ctor() { }

}

