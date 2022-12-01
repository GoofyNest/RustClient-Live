public class LODMasterMesh : LODComponent // TypeDefIndex: 11683
{
	public MeshRenderer ReplacementMesh;
	public float Distance;
	public LODComponent[] ChildComponents;
	public bool Block;
	public Bounds MeshBounds;
	private static Material DebugMaterial;
	private Material originalMaterial;
	private int curlod;
	private bool force;
	private static LODMasterMesh.LODEnableQueue EnableQueue;
	private static LODMasterMesh.LODEnableQueue DisableQueue;
	private bool showState;


	protected override void InitLOD() { }

	protected override void EnableLOD() { }

	protected override void DisableLOD() { }

	protected override bool OverrideDistance(out float dist) { }

	protected override int GetLOD(float distance) { }

	protected override void SetLOD(int newlod) { }

	protected override void Show() { }

	protected override void Hide() { }

	protected override bool IsLODHiding() { }

	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	private void ShowReplacementMesh(bool state) { }

	private void DelayedDisable() { }

	public static void RunLODQueues(float maxTime) { }

	public static void ClearQueues() { }

	public static string QueueInfo() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class LODMasterMesh.LODEnableQueue : ObjectWorkQueue<LODComponent> // TypeDefIndex: 11684
{
	public bool TargetState;


	protected override bool ShouldAdd(LODComponent entity) { }

	protected override void RunJob(LODComponent entity) { }

	public void .ctor() { }

}

