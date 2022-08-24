internal class KeySequence // TypeDefIndex: 2151
{
	private TypedObject[] ks; 
	private int dim; 
	private int hashcode; 
	private int posline; 
	private int poscol; 

	public int PosLine { get; }
	public int PosCol { get; }
	public object Item { get; set; }


	internal void .ctor(int dim, int line, int col) { }

	public int get_PosLine() { }

	public int get_PosCol() { }

	public object get_Item(int index) { }

	public void set_Item(int index, object value) { }

	internal bool IsQualified() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public override string ToString() { }

}

