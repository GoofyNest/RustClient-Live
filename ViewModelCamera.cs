public class ViewModelCamera : MonoBehaviour // TypeDefIndex: 13238
{
	private readonly int _PreviousVP; 
	private readonly int _NonJitteredVP; 
	private readonly int _WorldSpaceCameraPos; 
	private readonly int _HasLastPositionData; 
	private readonly int _CurrentM; 
	private readonly int _PreviousM; 
	private readonly int _WorldSpaceLightPos0; 
	private readonly int _LightColor0; 
	private readonly int unity_SHAr; 
	private readonly int unity_SHAg; 
	private readonly int unity_SHAb; 
	private readonly int unity_SHBr; 
	private readonly int unity_SHBg; 
	private readonly int unity_SHBb; 
	private readonly int unity_SHC; 
	private readonly int ambient_SHAr; 
	private readonly int ambient_SHAg; 
	private readonly int ambient_SHAb; 
	private readonly int ambient_SHBr; 
	private readonly int ambient_SHBg; 
	private readonly int ambient_SHBb; 
	private readonly int ambient_SHC; 
	private readonly int global_MainLightingAtten; 
	private readonly int global_SkyReflection; 
	private readonly int global_SkyReflection_HDR; 
	public static ViewModelCamera Instance; 
	private ListHashSet<ViewModelDrawEvent> afterGBufferEvents; 
	private ListHashSet<ViewModelDrawEvent> afterForwardAlphaDrawEvents; 
	private Material utilsMaterial; 
	private int stencilPassID; 
	private int motionPassID; 
	private int blockDepthPassID; 
	private int clearDepthPassID; 
	private CommandBufferManager commandBufferManager; 
	private CommandBufferDesc onBeforeGBufferDesc; 
	private CommandBufferDesc onAfterGBufferDesc; 
	private CommandBufferDesc onBeforeImageEffectsOpaqueDesc; 
	private CommandBufferDesc onAfterForwardAlphaDesc; 
	private Matrix4x4 previousViewProjectionMatrix; 


	private void OnEnable() { }

	private void OnDisable() { }

	public void OnBeforeGBuffer(CommandBuffer cb) { }

	public void OnAfterGBuffer(CommandBuffer cb) { }

	private void OnBeforeImageEffectsOpaque(CommandBuffer cb) { }

	private void OnAfterForwardAlpha(CommandBuffer cb) { }

	private void SetCameraMatrices(CommandBuffer cb) { }

	private void UpdateAmbientProbe(CommandBuffer cb) { }

	private void UpdateSkyReflection(CommandBuffer cb) { }

	private void UpdateSHCoefficients(CommandBuffer cb) { }

	private void UpdateLightParameters(CommandBuffer cb) { }

	public void Clear() { }

	public void AddGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	public void AddForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	public void RemoveGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	public void RemoveForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	public void .ctor() { }

}

