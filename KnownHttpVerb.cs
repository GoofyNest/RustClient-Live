internal class KnownHttpVerb // TypeDefIndex: 2892
{	// Fields
	internal string Name; // 0x10
	internal bool RequireContentBody; // 0x18
	internal bool ContentBodyNotAllowed; // 0x19
	internal bool ConnectRequest; // 0x1A
	internal bool ExpectNoContentResponse; // 0x1B
	private static ListDictionary NamedHeaders; // 0x0
	internal static KnownHttpVerb Get; // 0x8
	internal static KnownHttpVerb Connect; // 0x10
	internal static KnownHttpVerb Head; // 0x18
	internal static KnownHttpVerb Put; // 0x20
	internal static KnownHttpVerb Post; // 0x28
	internal static KnownHttpVerb MkCol; // 0x30

	// Methods

	// RVA: 0x133FEE0 Offset: 0x133F2E0 VA: 0x18133FEE0
	internal void .ctor(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse) { }

	// RVA: 0x133FB20 Offset: 0x133EF20 VA: 0x18133FB20
	private static void .cctor() { }

	// RVA: 0x133FA30 Offset: 0x133EE30 VA: 0x18133FA30
	public static KnownHttpVerb Parse(string name) { }

}

