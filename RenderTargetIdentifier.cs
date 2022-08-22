public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier> // TypeDefIndex: 3824
{	private BuiltinRenderTextureType m_Type; // 0x0
	private int m_NameID; // 0x4
	private int m_InstanceID; // 0x8
	private IntPtr m_BufferPointer; // 0x10
	private int m_MipLevel; // 0x18
	private CubemapFace m_CubeFace; // 0x1C
	private int m_DepthSlice; // 0x20


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

