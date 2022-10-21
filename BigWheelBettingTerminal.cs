public class BigWheelBettingTerminal : StorageContainer // TypeDefIndex: 10243
{
	public BigWheelGame bigWheel; 
	public Vector3 seatedPlayerOffset; 
	public float offsetCheckRadius; 
	public SoundDefinition winSound; 
	public SoundDefinition loseSound; 
	public float nextSpinTime; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void OnDrawGizmos() { }

	public bool IsPlayerValid(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	private Vector3 SoundPosition() { }

	public void WinSound() { }

	public void LoseSound() { }

	[BaseEntity.RPC_Client] 
	public void SetTimeUntilNextSpin(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void WinOrLoseSound(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

