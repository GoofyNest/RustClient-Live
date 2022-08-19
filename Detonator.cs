public class Detonator : HeldEntity, IRFObject // TypeDefIndex: 8565
{	// Fields
	public int frequency; // 0x1F8
	private float timeSinceDeploy; // 0x1FC
	public GameObjectRef frequencyPanelPrefab; // 0x200
	public GameObjectRef attackEffect; // 0x208
	public GameObjectRef unAttackEffect; // 0x210
	private float deployDelay; // 0x218
	private bool wasAttacking; // 0x21C
	private float configProgress; // 0x220
	private float attackHeldTime; // 0x224
	private float attackReleasedTime; // 0x228

	// Methods

	// RVA: 0x9BBEA0 Offset: 0x9BB2A0 VA: 0x1809BBEA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9BB9E0 Offset: 0x9BADE0 VA: 0x1809BB9E0 Slot: 159
	public virtual bool IsFullyDeployed() { }

	// RVA: 0x9BC140 Offset: 0x9BB540 VA: 0x1809BC140
	protected void ProcessInputTime() { }

	// RVA: 0x9BBA60 Offset: 0x9BAE60 VA: 0x1809BBA60 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x9BBA80 Offset: 0x9BAE80 VA: 0x1809BBA80 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x9BC060 Offset: 0x9BB460 VA: 0x1809BC060
	private void OpenConfigPanel() { }

	// RVA: 0x9BBAE0 Offset: 0x9BAEE0 VA: 0x1809BBAE0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void BeginSounds() { }

	// RVA: 0x9BBF90 Offset: 0x9BB390 VA: 0x1809BBF90 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x9BBA00 Offset: 0x9BAE00 VA: 0x1809BBA00 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9BB9D0 Offset: 0x9BADD0 VA: 0x1809BB9D0 Slot: 158
	public int GetFrequency() { }

	// RVA: 0x9BB980 Offset: 0x9BAD80 VA: 0x1809BB980 Slot: 157
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x9BC180 Offset: 0x9BB580 VA: 0x1809BC180
	public void .ctor() { }

}

