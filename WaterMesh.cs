public class WaterMesh // TypeDefIndex: 10627
{
	private Mesh borderMesh; 
	private Mesh centerPatch; 
	private int borderRingCount; 
	private float borderRingSpacingFalloff; 
	private int resolution; 
	private Vector3[] borderVerticesLocal; 
	private Vector3[] borderVerticesWorld; 
	private bool initialized; 

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

