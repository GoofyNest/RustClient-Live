public class BigWheelBettingTerminal : StorageContainer // TypeDefIndex: 8534
{	public BigWheelGame bigWheel; // 0x3D0
	public Vector3 seatedPlayerOffset; // 0x3D8
	public float offsetCheckRadius; // 0x3E4
	public SoundDefinition winSound; // 0x3E8
	public SoundDefinition loseSound; // 0x3F0
	public float nextSpinTime; // 0x3F8


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void OnDrawGizmos() { }

	public bool IsPlayerValid(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	private Vector3 SoundPosition() { }

	public void WinSound() { }

	public void LoseSound() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void SetTimeUntilNextSpin(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void WinOrLoseSound(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

