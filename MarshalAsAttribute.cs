public sealed class MarshalAsAttribute : Attribute // TypeDefIndex: 1356
{
	public string MarshalCookie; 
	[ComVisibleAttribute] 
	public string MarshalType; 
	[ComVisibleAttribute] 
	public Type MarshalTypeRef; 
	public Type SafeArrayUserDefinedSubType; 
	private UnmanagedType utype; 
	public UnmanagedType ArraySubType; 
	public VarEnum SafeArraySubType; 
	public int SizeConst; 
	public int IidParameterIndex; 
	public short SizeParamIndex; 


	internal MarshalAsAttribute Copy() { }

}

