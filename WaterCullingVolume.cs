public class WaterCullingVolume : MonoBehaviour // TypeDefIndex: 12359
{
	public bool isDynamic;
	private Bounds worldBounds;
	private Vector4[] worldToLocal;
	private bool isVisible;
	private float distanceToCamera;
	private static HashSet<WaterCullingVolume> volumes;

	public Bounds WorldBounds { get; }
	public Vector4[] WorldToLocal { get; }
	public bool IsVisible { get; }
	public float DistanceToCamera { get; }
	public static HashSet<WaterCullingVolume> Volumes { get; }


	public Bounds get_WorldBounds() { }

	public Vector4[] get_WorldToLocal() { }

	public bool get_IsVisible() { }

	public float get_DistanceToCamera() { }

	public static HashSet<WaterCullingVolume> get_Volumes() { }

	private void UpdateTransformInfo() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void Update() { }

	public bool UpdateVisibility(Plane[] frustumPlanes, Vector3 cameraWorldPos) { }

	protected void OnDrawGizmos() { }

	protected void OnDrawGizmosSelected() { }

	private void DrawGizmos(float alpha) { }

	public void .ctor() { }

	private static void .cctor() { }

}

