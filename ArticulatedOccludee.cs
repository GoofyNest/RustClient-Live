public class ArticulatedOccludee : BaseMonoBehaviour // TypeDefIndex: 9273
{	// Fields
	private const float UpdateBoundsFadeStart = 20;
	private const float UpdateBoundsFadeLength = 1000;
	private const float UpdateBoundsMaxFrequency = 15;
	private const float UpdateBoundsMinFrequency = 0,5;
	private LODGroup lodGroup; // 0x18
	public List<Collider> colliders; // 0x20
	private OccludeeSphere localOccludee; // 0x28
	private List<Renderer> renderers; // 0x48
	private bool isVisible; // 0x50
	private Action TriggerUpdateVisibilityBoundsDelegate; // 0x58

	// Properties
	public bool IsVisible { get; }

	// Methods

	// RVA: 0x778E40 Offset: 0x778240 VA: 0x180778E40
	public bool get_IsVisible() { }

	// RVA: 0x82C810 Offset: 0x82BC10 VA: 0x18082C810 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x82C6C0 Offset: 0x82BAC0 VA: 0x18082C6C0
	private void ClearVisibility() { }

	// RVA: 0x82CC20 Offset: 0x82C020 VA: 0x18082CC20
	public void ProcessVisibility(LODGroup lod) { }

	// RVA: 0x82CDF0 Offset: 0x82C1F0 VA: 0x18082CDF0
	private void RegisterForCulling(OcclusionCulling.Sphere sphere, bool visible) { }

	// RVA: 0x82D290 Offset: 0x82C690 VA: 0x18082D290
	private void UnregisterFromCulling() { }

	// RVA: 0x82D310 Offset: 0x82C710 VA: 0x18082D310
	public void UpdateCullingBounds() { }

	// RVA: 0x82C6A0 Offset: 0x82BAA0 VA: 0x18082C6A0 Slot: 7
	protected virtual bool CheckVisibility() { }

	// RVA: 0x82C590 Offset: 0x82B990 VA: 0x18082C590
	private void ApplyVisibility(bool vis) { }

	// RVA: 0x82CA80 Offset: 0x82BE80 VA: 0x18082CA80 Slot: 8
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x82DB70 Offset: 0x82CF70 VA: 0x18082DB70
	private void UpdateVisibility(float delay) { }

	// RVA: 0x82DE40 Offset: 0x82D240 VA: 0x18082DE40
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0x82D040 Offset: 0x82C440 VA: 0x18082D040 Slot: 9
	public virtual void TriggerUpdateVisibilityBounds() { }

	// RVA: 0x82C9B0 Offset: 0x82BDB0 VA: 0x18082C9B0 Slot: 10
	protected virtual void OnDrawGizmos() { }

	// RVA: 0x82DEF0 Offset: 0x82D2F0 VA: 0x18082DEF0
	public void .ctor() { }

}

