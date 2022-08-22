public class TweakUIBase : MonoBehaviour // TypeDefIndex: 11139
{	public string convarName; // 0x18
	public bool ApplyImmediatelyOnChange; // 0x20
	internal ConsoleSystem.Command conVar; // 0x28


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

