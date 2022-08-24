public class MaterialConfig : ScriptableObject // TypeDefIndex: 11310
{
	[HorizontalAttribute] 
	public MaterialConfig.ShaderParametersFloat[] Floats; 
	[HorizontalAttribute] 
	public MaterialConfig.ShaderParametersColor[] Colors; 
	[HorizontalAttribute] 
	public MaterialConfig.ShaderParametersTexture[] Textures; 
	public string[] ScaleUV; 
	private MaterialPropertyBlock properties; 


public MaterialPropertyBlock GetMaterialPropertyBlock(Material mat, Vector3 pos, Vector3 scale) { }

public void .ctor() { }

}

public class MaterialConfig.ShaderParameters<T> // TypeDefIndex: 11311
{
	public string Name; 
	public T Arid; 
	public T Temperate; 
	public T Tundra; 
	public T Arctic; 
	private T[] climates; 


public float FindBlendParameters(Vector3 pos, out T src, out T dst) { }
/* GenericInstMethod :
|
|-MaterialConfig.ShaderParameters<object>.FindBlendParameters
|
|-MaterialConfig.ShaderParameters<float>.FindBlendParameters
|
|-MaterialConfig.ShaderParameters<Color>.FindBlendParameters
*/

public T FindBlendParameters(Vector3 pos) { }
/* GenericInstMethod :
|
|-MaterialConfig.ShaderParameters<object>.FindBlendParameters
|-MaterialConfig.ShaderParameters<Texture>.FindBlendParameters
|
|-MaterialConfig.ShaderParameters<float>.FindBlendParameters
|
|-MaterialConfig.ShaderParameters<Color>.FindBlendParameters
*/

public void .ctor() { }
/* GenericInstMethod :
|
|-MaterialConfig.ShaderParameters<object>..ctor
|-MaterialConfig.ShaderParameters<float>..ctor
|-MaterialConfig.ShaderParameters<Color>..ctor
|-MaterialConfig.ShaderParameters<Texture>..ctor
*/

}

public class MaterialConfig.ShaderParametersFloat : MaterialConfig.ShaderParameters<float> // TypeDefIndex: 11312
{

public void .ctor() { }

}

public class MaterialConfig.ShaderParametersColor : MaterialConfig.ShaderParameters<Color> // TypeDefIndex: 11313
{

public void .ctor() { }

}

public class MaterialConfig.ShaderParametersTexture : MaterialConfig.ShaderParameters<Texture> // TypeDefIndex: 11314
{

public void .ctor() { }

}

