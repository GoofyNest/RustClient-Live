public class ViewmodelAttachment : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged, IViewModelUpdated // TypeDefIndex: 13270
{
	public GameObjectRef modelObject;
	public string targetBone;
	public bool hideViewModelIronSights;
	public GameObject spawnedGameObject;
	private BaseEntity cachedFlagUpdate;


	public void OnEnable() { }

	public void OnDisable() { }

	public void OnViewModeChanged() { }

	public void OnViewModelUpdated() { }

	public void CreateAttachment() { }

	public virtual void RootEntFlagsChanged(BaseEntity flagCarrier) { }

	private bool IsThisOurViewmodel(BaseViewModel viewmodel) { }

	public void .ctor() { }

}

