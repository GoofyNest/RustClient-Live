public class HideIfOwnerFirstPerson : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged // TypeDefIndex: 9500
{	public GameObject[] disableGameObjects; // 0x20
	public bool worldModelEffect; // 0x28
	protected bool lastHidden; // 0x29
	private Dictionary<Renderer, ShadowCastingMode> previousValues; // 0x30

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

