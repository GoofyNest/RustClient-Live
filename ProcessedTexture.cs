public class ProcessedTexture // TypeDefIndex: 11360
{	// Fields
	protected RenderTexture result; // 0x10
	protected Material material; // 0x18

	// Methods

	// RVA: 0x6912E0 Offset: 0x6906E0 VA: 0x1806912E0
	public void Dispose() { }

	// RVA: 0x690FC0 Offset: 0x6903C0 VA: 0x180690FC0
	protected RenderTexture CreateRenderTexture(string name, int width, int height, bool linear) { }

	// RVA: 0x691230 Offset: 0x690630 VA: 0x180691230
	protected void DestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0x6910A0 Offset: 0x6904A0 VA: 0x1806910A0
	protected RenderTexture CreateTemporary() { }

	// RVA: 0x691420 Offset: 0x690820 VA: 0x180691420
	protected void ReleaseTemporary(RenderTexture rt) { }

	// RVA: 0x690ED0 Offset: 0x6902D0 VA: 0x180690ED0
	protected Material CreateMaterial(string shader) { }

	// RVA: 0x690F50 Offset: 0x690350 VA: 0x180690F50
	protected Material CreateMaterial(Shader shader) { }

	// RVA: 0x691180 Offset: 0x690580 VA: 0x180691180
	protected void DestroyMaterial(ref Material mat) { }

	// RVA: 0x691430 Offset: 0x690830 VA: 0x180691430
	public static Texture op_Implicit(ProcessedTexture t) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

