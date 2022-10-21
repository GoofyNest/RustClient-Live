internal struct FlexChildEnumerator : IEnumerator<IFlexNode>, IEnumerator, IDisposable // TypeDefIndex: 6814
{
	private readonly Transform _parent; 
	private readonly int _childCount; 
	private readonly bool _reversed; 
	private int _index; 
	[CompilerGeneratedAttribute] 
	private IFlexNode <Current>k__BackingField; 

	public IFlexNode Current { get; set; }
	private object System.Collections.IEnumerator.Current { get; }


	[CompilerGeneratedAttribute] 
	public IFlexNode get_Current() { }

	[CompilerGeneratedAttribute] 
	private void set_Current(IFlexNode value) { }

	public void .ctor(FlexElement parent, bool reversed) { }

	public bool MoveNext() { }

	private object System.Collections.IEnumerator.get_Current() { }

	public void Reset() { }

	public void Dispose() { }

}

