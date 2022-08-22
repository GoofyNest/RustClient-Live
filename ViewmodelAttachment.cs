public class ViewmodelAttachment : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged, IViewModelUpdated // TypeDefIndex: 11452
{	public GameObjectRef modelObject; // 0x20
	public string targetBone; // 0x28
	public bool hideViewModelIronSights; // 0x30
	public GameObject spawnedGameObject; // 0x38


	public void OnEnable() { }

	public void OnDisable() { }

	public void OnViewModeChanged() { }

	public void OnViewModelUpdated() { }

	public void CreateAttachment() { }

	public virtual void RootEntFlagsChanged(BaseEntity flagCarrier) { }

	private bool IsThisOurViewmodel(BaseViewModel viewmodel) { }

	public void .ctor() { }

}

