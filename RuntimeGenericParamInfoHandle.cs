internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 7
{
	private RuntimeStructs.GenericParamInfo* value; 

internal Type[] Constraints { get; }
internal GenericParameterAttributes Attributes { get; }


internal void .ctor(IntPtr ptr) { }

internal Type[] get_Constraints() { }

internal GenericParameterAttributes get_Attributes() { }

private Type[] GetConstraints() { }

private int GetConstraintsCount() { }

}

