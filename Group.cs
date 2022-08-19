internal class Group : AstNode // TypeDefIndex: 1794
{	// Fields
	private AstNode groupNode; // 0x10

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(AstNode groupNode) { }

	// RVA: 0x70CC90 Offset: 0x70C090 VA: 0x18070CC90 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xABD0E0 Offset: 0xABC4E0 VA: 0x180ABD0E0 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

public class Group : Capture // TypeDefIndex: 2616
{	// Fields
	internal static Group _emptygroup; // 0x0
	internal int[] _caps; // 0x20
	internal int _capcount; // 0x28
	internal CaptureCollection _capcoll; // 0x30
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	internal string _name; // 0x38

	// Properties
	public bool Success { get; }
	public CaptureCollection Captures { get; }

	// Methods

	// RVA: 0x14C2A00 Offset: 0x14C1E00 VA: 0x1814C2A00
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x14C2BA0 Offset: 0x14C1FA0 VA: 0x1814C2BA0
	public bool get_Success() { }

	// RVA: 0x14C2AF0 Offset: 0x14C1EF0 VA: 0x1814C2AF0
	public CaptureCollection get_Captures() { }

	// RVA: 0x14C28E0 Offset: 0x14C1CE0 VA: 0x1814C28E0
	private static void .cctor() { }

	// RVA: 0x14C29D0 Offset: 0x14C1DD0 VA: 0x1814C29D0
	internal void .ctor() { }

}

public class Group : IDisposable // TypeDefIndex: 6708
{	// Fields
	protected Manager manager; // 0x10
	public uint ID; // 0x18
	public Bounds bounds; // 0x1C
	public ListHashSet<Networkable> networkables; // 0x38
	public List<Connection> subscribers; // 0x40

	// Properties
	public bool isGlobal { get; }

	// Methods

	// RVA: 0x14CD760 Offset: 0x14CCB60 VA: 0x1814CD760
	public bool get_isGlobal() { }

	// RVA: 0x2209EB0 Offset: 0x22092B0 VA: 0x182209EB0
	public void .ctor(Manager m, uint id) { }

	// RVA: 0x2209C10 Offset: 0x2209010 VA: 0x182209C10 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x2209CA0 Offset: 0x22090A0 VA: 0x182209CA0
	public void Join(Networkable nw) { }

	// RVA: 0x2209D50 Offset: 0x2209150 VA: 0x182209D50
	public void Leave(Networkable nw) { }

	// RVA: 0x2209BB0 Offset: 0x2208FB0 VA: 0x182209BB0
	public void AddSubscriber(Connection cn) { }

	// RVA: 0x2209E00 Offset: 0x2209200 VA: 0x182209E00
	public void RemoveSubscriber(Connection cn) { }

	// RVA: 0x2209C60 Offset: 0x2209060 VA: 0x182209C60
	public bool HasSubscribers() { }

	// RVA: 0x2209E50 Offset: 0x2209250 VA: 0x182209E50 Slot: 3
	public override string ToString() { }

}

