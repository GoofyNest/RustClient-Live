public class ViewmodelAttachment : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged, IViewModelUpdated // TypeDefIndex: 11452
{	// Fields
	public GameObjectRef modelObject; // 0x20
	public string targetBone; // 0x28
	public bool hideViewModelIronSights; // 0x30
	public GameObject spawnedGameObject; // 0x38

	// Methods

	// RVA: 0x7D6930 Offset: 0x7D5D30 VA: 0x1807D6930
	public void OnEnable() { }

	// RVA: 0x7D6730 Offset: 0x7D5B30 VA: 0x1807D6730
	public void OnDisable() { }

	// RVA: 0x7D69E0 Offset: 0x7D5DE0 VA: 0x1807D69E0 Slot: 10
	public void OnViewModeChanged() { }

	// RVA: 0x7D69E0 Offset: 0x7D5DE0 VA: 0x1807D69E0 Slot: 11
	public void OnViewModelUpdated() { }

	// RVA: 0x7D60D0 Offset: 0x7D54D0 VA: 0x1807D60D0
	public void CreateAttachment() { }

	// RVA: 0x7D69F0 Offset: 0x7D5DF0 VA: 0x1807D69F0 Slot: 12
	public virtual void RootEntFlagsChanged(BaseEntity flagCarrier) { }

	// RVA: 0x7D65D0 Offset: 0x7D59D0 VA: 0x1807D65D0
	private bool IsThisOurViewmodel(BaseViewModel viewmodel) { }

	// RVA: 0x7D6AD0 Offset: 0x7D5ED0 VA: 0x1807D6AD0
	public void .ctor() { }

}

