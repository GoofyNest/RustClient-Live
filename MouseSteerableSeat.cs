public class MouseSteerableSeat : BaseVehicleSeat // TypeDefIndex: 9755
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool supportsMouseSteer; // 0x328
	public const BUTTON MouseSteerButton = 64;
	private bool playerIsMouseSteering; // 0x329


	public override Vector2 GetYawClamp() { }

	public override void OnClientInput(BasePlayer player) { }

	public void .ctor() { }

}

