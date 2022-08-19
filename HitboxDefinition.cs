public class HitboxDefinition : MonoBehaviour // TypeDefIndex: 9265
{	// Fields
	public Vector3 center; // 0x18
	public Vector3 rotation; // 0x24
	public HitboxDefinition.Type type; // 0x30
	public int priority; // 0x34
	public PhysicMaterial physicMaterial; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 scale; // 0x40

	// Properties
	public Vector3 Scale { get; set; }
	public Matrix4x4 LocalMatrix { get; }

	// Methods

	// RVA: 0x758AC0 Offset: 0x757EC0 VA: 0x180758AC0
	public Vector3 get_Scale() { }

	// RVA: 0x758AE0 Offset: 0x757EE0 VA: 0x180758AE0
	public void set_Scale(Vector3 value) { }

	// RVA: 0x758980 Offset: 0x757D80 VA: 0x180758980
	public Matrix4x4 get_LocalMatrix() { }

	// RVA: 0x758860 Offset: 0x757C60 VA: 0x180758860
	private void OnValidate() { }

	// RVA: 0x757BB0 Offset: 0x756FB0 VA: 0x180757BB0 Slot: 4
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0x7581D0 Offset: 0x7575D0 VA: 0x1807581D0 Slot: 5
	protected virtual void OnDrawGizmos() { }

	// RVA: 0x758910 Offset: 0x757D10 VA: 0x180758910
	public void .ctor() { }

}

public enum HitboxDefinition.Type // TypeDefIndex: 9266
{	// Fields
	public int value__; // 0x0
	public const HitboxDefinition.Type BOX = 0;
	public const HitboxDefinition.Type CAPSULE = 1;

}

