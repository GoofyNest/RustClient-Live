public class Locker : StorageContainer // TypeDefIndex: 8598
{	// Fields
	public GameObjectRef equipSound; // 0x3D0
	private const int maxGearSets = 3;
	private const int attireSize = 7;
	private const int beltSize = 6;
	private const int columnSize = 2;
	private Item[] clothingBuffer; // 0x3D8
	private const int setSize = 13;

	// Methods

	// RVA: 0x4FC150 Offset: 0x4FB550 VA: 0x1804FC150 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	public bool IsEquipping() { }

	// RVA: 0x4FC120 Offset: 0x4FB520 VA: 0x1804FC120
	private Locker.RowType GetRowType(int slot) { }

	// RVA: 0x4FBF90 Offset: 0x4FB390 VA: 0x1804FBF90 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x4FBF30 Offset: 0x4FB330 VA: 0x1804FBF30
	public void EquipFromIndex(int index) { }

	// RVA: 0x4FC240 Offset: 0x4FB640 VA: 0x1804FC240
	public void .ctor() { }

}

private enum Locker.RowType // TypeDefIndex: 8599
{	// Fields
	public int value__; // 0x0
	public const Locker.RowType Clothing = 0;
	public const Locker.RowType Belt = 1;

}

public static class Locker.LockerFlags // TypeDefIndex: 8600
{	// Fields
	public const BaseEntity.Flags IsEquipping = 128;

}

