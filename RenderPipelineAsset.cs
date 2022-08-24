public abstract class RenderPipelineAsset : ScriptableObject // TypeDefIndex: 3850
{
	public virtual string[] renderingLayerMaskNames { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Shader autodeskInteractiveShader { get; }
	public virtual Shader autodeskInteractiveTransparentShader { get; }
	public virtual Shader autodeskInteractiveMaskedShader { get; }
	public virtual Shader terrainDetailLitShader { get; }
	public virtual Shader terrainDetailGrassShader { get; }
	public virtual Shader terrainDetailGrassBillboardShader { get; }
	public virtual Material defaultParticleMaterial { get; }
	public virtual Material defaultLineMaterial { get; }
	public virtual Material defaultTerrainMaterial { get; }
	public virtual Material defaultUIMaterial { get; }
	public virtual Material defaultUIOverdrawMaterial { get; }
	public virtual Material defaultUIETC1SupportedMaterial { get; }
	public virtual Material default2DMaterial { get; }
	public virtual Shader defaultShader { get; }
	public virtual Shader defaultSpeedTree7Shader { get; }
	public virtual Shader defaultSpeedTree8Shader { get; }


	internal RenderPipeline InternalCreatePipeline() { }

	public virtual string[] get_renderingLayerMaskNames() { }

	public virtual Material get_defaultMaterial() { }

	public virtual Shader get_autodeskInteractiveShader() { }

	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	public virtual Shader get_terrainDetailLitShader() { }

	public virtual Shader get_terrainDetailGrassShader() { }

	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	public virtual Material get_defaultParticleMaterial() { }

	public virtual Material get_defaultLineMaterial() { }

	public virtual Material get_defaultTerrainMaterial() { }

	public virtual Material get_defaultUIMaterial() { }

	public virtual Material get_defaultUIOverdrawMaterial() { }

	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	public virtual Material get_default2DMaterial() { }

	public virtual Shader get_defaultShader() { }

	public virtual Shader get_defaultSpeedTree7Shader() { }

	public virtual Shader get_defaultSpeedTree8Shader() { }

	protected abstract RenderPipeline CreatePipeline();

	protected virtual void OnValidate() { }

	protected virtual void OnDisable() { }

	protected void .ctor() { }

}

