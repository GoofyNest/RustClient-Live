public class TweakUIBase : MonoBehaviour // TypeDefIndex: 11139
{	// Fields
	public string convarName; // 0x18
	public bool ApplyImmediatelyOnChange; // 0x20
	internal ConsoleSystem.Command conVar; // 0x28

	// Methods

	// RVA: 0x4D0950 Offset: 0x4CFD50 VA: 0x1804D0950
	private void Awake() { }

	// RVA: 0x4D0970 Offset: 0x4CFD70 VA: 0x1804D0970 Slot: 4
	protected virtual void Init() { }

	// RVA: 0x4D0A90 Offset: 0x4CFE90 VA: 0x1804D0A90 Slot: 5
	public virtual void OnApplyClicked() { }

	// RVA: 0x4D0B30 Offset: 0x4CFF30 VA: 0x1804D0B30 Slot: 6
	public virtual void UnapplyChanges() { }

	// RVA: 0x4BF5F0 Offset: 0x4BE9F0 VA: 0x1804BF5F0 Slot: 7
	protected virtual void OnConVarChanged(ConsoleSystem.Command obj) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void ResetToConvar() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	protected virtual void SetConvarValue() { }

	// RVA: 0x4D0AB0 Offset: 0x4CFEB0 VA: 0x1804D0AB0
	private void OnDestroy() { }

	// RVA: 0x4D0B50 Offset: 0x4CFF50 VA: 0x1804D0B50
	public void .ctor() { }

}

