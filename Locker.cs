public class Locker : StorageContainer // TypeDefIndex: 8598
{
	public GameObjectRef equipSound; 
private const int maxGearSets = 3;
private const int attireSize = 7;
private const int beltSize = 6;
private const int columnSize = 2;
	private Item[] clothingBuffer; 
private const int setSize = 13;


public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

public bool IsEquipping() { }

private Locker.RowType GetRowType(int slot) { }

public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

public void EquipFromIndex(int index) { }

public void .ctor() { }

}

private enum Locker.RowType // TypeDefIndex: 8599
{
	public int value__; 
public const Locker.RowType Clothing = 0;
public const Locker.RowType Belt = 1;

}

public static class Locker.LockerFlags // TypeDefIndex: 8600
{
public const BaseEntity.Flags IsEquipping = 128;

}

