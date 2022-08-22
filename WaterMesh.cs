public class WaterMesh // TypeDefIndex: 10616
{	private Mesh borderMesh; // 0x10
	private Mesh centerPatch; // 0x18
	private int borderRingCount; // 0x20
	private float borderRingSpacingFalloff; // 0x24
	private int resolution; // 0x28
	private Vector3[] borderVerticesLocal; // 0x30
	private Vector3[] borderVerticesWorld; // 0x38
	private bool initialized; // 0x40

	public Mesh BorderMesh { get; }
	public Mesh CenterPatch { get; }
	public bool IsInitialized { get; }


	public Mesh get_BorderMesh() { }

	public Mesh get_CenterPatch() { }

	public bool get_IsInitialized() { }

	public void Initialize(int patchResolution, float patchSizeInWorld, int borderRingCount, float borderRingSpacingFalloff) { }

	public void Destroy() { }

	public void UpdateBorderMesh(Matrix4x4 centerLocalToWorld, Matrix4x4 borderLocalToWorld, bool collapseCenter) { }

	private Mesh CreateSortedBorderPatch(int resolution, int ringCount, float sizeInWorld) { }

	private Mesh CreateSortedCenterPatch(int resolution, float sizeInWorld, bool borderOnly) { }

	public void .ctor() { }

}

