public class Occludee : MonoBehaviour // TypeDefIndex: 13259
{
	public float minTimeVisible; 
	public bool isStatic; 
	public bool autoRegister; 
	public bool stickyGizmos; 
	public OccludeeState state; 
	protected int occludeeId; 
	protected Vector3 center; 
	protected float radius; 
	protected Renderer renderer; 
	protected Collider collider; 


	protected virtual void Awake() { }

	public void OnEnable() { }

	public void OnDisable() { }

	public void Register() { }

	public void Unregister() { }

	protected virtual void OnVisibilityChanged(bool visible) { }

	public void .ctor() { }

}

