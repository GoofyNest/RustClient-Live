public sealed class UnmanagedFunctionPointerAttribute : Attribute // TypeDefIndex: 1320
{
	private CallingConvention m_callingConvention;
	public CharSet CharSet;
	public bool BestFitMapping;
	public bool ThrowOnUnmappableChar;
	public bool SetLastError;


	public void .ctor(CallingConvention callingConvention) { }

}

