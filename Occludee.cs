public class Occludee : MonoBehaviour // TypeDefIndex: 11507
{	public float minTimeVisible; // 0x18
	public bool isStatic; // 0x1C
	public bool autoRegister; // 0x1D
	public bool stickyGizmos; // 0x1E
	public OccludeeState state; // 0x20
	protected int occludeeId; // 0x28
	protected Vector3 center; // 0x2C
	protected float radius; // 0x38
	protected Renderer renderer; // 0x40
	protected Collider collider; // 0x48


	protected virtual void Awake() { }

	public void OnEnable() { }

	public void OnDisable() { }

	public void Register() { }

	public void Unregister() { }

	protected virtual void OnVisibilityChanged(bool visible) { }

	public void .ctor() { }

}

