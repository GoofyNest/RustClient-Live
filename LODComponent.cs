public abstract class LODComponent : BaseMonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 9929
{	public LODDistanceMode DistanceMode; // 0x18
	public LODComponent.OccludeeParameters OccludeeParams; // 0x1C
	protected Transform cachedTransform; // 0x30
	protected Impostor impostor; // 0x38
	private LODEnvironmentMode EnvironmentMode; // 0x40
	private bool culled; // 0x44
	private LODCell cell; // 0x48
	private float currentDistance; // 0x50
	private bool occludeeCulled; // 0x54
	private bool occludeeShadowsVisible; // 0x55
	private float occludeeShadowRange; // 0x58
	private OccludeeSphere occludee; // 0x60
	private const float OccludeeMinTimeVisible = 0,1;
	private static HashSet<LODComponent> occludeeSet; // 0x0
	private static readonly int DynamicOccludeeLowPerFrame; // 0x8
	private static readonly float DynamicOccludeeMinimumLowInterval; // 0xC
	private static ListHashSet<LODComponent> dynamicOccludees; // 0x10
	private static int dynamicOccludeeLowIndex; // 0x18

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
{	[TooltipAttribute] // RVA: 0xA9A80 Offset: 0xA8E80 VA: 0x1800A9A80
	public bool isDynamic; // 0x0
	[TooltipAttribute] // RVA: 0xA9B40 Offset: 0xA8F40 VA: 0x1800A9B40
	public float dynamicUpdateInterval; // 0x4
	[TooltipAttribute] // RVA: 0xA9BB0 Offset: 0xA8FB0 VA: 0x1800A9BB0
	public float shadowRangeScale; // 0x8
	[TooltipAttribute] // RVA: 0xA9BE0 Offset: 0xA8FE0 VA: 0x1800A9BE0
	public bool showBounds; // 0xC

}

private sealed class LODComponent.<>c // TypeDefIndex: 9931
{	public static readonly LODComponent.<>c <>9; // 0x0
	public static Predicate<LODComponent> <>9__34_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <ChangeCullingAll>b__34_0(LODComponent i) { }

}

