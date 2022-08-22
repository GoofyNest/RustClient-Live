public class ConvarComponent : MonoBehaviour // TypeDefIndex: 11298
{	public bool runOnServer; // 0x18
	public bool runOnClient; // 0x19
	public List<ConvarComponent.ConvarEvent> List; // 0x20


	protected void OnEnable() { }

	protected void OnDisable() { }

	private bool ShouldRun() { }

	public void .ctor() { }

}

public class ConvarComponent.ConvarEvent // TypeDefIndex: 11299
{	public string convar; // 0x10
	public string on; // 0x18
	public MonoBehaviour component; // 0x20
	internal ConsoleSystem.Command cmd; // 0x28


	public void OnEnable() { }

	private void cmd_OnValueChanged(ConsoleSystem.Command obj) { }

	public void OnDisable() { }

	public void .ctor() { }

}

