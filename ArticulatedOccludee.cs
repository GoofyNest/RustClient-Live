public class ArticulatedOccludee : BaseMonoBehaviour // TypeDefIndex: 10991
{
	private const float UpdateBoundsFadeStart = 20;
	private const float UpdateBoundsFadeLength = 1000;
	private const float UpdateBoundsMaxFrequency = 15;
	private const float UpdateBoundsMinFrequency = 0,5;
	private LODGroup lodGroup; 
	public List<Collider> colliders; 
	private OccludeeSphere localOccludee; 
	private List<Renderer> renderers; 
	private bool isVisible; 
	private Action TriggerUpdateVisibilityBoundsDelegate; 

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

