public class WaterCullingVolume : MonoBehaviour // TypeDefIndex: 10600
{	public bool isDynamic; // 0x18
	private Bounds worldBounds; // 0x1C
	private Vector4[] worldToLocal; // 0x38
	private bool isVisible; // 0x40
	private float distanceToCamera; // 0x44
	private static HashSet<WaterCullingVolume> volumes; // 0x0

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

