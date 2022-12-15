public class HideIfOwnerFirstPerson : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged // TypeDefIndex: 11251
{
	public GameObject[] disableGameObjects;
	public bool worldModelEffect;
	protected bool lastHidden;
	private Dictionary<Renderer, ShadowCastingMode> previousValues;

	public bool IsHidden { get; }


	public bool get_IsHidden() { }

	public void OnEnable() { }

	public void OnDisable() { }

	public void OnViewModeChanged() { }

	public void SetHidden(bool shouldHide) { }

	public bool ShouldHide() { }

	private void SetShadowsOnly(GameObject root) { }

	private void RevertShadowsOnly(GameObject root) { }

	public void .ctor() { }

}

