public class SoundSource : MonoBehaviour, IClientComponentEx, ILOD, ISoundBudgetedUpdate // TypeDefIndex: 9043
{	// Fields
	[HeaderAttribute] // RVA: 0xD0300 Offset: 0xCF700 VA: 0x1800D0300
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

	// Methods

	// RVA: 0xA78330 Offset: 0xA77730 VA: 0x180A78330
	private void OnDrawGizmosSelected() { }

	// RVA: 0xA78650 Offset: 0xA77A50 VA: 0x180A78650
	private void OnValidate() { }

	// RVA: 0xA78500 Offset: 0xA77900 VA: 0x180A78500
	private void OnEnable() { }

	// RVA: 0xA781A0 Offset: 0xA775A0 VA: 0x180A781A0
	private void OnDisable() { }

	// RVA: 0xA780B0 Offset: 0xA774B0 VA: 0x180A780B0 Slot: 7
	public void DoUpdate() { }

	// RVA: 0xA77AE0 Offset: 0xA76EE0 VA: 0x180A77AE0
	public void DoOcclusionCheck() { }

	// RVA: 0xA787D0 Offset: 0xA77BD0 VA: 0x180A787D0 Slot: 6
	public void RefreshLOD() { }

	// RVA: 0xA77A90 Offset: 0xA76E90 VA: 0x180A77A90 Slot: 5
	public void ChangeLOD() { }

	// RVA: 0xA78720 Offset: 0xA77B20 VA: 0x180A78720 Slot: 9
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public bool IsSyncedToParent() { }

	// RVA: 0xA78850 Offset: 0xA77C50 VA: 0x180A78850
	public void .ctor() { }

}

public class SoundSource.OcclusionPoint // TypeDefIndex: 9044
{	// Fields
	public Vector3 offset; // 0x10
	public bool isOccluded; // 0x1C

	// Methods

	// RVA: 0xA6FB10 Offset: 0xA6EF10 VA: 0x180A6FB10
	public void .ctor() { }

}

