public class HideIfOwnerFirstPerson : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged // TypeDefIndex: 9500
{	// Fields
	public GameObject[] disableGameObjects; // 0x20
	public bool worldModelEffect; // 0x28
	protected bool lastHidden; // 0x29
	private Dictionary<Renderer, ShadowCastingMode> previousValues; // 0x30

	// Properties
	public bool IsHidden { get; }

	// Methods

	// RVA: 0x754350 Offset: 0x753750 VA: 0x180754350
	public bool get_IsHidden() { }

	// RVA: 0x753800 Offset: 0x752C00 VA: 0x180753800
	public void OnEnable() { }

	// RVA: 0x753750 Offset: 0x752B50 VA: 0x180753750
	public void OnDisable() { }

	// RVA: 0x753940 Offset: 0x752D40 VA: 0x180753940 Slot: 10
	public void OnViewModeChanged() { }

	// RVA: 0x753B90 Offset: 0x752F90 VA: 0x180753B90
	public void SetHidden(bool shouldHide) { }

	// RVA: 0x753FD0 Offset: 0x7533D0 VA: 0x180753FD0
	public bool ShouldHide() { }

	// RVA: 0x753D00 Offset: 0x753100 VA: 0x180753D00
	private void SetShadowsOnly(GameObject root) { }

	// RVA: 0x7539D0 Offset: 0x752DD0 VA: 0x1807539D0
	private void RevertShadowsOnly(GameObject root) { }

	// RVA: 0x7542E0 Offset: 0x7536E0 VA: 0x1807542E0
	public void .ctor() { }

}

