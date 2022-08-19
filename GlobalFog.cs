internal class GlobalFog : PostEffectsBase // TypeDefIndex: 8189
{	// Fields
	[TooltipAttribute] // RVA: 0x9A9C0 Offset: 0x99DC0 VA: 0x18009A9C0
	public bool distanceFog; // 0x28
	[TooltipAttribute] // RVA: 0x9AB20 Offset: 0x99F20 VA: 0x18009AB20
	public bool useRadialDistance; // 0x29
	[TooltipAttribute] // RVA: 0x9AC00 Offset: 0x9A000 VA: 0x18009AC00
	public bool heightFog; // 0x2A
	[TooltipAttribute] // RVA: 0x9AD00 Offset: 0x9A100 VA: 0x18009AD00
	public float height; // 0x2C
	[RangeAttribute] // RVA: 0x9ADB0 Offset: 0x9A1B0 VA: 0x18009ADB0
	public float heightDensity; // 0x30
	[TooltipAttribute] // RVA: 0x9AE20 Offset: 0x9A220 VA: 0x18009AE20
	public float startDistance; // 0x34
	public Shader fogShader; // 0x38
	private Material fogMaterial; // 0x40

	// Methods

	// RVA: 0x21DA960 Offset: 0x21D9D60 VA: 0x1821DA960 Slot: 4
	public override bool CheckResources() { }

	[ImageEffectOpaque] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21DAB10 Offset: 0x21D9F10 VA: 0x1821DAB10
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DA9C0 Offset: 0x21D9DC0 VA: 0x1821DA9C0
	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) { }

	// RVA: 0x21DB7E0 Offset: 0x21DABE0 VA: 0x1821DB7E0
	public void .ctor() { }

}

