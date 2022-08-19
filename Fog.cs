public sealed class Fog // TypeDefIndex: 11783
{	// Fields
	[TooltipAttribute] // RVA: 0x70680 Offset: 0x6FA80 VA: 0x180070680
	public bool enabled; // 0x10
	[TooltipAttribute] // RVA: 0x70820 Offset: 0x6FC20 VA: 0x180070820
	public bool excludeSkybox; // 0x11

	// Methods

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x1010740 Offset: 0x100FB40 VA: 0x181010740
	internal bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x1010870 Offset: 0x100FC70 VA: 0x181010870
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x1010C00 Offset: 0x1010000 VA: 0x181010C00
	public void .ctor() { }

}

