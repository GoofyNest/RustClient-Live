public class BigWheelBettingTerminal : StorageContainer // TypeDefIndex: 8534
{	// Fields
	public BigWheelGame bigWheel; // 0x3D0
	public Vector3 seatedPlayerOffset; // 0x3D8
	public float offsetCheckRadius; // 0x3E4
	public SoundDefinition winSound; // 0x3E8
	public SoundDefinition loseSound; // 0x3F0
	public float nextSpinTime; // 0x3F8

	// Methods

	// RVA: 0x52A270 Offset: 0x529670 VA: 0x18052A270 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x52A1C0 Offset: 0x5295C0 VA: 0x18052A1C0
	public void OnDrawGizmos() { }

	// RVA: 0x529FE0 Offset: 0x5293E0 VA: 0x180529FE0
	public bool IsPlayerValid(BasePlayer player) { }

	// RVA: 0x52AB20 Offset: 0x529F20 VA: 0x18052AB20 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x52AD20 Offset: 0x52A120 VA: 0x18052AD20
	private Vector3 SoundPosition() { }

	// RVA: 0x52AEF0 Offset: 0x52A2F0 VA: 0x18052AEF0
	public void WinSound() { }

	// RVA: 0x52A150 Offset: 0x529550 VA: 0x18052A150
	public void LoseSound() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x52AAC0 Offset: 0x529EC0 VA: 0x18052AAC0
	public void SetTimeUntilNextSpin(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x52AE30 Offset: 0x52A230 VA: 0x18052AE30
	public void WinOrLoseSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x52AF60 Offset: 0x52A360 VA: 0x18052AF60
	public void .ctor() { }

}

