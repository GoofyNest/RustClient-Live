public class ViewModelCamera : MonoBehaviour // TypeDefIndex: 11446
{	// Fields
	private readonly int _PreviousVP; // 0x18
	private readonly int _NonJitteredVP; // 0x1C
	private readonly int _WorldSpaceCameraPos; // 0x20
	private readonly int _HasLastPositionData; // 0x24
	private readonly int _CurrentM; // 0x28
	private readonly int _PreviousM; // 0x2C
	private readonly int _WorldSpaceLightPos0; // 0x30
	private readonly int _LightColor0; // 0x34
	private readonly int unity_SHAr; // 0x38
	private readonly int unity_SHAg; // 0x3C
	private readonly int unity_SHAb; // 0x40
	private readonly int unity_SHBr; // 0x44
	private readonly int unity_SHBg; // 0x48
	private readonly int unity_SHBb; // 0x4C
	private readonly int unity_SHC; // 0x50
	private readonly int ambient_SHAr; // 0x54
	private readonly int ambient_SHAg; // 0x58
	private readonly int ambient_SHAb; // 0x5C
	private readonly int ambient_SHBr; // 0x60
	private readonly int ambient_SHBg; // 0x64
	private readonly int ambient_SHBb; // 0x68
	private readonly int ambient_SHC; // 0x6C
	private readonly int global_MainLightingAtten; // 0x70
	private readonly int global_SkyReflection; // 0x74
	private readonly int global_SkyReflection_HDR; // 0x78
	public static ViewModelCamera Instance; // 0x0
	private ListHashSet<ViewModelDrawEvent> afterGBufferEvents; // 0x80
	private ListHashSet<ViewModelDrawEvent> afterForwardAlphaDrawEvents; // 0x88
	private Material utilsMaterial; // 0x90
	private int stencilPassID; // 0x98
	private int motionPassID; // 0x9C
	private int blockDepthPassID; // 0xA0
	private int clearDepthPassID; // 0xA4
	private CommandBufferManager commandBufferManager; // 0xA8
	private CommandBufferDesc onBeforeGBufferDesc; // 0xB0
	private CommandBufferDesc onAfterGBufferDesc; // 0xB8
	private CommandBufferDesc onBeforeImageEffectsOpaqueDesc; // 0xC0
	private CommandBufferDesc onAfterForwardAlphaDesc; // 0xC8
	private Matrix4x4 previousViewProjectionMatrix; // 0xD0

	// Methods

	// RVA: 0x7D1BB0 Offset: 0x7D0FB0 VA: 0x1807D1BB0
	private void OnEnable() { }

	// RVA: 0x7D1A60 Offset: 0x7D0E60 VA: 0x1807D1A60
	private void OnDisable() { }

	// RVA: 0x7D0B20 Offset: 0x7CFF20 VA: 0x1807D0B20
	public void OnBeforeGBuffer(CommandBuffer cb) { }

	// RVA: 0x7D0500 Offset: 0x7CF900 VA: 0x1807D0500
	public void OnAfterGBuffer(CommandBuffer cb) { }

	// RVA: 0x7D0E40 Offset: 0x7D0240 VA: 0x1807D0E40
	private void OnBeforeImageEffectsOpaque(CommandBuffer cb) { }

	// RVA: 0x7D0200 Offset: 0x7CF600 VA: 0x1807D0200
	private void OnAfterForwardAlpha(CommandBuffer cb) { }

	// RVA: 0x7D2000 Offset: 0x7D1400 VA: 0x1807D2000
	private void SetCameraMatrices(CommandBuffer cb) { }

	// RVA: 0x7D22B0 Offset: 0x7D16B0 VA: 0x1807D22B0
	private void UpdateAmbientProbe(CommandBuffer cb) { }

	// RVA: 0x7D31F0 Offset: 0x7D25F0 VA: 0x1807D31F0
	private void UpdateSkyReflection(CommandBuffer cb) { }

	// RVA: 0x7D2B50 Offset: 0x7D1F50 VA: 0x1807D2B50
	private void UpdateSHCoefficients(CommandBuffer cb) { }

	// RVA: 0x7D2950 Offset: 0x7D1D50 VA: 0x1807D2950
	private void UpdateLightParameters(CommandBuffer cb) { }

	// RVA: 0x7D01A0 Offset: 0x7CF5A0 VA: 0x1807D01A0
	public void Clear() { }

	// RVA: 0x7D00E0 Offset: 0x7CF4E0 VA: 0x1807D00E0
	public void AddGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7D0020 Offset: 0x7CF420 VA: 0x1807D0020
	public void AddForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7D1F80 Offset: 0x7D1380 VA: 0x1807D1F80
	public void RemoveGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7D1F00 Offset: 0x7D1300 VA: 0x1807D1F00
	public void RemoveForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7D3740 Offset: 0x7D2B40 VA: 0x1807D3740
	public void .ctor() { }

}

