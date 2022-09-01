internal class Group : AstNode // TypeDefIndex: 1794
{
	private AstNode groupNode; 

	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }


	public void .ctor(AstNode groupNode) { }

	public override AstNode.AstType get_Type() { }

	public override XPathResultType get_ReturnType() { }

}

public class Group : Capture // TypeDefIndex: 2616
{
	internal static Group _emptygroup; 
	internal int[] _caps; 
	internal int _capcount; 
	internal CaptureCollection _capcoll; 
	[OptionalFieldAttribute] 
	internal string _name; 

	public bool Success { get; }
	public CaptureCollection Captures { get; }


	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	public bool get_Success() { }

	public CaptureCollection get_Captures() { }

	private static void .cctor() { }

	internal void .ctor() { }

}

public class Group : IDisposable // TypeDefIndex: 6709
{
	protected Manager manager; 
	public uint ID; 
	public Bounds bounds; 
	public ListHashSet<Networkable> networkables; 
	public List<Connection> subscribers; 

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

