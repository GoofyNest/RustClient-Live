public class TweakUIBase : MonoBehaviour // TypeDefIndex: 12934
{
	public string convarName;
	public bool ApplyImmediatelyOnChange;
	internal ConsoleSystem.Command conVar;


	private void Awake() { }

	protected virtual void Init() { }

	public virtual void OnApplyClicked() { }

	public virtual void UnapplyChanges() { }

	protected virtual void OnConVarChanged(ConsoleSystem.Command obj) { }

	public virtual void ResetToConvar() { }

	protected virtual void SetConvarValue() { }

	private void OnDestroy() { }

	public void .ctor() { }

}

