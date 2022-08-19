public abstract class LODComponent : BaseMonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 9929
{	// Fields
	public LODDistanceMode DistanceMode; // 0x18
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

	// Properties
	public static HashSet<LODComponent> OccludeeSet { get; }
	public float CurrentDistance { get; }

	// Methods

	// RVA: 0x6BA1D0 Offset: 0x6B95D0 VA: 0x1806BA1D0
	public static HashSet<LODComponent> get_OccludeeSet() { }

	// RVA: 0x6BA1C0 Offset: 0x6B95C0 VA: 0x1806BA1C0
	public float get_CurrentDistance() { }

	// RVA: 0x6B8CD0 Offset: 0x6B80D0 VA: 0x1806B8CD0
	private float GetDistance() { }

	// RVA: 0x6B8530 Offset: 0x6B7930 VA: 0x1806B8530
	protected void Awake() { }

	// RVA: 0x6B9860 Offset: 0x6B8C60 VA: 0x1806B9860
	public void SetEnvironmentMode(LODEnvironmentMode mode) { }

	// RVA: 0x6B9080 Offset: 0x6B8480 VA: 0x1806B9080
	protected void OnEnable() { }

	// RVA: 0x6B8E20 Offset: 0x6B8220 VA: 0x1806B8E20
	protected void OnDisable() { }

	// RVA: 0x6B8C40 Offset: 0x6B8040 VA: 0x1806B8C40
	private void EnableCulling() { }

	// RVA: 0x6B8BB0 Offset: 0x6B7FB0 VA: 0x1806B8BB0
	private void DisableCulling() { }

	// RVA: 0x6B93C0 Offset: 0x6B87C0 VA: 0x1806B93C0 Slot: 7
	public void RefreshLOD() { }

	// RVA: 0x6B8A80 Offset: 0x6B7E80 VA: 0x1806B8A80 Slot: 6
	public void ChangeLOD() { }

	// RVA: 0x6B88D0 Offset: 0x6B7CD0 VA: 0x1806B88D0
	private void ChangeCulling(float distance) { }

	// RVA: 0x6B8A70 Offset: 0x6B7E70 VA: 0x1806B8A70
	private void ChangeCulling() { }

	// RVA: 0x6B8610 Offset: 0x6B7A10 VA: 0x1806B8610
	public static void ChangeCullingAll() { }

	// RVA: 0x6B9F80 Offset: 0x6B9380 VA: 0x1806B9F80
	private void UpdateVisibility() { }

	// RVA: 0x6B9870 Offset: 0x6B8C70 VA: 0x1806B9870
	public void SetVisible(bool state) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void InitLOD();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void EnableLOD();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void DisableLOD();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract int GetLOD(float distance);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void SetLOD(int newlod);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void Show();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void Hide();

	// RVA: 0x6B8E00 Offset: 0x6B8200 VA: 0x1806B8E00 Slot: 15
	protected virtual void Hide(bool shadowsVisible) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 16
	protected virtual bool IsLODHiding() { }

	// RVA: 0x6BA010 Offset: 0x6B9410 VA: 0x1806BA010
	public void WorkshopMode() { }

	// RVA: 0x6B8BA0 Offset: 0x6B7FA0 VA: 0x1806B8BA0 Slot: 17
	protected virtual bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x6B9F60 Offset: 0x6B9360 VA: 0x1806B9F60
	private void UpdateShadowRange() { }

	// RVA: 0x6B8AF0 Offset: 0x6B7EF0 VA: 0x1806B8AF0
	public static void ClearOccludees() { }

	// RVA: 0x6B9970 Offset: 0x6B8D70 VA: 0x1806B9970
	private static void UpdateDynamicOccludeeBounds(LODComponent lodcomp) { }

	// RVA: 0x6B9AC0 Offset: 0x6B8EC0 VA: 0x1806B9AC0
	public static void UpdateDynamicOccludees() { }

	// RVA: 0x6B9800 Offset: 0x6B8C00 VA: 0x1806B9800
	public void ResetCulling() { }

	// RVA: 0x6B95A0 Offset: 0x6B89A0 VA: 0x1806B95A0 Slot: 18
	protected virtual void RegisterToCulling(bool isVisible = True) { }

	// RVA: 0x6B9880 Offset: 0x6B8C80 VA: 0x1806B9880 Slot: 19
	protected virtual void UnregisterFromCulling() { }

	// RVA: 0x6B9280 Offset: 0x6B8680 VA: 0x1806B9280 Slot: 20
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x6BA120 Offset: 0x6B9520 VA: 0x1806BA120
	protected void .ctor() { }

	// RVA: 0x6BA040 Offset: 0x6B9440 VA: 0x1806BA040
	private static void .cctor() { }

}

public struct LODComponent.OccludeeParameters // TypeDefIndex: 9930
{	// Fields
	[TooltipAttribute] // RVA: 0xA9A80 Offset: 0xA8E80 VA: 0x1800A9A80
	public bool isDynamic; // 0x0
	[TooltipAttribute] // RVA: 0xA9B40 Offset: 0xA8F40 VA: 0x1800A9B40
	public float dynamicUpdateInterval; // 0x4
	[TooltipAttribute] // RVA: 0xA9BB0 Offset: 0xA8FB0 VA: 0x1800A9BB0
	public float shadowRangeScale; // 0x8
	[TooltipAttribute] // RVA: 0xA9BE0 Offset: 0xA8FE0 VA: 0x1800A9BE0
	public bool showBounds; // 0xC

}

private sealed class LODComponent.<>c // TypeDefIndex: 9931
{	// Fields
	public static readonly LODComponent.<>c <>9; // 0x0
	public static Predicate<LODComponent> <>9__34_0; // 0x8

	// Methods

	// RVA: 0x6C6640 Offset: 0x6C5A40 VA: 0x1806C6640
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6C62D0 Offset: 0x6C56D0 VA: 0x1806C62D0
	internal bool <ChangeCullingAll>b__34_0(LODComponent i) { }

}

