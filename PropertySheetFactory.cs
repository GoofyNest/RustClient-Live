public sealed class PropertySheetFactory // TypeDefIndex: 11890
{
	private readonly Dictionary<Shader, PropertySheet> m_Sheets; 


	public void .ctor() { }

	[ObsoleteAttribute] 
	public PropertySheet Get(string shaderName) { }

	public PropertySheet Get(Shader shader) { }

	public void Release() { }

}

