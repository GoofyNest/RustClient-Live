public struct InventoryItemId : IEquatable<InventoryItemId>, IComparable<InventoryItemId> // TypeDefIndex: 5538
{
	public ulong Value; 


	public static InventoryItemId op_Implicit(ulong value) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object p) { }

	public bool Equals(InventoryItemId p) { }

	public static bool op_Equality(InventoryItemId a, InventoryItemId b) { }

	public int CompareTo(InventoryItemId other) { }

}

