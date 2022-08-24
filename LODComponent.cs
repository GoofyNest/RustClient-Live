public abstract class LODComponent : BaseMonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 9929
{
	public LODDistanceMode DistanceMode; 
	public LODComponent.OccludeeParameters OccludeeParams; 
	protected Transform cachedTransform; 
	protected Impostor impostor; 
	private LODEnvironmentMode EnvironmentMode; 
	private bool culled; 
	private LODCell cell; 
	private float currentDistance; 
	private bool occludeeCulled; 
	private bool occludeeShadowsVisible; 
	private float occludeeShadowRange; 
	private OccludeeSphere occludee; 
private const float OccludeeMinTimeVisible = 0,1;
	private static HashSet<LODComponent> occludeeSet; 
	private static readonly int DynamicOccludeeLowPerFrame; 
	private static readonly float DynamicOccludeeMinimumLowInterval; 
	private static ListHashSet<LODComponent> dynamicOccludees; 
	private static int dynamicOccludeeLowIndex; 

public static HashSet<LODComponent> OccludeeSet { get; }
public float CurrentDistance { get; }


public static HashSet<LODComponent> get_OccludeeSet() { }

public float get_CurrentDistance() { }

private float GetDistance() { }

protected void Awake() { }

public void SetEnvironmentMode(LODEnvironmentMode mode) { }

protected void OnEnable() { }

protected void OnDisable() { }

private void EnableCulling() { }

private void DisableCulling() { }

public void RefreshLOD() { }

public void ChangeLOD() { }

private void ChangeCulling(float distance) { }

private void ChangeCulling() { }

public static void ChangeCullingAll() { }

private void UpdateVisibility() { }

public void SetVisible(bool state) { }

protected abstract void InitLOD();

protected abstract void EnableLOD();

protected abstract void DisableLOD();

protected abstract int GetLOD(float distance);

protected abstract void SetLOD(int newlod);

protected abstract void Show();

protected abstract void Hide();

protected virtual void Hide(bool shadowsVisible) { }

protected virtual bool IsLODHiding() { }

public void WorkshopMode() { }

protected virtual bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

private void UpdateShadowRange() { }

public static void ClearOccludees() { }

private static void UpdateDynamicOccludeeBounds(LODComponent lodcomp) { }

public static void UpdateDynamicOccludees() { }

public void ResetCulling() { }

protected virtual void RegisterToCulling(bool isVisible = True) { }

protected virtual void UnregisterFromCulling() { }

protected virtual void OnVisibilityChanged(bool visible) { }

protected void .ctor() { }

private static void .cctor() { }

}

public struct LODComponent.OccludeeParameters // TypeDefIndex: 9930
{
	[TooltipAttribute] 
	public bool isDynamic; 
	[TooltipAttribute] 
	public float dynamicUpdateInterval; 
	[TooltipAttribute] 
	public float shadowRangeScale; 
	[TooltipAttribute] 
	public bool showBounds; 

}

private sealed class LODComponent.<>c // TypeDefIndex: 9931
{
	public static readonly LODComponent.<>c <>9; 
	public static Predicate<LODComponent> <>9__34_0; 


private static void .cctor() { }

public void .ctor() { }

internal bool <ChangeCullingAll>b__34_0(LODComponent i) { }

}

