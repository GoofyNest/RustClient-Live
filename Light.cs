public sealed class Light : Behaviour // TypeDefIndex: 3408
{	// Fields
	private int m_BakedIndex; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0x95470 Offset: 0x94870 VA: 0x180095470
	public LightType type { get; set; }
	public float spotAngle { get; }
	public Color color { get; set; }
	public float intensity { get; set; }
	public float bounceIntensity { get; }
	public float shadowBias { set; }
	public float shadowNormalBias { set; }
	public float range { get; set; }
	public int cullingMask { set; }
	public LightShadows shadows { get; set; }
	public float shadowStrength { set; }

	// Methods

	// RVA: 0x18E51C0 Offset: 0x18E45C0 VA: 0x1818E51C0
	public LightType get_type() { }

	// RVA: 0x18E54B0 Offset: 0x18E48B0 VA: 0x1818E54B0
	public void set_type(LightType value) { }

	// RVA: 0x18E5180 Offset: 0x18E4580 VA: 0x1818E5180
	public float get_spotAngle() { }

	// RVA: 0x18E5070 Offset: 0x18E4470 VA: 0x1818E5070
	public Color get_color() { }

	// RVA: 0x18E5250 Offset: 0x18E4650 VA: 0x1818E5250
	public void set_color(Color value) { }

	// RVA: 0x18E50C0 Offset: 0x18E44C0 VA: 0x1818E50C0
	public float get_intensity() { }

	// RVA: 0x18E52E0 Offset: 0x18E46E0 VA: 0x1818E52E0
	public void set_intensity(float value) { }

	// RVA: 0x18E4FE0 Offset: 0x18E43E0 VA: 0x1818E4FE0
	public float get_bounceIntensity() { }

	// RVA: 0x18E5380 Offset: 0x18E4780 VA: 0x1818E5380
	public void set_shadowBias(float value) { }

	// RVA: 0x18E53D0 Offset: 0x18E47D0 VA: 0x1818E53D0
	public void set_shadowNormalBias(float value) { }

	// RVA: 0x18E5100 Offset: 0x18E4500 VA: 0x1818E5100
	public float get_range() { }

	// RVA: 0x18E5330 Offset: 0x18E4730 VA: 0x1818E5330
	public void set_range(float value) { }

	// RVA: 0x18E52A0 Offset: 0x18E46A0 VA: 0x1818E52A0
	public void set_cullingMask(int value) { }

	[NativeMethodAttribute] // RVA: 0x951A0 Offset: 0x945A0 VA: 0x1800951A0
	// RVA: 0x18E5140 Offset: 0x18E4540 VA: 0x1818E5140
	public LightShadows get_shadows() { }

	[FreeFunctionAttribute] // RVA: 0x95260 Offset: 0x94660 VA: 0x180095260
	// RVA: 0x18E5470 Offset: 0x18E4870 VA: 0x1818E5470
	public void set_shadows(LightShadows value) { }

	[FreeFunctionAttribute] // RVA: 0x95310 Offset: 0x94710 VA: 0x180095310
	// RVA: 0x18E5420 Offset: 0x18E4820 VA: 0x1818E5420
	public void set_shadowStrength(float value) { }

	// RVA: 0x18E4E50 Offset: 0x18E4250 VA: 0x1818E4E50
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x95390 Offset: 0x94790 VA: 0x180095390
	// RVA: 0x18E4EB0 Offset: 0x18E42B0 VA: 0x1818E4EB0
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	// RVA: 0x18E4F50 Offset: 0x18E4350 VA: 0x1818E4F50
	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	// RVA: 0x18E4FA0 Offset: 0x18E43A0 VA: 0x1818E4FA0
	public void RemoveCommandBuffers(LightEvent evt) { }

	[FreeFunctionAttribute] // RVA: 0x95430 Offset: 0x94830 VA: 0x180095430
	// RVA: 0x18E4F10 Offset: 0x18E4310 VA: 0x1818E4F10
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	// RVA: 0x18E5020 Offset: 0x18E4420 VA: 0x1818E5020
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x18E5200 Offset: 0x18E4600 VA: 0x1818E5200
	private void set_color_Injected(ref Color value) { }

}

