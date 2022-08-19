public class MaterialConfig : ScriptableObject // TypeDefIndex: 11310
{	// Fields
	[HorizontalAttribute] // RVA: 0xA43E0 Offset: 0xA37E0 VA: 0x1800A43E0
	public MaterialConfig.ShaderParametersFloat[] Floats; // 0x18
	[HorizontalAttribute] // RVA: 0xA43E0 Offset: 0xA37E0 VA: 0x1800A43E0
	public MaterialConfig.ShaderParametersColor[] Colors; // 0x20
	[HorizontalAttribute] // RVA: 0xA43E0 Offset: 0xA37E0 VA: 0x1800A43E0
	public MaterialConfig.ShaderParametersTexture[] Textures; // 0x28
	public string[] ScaleUV; // 0x30
	private MaterialPropertyBlock properties; // 0x38

	// Methods

	// RVA: 0x9560B0 Offset: 0x9554B0 VA: 0x1809560B0
	public MaterialPropertyBlock GetMaterialPropertyBlock(Material mat, Vector3 pos, Vector3 scale) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class MaterialConfig.ShaderParameters<T> // TypeDefIndex: 11311
{	// Fields
	public string Name; // 0x0
	public T Arid; // 0x0
	public T Temperate; // 0x0
	public T Tundra; // 0x0
	public T Arctic; // 0x0
	private T[] climates; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public float FindBlendParameters(Vector3 pos, out T src, out T dst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F6020 Offset: 0x17F5420 VA: 0x1817F6020
	|-MaterialConfig.ShaderParameters<object>.FindBlendParameters
	|
	|-RVA: 0x17F5CA0 Offset: 0x17F50A0 VA: 0x1817F5CA0
	|-MaterialConfig.ShaderParameters<float>.FindBlendParameters
	|
	|-RVA: 0x17F56B0 Offset: 0x17F4AB0 VA: 0x1817F56B0
	|-MaterialConfig.ShaderParameters<Color>.FindBlendParameters
	*/

	// RVA: -1 Offset: -1
	public T FindBlendParameters(Vector3 pos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F5430 Offset: 0x17F4830 VA: 0x1817F5430
	|-MaterialConfig.ShaderParameters<object>.FindBlendParameters
	|-MaterialConfig.ShaderParameters<Texture>.FindBlendParameters
	|
	|-RVA: 0x17F63E0 Offset: 0x17F57E0 VA: 0x1817F63E0
	|-MaterialConfig.ShaderParameters<float>.FindBlendParameters
	|
	|-RVA: 0x17F5A30 Offset: 0x17F4E30 VA: 0x1817F5A30
	|-MaterialConfig.ShaderParameters<Color>.FindBlendParameters
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-MaterialConfig.ShaderParameters<object>..ctor
	|-MaterialConfig.ShaderParameters<float>..ctor
	|-MaterialConfig.ShaderParameters<Color>..ctor
	|-MaterialConfig.ShaderParameters<Texture>..ctor
	*/

}

public class MaterialConfig.ShaderParametersFloat : MaterialConfig.ShaderParameters<float> // TypeDefIndex: 11312
{	// Methods

	// RVA: 0x96BE20 Offset: 0x96B220 VA: 0x18096BE20
	public void .ctor() { }

}

public class MaterialConfig.ShaderParametersColor : MaterialConfig.ShaderParameters<Color> // TypeDefIndex: 11313
{	// Methods

	// RVA: 0x96BDE0 Offset: 0x96B1E0 VA: 0x18096BDE0
	public void .ctor() { }

}

public class MaterialConfig.ShaderParametersTexture : MaterialConfig.ShaderParameters<Texture> // TypeDefIndex: 11314
{	// Methods

	// RVA: 0x96BE60 Offset: 0x96B260 VA: 0x18096BE60
	public void .ctor() { }

}

