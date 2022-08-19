public class MouseSteerableSeat : BaseVehicleSeat // TypeDefIndex: 9755
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool supportsMouseSteer; // 0x328
	public const BUTTON MouseSteerButton = 64;
	private bool playerIsMouseSteering; // 0x329

	// Methods

	// RVA: 0x7B9560 Offset: 0x7B8960 VA: 0x1807B9560 Slot: 152
	public override Vector2 GetYawClamp() { }

	// RVA: 0x7B9630 Offset: 0x7B8A30 VA: 0x1807B9630 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x5BFDE0 Offset: 0x5BF1E0 VA: 0x1805BFDE0
	public void .ctor() { }

}

