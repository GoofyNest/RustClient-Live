internal class Group : AstNode // TypeDefIndex: 1794
{	private AstNode groupNode; // 0x10

	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }


	public void .ctor(AstNode groupNode) { }

	public override AstNode.AstType get_Type() { }

	public override XPathResultType get_ReturnType() { }

}

public class Group : Capture // TypeDefIndex: 2616
{	internal static Group _emptygroup; // 0x0
	internal int[] _caps; // 0x20
	internal int _capcount; // 0x28
	internal CaptureCollection _capcoll; // 0x30
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	internal string _name; // 0x38

	public bool Success { get; }
	public CaptureCollection Captures { get; }


	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	public bool get_Success() { }

	public CaptureCollection get_Captures() { }

	private static void .cctor() { }

	internal void .ctor() { }

}

public class Group : IDisposable // TypeDefIndex: 6708
{	protected Manager manager; // 0x10
	public uint ID; // 0x18
	public Bounds bounds; // 0x1C
	public ListHashSet<Networkable> networkables; // 0x38
	public List<Connection> subscribers; // 0x40

	public bool isGlobal { get; }


	public bool get_isGlobal() { }

	public void .ctor(Manager m, uint id) { }

	public virtual void Dispose() { }

	public void Join(Networkable nw) { }

	public void Leave(Networkable nw) { }

	public void AddSubscriber(Connection cn) { }

	public void RemoveSubscriber(Connection cn) { }

	public bool HasSubscribers() { }

	public override string ToString() { }

}

