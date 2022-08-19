public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier> // TypeDefIndex: 3824
{	// Fields
	private BuiltinRenderTextureType m_Type; // 0x0
	private int m_NameID; // 0x4
	private int m_InstanceID; // 0x8
	private IntPtr m_BufferPointer; // 0x10
	private int m_MipLevel; // 0x18
	private CubemapFace m_CubeFace; // 0x1C
	private int m_DepthSlice; // 0x20

	// Methods

	// RVA: 0x222250 Offset: 0x221650 VA: 0x180222250
	public void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x222170 Offset: 0x221570 VA: 0x180222170
	public void .ctor(int nameID) { }

	// RVA: 0x222210 Offset: 0x221610 VA: 0x180222210
	public void .ctor(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x222200 Offset: 0x221600 VA: 0x180222200
	public void .ctor(Texture tex) { }

	// RVA: 0x2221D0 Offset: 0x2215D0 VA: 0x1802221D0
	public void .ctor(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x19AB570 Offset: 0x19AA970 VA: 0x1819AB570
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x19AB6D0 Offset: 0x19AAAD0 VA: 0x1819AB6D0
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x19AB670 Offset: 0x19AAA70 VA: 0x1819AB670
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x19AB610 Offset: 0x19AAA10 VA: 0x1819AB610
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0x222160 Offset: 0x221560 VA: 0x180222160 Slot: 3
	public override string ToString() { }

	// RVA: 0x222100 Offset: 0x221500 VA: 0x180222100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x222010 Offset: 0x221410 VA: 0x180222010 Slot: 4
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x222050 Offset: 0x221450 VA: 0x180222050 Slot: 0
	public override bool Equals(object obj) { }

}

