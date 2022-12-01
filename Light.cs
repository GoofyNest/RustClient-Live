public sealed class Light : Behaviour // TypeDefIndex: 3409
{
	private int m_BakedIndex;

	[NativePropertyAttribute]
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


	public LightType get_type() { }

	public void set_type(LightType value) { }

	public float get_spotAngle() { }

	public Color get_color() { }

	public void set_color(Color value) { }

	public float get_intensity() { }

	public void set_intensity(float value) { }

	public float get_bounceIntensity() { }

	public void set_shadowBias(float value) { }

	public void set_shadowNormalBias(float value) { }

	public float get_range() { }

	public void set_range(float value) { }

	public void set_cullingMask(int value) { }

	[NativeMethodAttribute]
	public LightShadows get_shadows() { }

	[FreeFunctionAttribute]
	public void set_shadows(LightShadows value) { }

	[FreeFunctionAttribute]
	public void set_shadowStrength(float value) { }

	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute]
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	public void RemoveCommandBuffers(LightEvent evt) { }

	[FreeFunctionAttribute]
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	private void get_color_Injected(out Color ret) { }

	private void set_color_Injected(ref Color value) { }

}

