public class CollectibleEntity : BaseEntity, IPrefabPreProcess // TypeDefIndex: 8550
{	// Fields
	public Translate.Phrase itemName; // 0x168
	public ItemAmount[] itemList; // 0x170
	public GameObjectRef pickupEffect; // 0x178
	public float xpScale; // 0x180

	// Methods

	// RVA: 0x595E00 Offset: 0x595200 VA: 0x180595E00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x595CA0 Offset: 0x5950A0 VA: 0x180595CA0 Slot: 66
	public override List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x595EF0 Offset: 0x5952F0 VA: 0x180595EF0 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x596060 Offset: 0x595460 VA: 0x180596060
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596020 Offset: 0x595420 VA: 0x180596020
	private void <GetMenuItems>b__6_0(BasePlayer ply) { }

}

