public class ConvarComponent : MonoBehaviour // TypeDefIndex: 11298
{	// Fields
	public bool runOnServer; // 0x18
	public bool runOnClient; // 0x19
	public List<ConvarComponent.ConvarEvent> List; // 0x20

	// Methods

	// RVA: 0x5154E0 Offset: 0x5148E0 VA: 0x1805154E0
	protected void OnEnable() { }

	// RVA: 0x5152E0 Offset: 0x5146E0 VA: 0x1805152E0
	protected void OnDisable() { }

	// RVA: 0x515600 Offset: 0x514A00 VA: 0x180515600
	private bool ShouldRun() { }

	// RVA: 0x515610 Offset: 0x514A10 VA: 0x180515610
	public void .ctor() { }

}

public class ConvarComponent.ConvarEvent // TypeDefIndex: 11299
{	// Fields
	public string convar; // 0x10
	public string on; // 0x18
	public MonoBehaviour component; // 0x20
	internal ConsoleSystem.Command cmd; // 0x28

	// Methods

	// RVA: 0x515750 Offset: 0x514B50 VA: 0x180515750
	public void OnEnable() { }

	// RVA: 0x515900 Offset: 0x514D00 VA: 0x180515900
	private void cmd_OnValueChanged(ConsoleSystem.Command obj) { }

	// RVA: 0x515690 Offset: 0x514A90 VA: 0x180515690
	public void OnDisable() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

