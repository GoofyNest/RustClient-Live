public class HitboxDefinition : MonoBehaviour // TypeDefIndex: 9265
{	public Vector3 center; // 0x18
	public Vector3 rotation; // 0x24
	public HitboxDefinition.Type type; // 0x30
	public int priority; // 0x34
	public PhysicMaterial physicMaterial; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 scale; // 0x40

	public Vector3 Scale { get; set; }
	public Matrix4x4 LocalMatrix { get; }


	public Vector3 get_Scale() { }

	public void set_Scale(Vector3 value) { }

	public Matrix4x4 get_LocalMatrix() { }

	private void OnValidate() { }

	protected virtual void OnDrawGizmosSelected() { }

	protected virtual void OnDrawGizmos() { }

	public void .ctor() { }

}

public enum HitboxDefinition.Type // TypeDefIndex: 9266
{	public int value__; // 0x0
	public const HitboxDefinition.Type BOX = 0;
	public const HitboxDefinition.Type CAPSULE = 1;

}

