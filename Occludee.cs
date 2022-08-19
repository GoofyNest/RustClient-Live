public class Occludee : MonoBehaviour // TypeDefIndex: 11507
{	// Fields
	public float minTimeVisible; // 0x18
	public bool isStatic; // 0x1C
	public bool autoRegister; // 0x1D
	public bool stickyGizmos; // 0x1E
	public OccludeeState state; // 0x20
	protected int occludeeId; // 0x28
	protected Vector3 center; // 0x2C
	protected float radius; // 0x38
	protected Renderer renderer; // 0x40
	protected Collider collider; // 0x48

	// Methods

	// RVA: 0xA3B230 Offset: 0xA3A630 VA: 0x180A3B230 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0xA3B3D0 Offset: 0xA3A7D0 VA: 0x180A3B3D0
	public void OnEnable() { }

	// RVA: 0xA3B2A0 Offset: 0xA3A6A0 VA: 0x180A3B2A0
	public void OnDisable() { }

	// RVA: 0xA3B4E0 Offset: 0xA3A8E0 VA: 0x180A3B4E0
	public void Register() { }

	// RVA: 0xA3B980 Offset: 0xA3AD80 VA: 0x180A3B980
	public void Unregister() { }

	// RVA: 0xA3B450 Offset: 0xA3A850 VA: 0x180A3B450 Slot: 5
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0xA3BAA0 Offset: 0xA3AEA0 VA: 0x180A3BAA0
	public void .ctor() { }

}

