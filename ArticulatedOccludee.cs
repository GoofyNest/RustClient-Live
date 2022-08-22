public class ArticulatedOccludee : BaseMonoBehaviour // TypeDefIndex: 9273
{	private const float UpdateBoundsFadeStart = 20;
	private const float UpdateBoundsFadeLength = 1000;
	private const float UpdateBoundsMaxFrequency = 15;
	private const float UpdateBoundsMinFrequency = 0,5;
	private LODGroup lodGroup; // 0x18
	public List<Collider> colliders; // 0x20
	private OccludeeSphere localOccludee; // 0x28
	private List<Renderer> renderers; // 0x48
	private bool isVisible; // 0x50
	private Action TriggerUpdateVisibilityBoundsDelegate; // 0x58

	public bool IsVisible { get; }


	public bool get_IsVisible() { }

	protected virtual void OnDisable() { }

	private void ClearVisibility() { }

	public void ProcessVisibility(LODGroup lod) { }

	private void RegisterForCulling(OcclusionCulling.Sphere sphere, bool visible) { }

	private void UnregisterFromCulling() { }

	public void UpdateCullingBounds() { }

	protected virtual bool CheckVisibility() { }

	private void ApplyVisibility(bool vis) { }

	protected virtual void OnVisibilityChanged(bool visible) { }

	private void UpdateVisibility(float delay) { }

	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	public virtual void TriggerUpdateVisibilityBounds() { }

	protected virtual void OnDrawGizmos() { }

	public void .ctor() { }

}

