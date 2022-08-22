internal class GlobalFog : PostEffectsBase // TypeDefIndex: 8189
{	[TooltipAttribute] // RVA: 0x9A9C0 Offset: 0x99DC0 VA: 0x18009A9C0
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


	public override bool CheckResources() { }

	[ImageEffectOpaque] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) { }

	public void .ctor() { }

}

