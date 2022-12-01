internal struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket> // TypeDefIndex: 5529
{
	public uint Value;


	public static HAuthTicket op_Implicit(uint value) { }

	public static uint op_Implicit(HAuthTicket value) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object p) { }

	public bool Equals(HAuthTicket p) { }

	public int CompareTo(HAuthTicket other) { }

}

