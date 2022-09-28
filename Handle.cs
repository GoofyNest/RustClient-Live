public abstract class Handle : IEquatable<Handle>, IFormattable // TypeDefIndex: 8222
{
	[CompilerGeneratedAttribute] 
	private IntPtr <InnerHandle>k__BackingField; 

	public IntPtr InnerHandle { get; set; }


	[CompilerGeneratedAttribute] 
	public IntPtr get_InnerHandle() { }

	[CompilerGeneratedAttribute] 
	internal void set_InnerHandle(IntPtr value) { }

	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public static bool op_Equality(Handle left, Handle right) { }

	public static bool op_Inequality(Handle left, Handle right) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public bool Equals(Handle other) { }

	public override string ToString() { }

	public virtual string ToString(string format, IFormatProvider formatProvider) { }

}

