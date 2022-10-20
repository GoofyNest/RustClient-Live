public class HitboxDefinition : MonoBehaviour // TypeDefIndex: 10982
{
	public Vector3 center; 
	public Vector3 rotation; 
	public HitboxDefinition.Type type; 
	public int priority; 
	public PhysicMaterial physicMaterial; 
	[SerializeField] 
	private Vector3 scale; 

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

public enum HitboxDefinition.Type // TypeDefIndex: 10983
{
	public int value__; 
	public const HitboxDefinition.Type BOX = 0;
	public const HitboxDefinition.Type CAPSULE = 1;

}

