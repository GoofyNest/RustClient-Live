public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier> // TypeDefIndex: 3827
{
	private BuiltinRenderTextureType m_Type; 
	private int m_NameID; 
	private int m_InstanceID; 
	private IntPtr m_BufferPointer; 
	private int m_MipLevel; 
	private CubemapFace m_CubeFace; 
	private int m_DepthSlice; 


	public void .ctor(BuiltinRenderTextureType type) { }

	public void .ctor(int nameID) { }

	public void .ctor(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	public void .ctor(Texture tex) { }

	public void .ctor(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public bool Equals(RenderTargetIdentifier rhs) { }

	public override bool Equals(object obj) { }

}

