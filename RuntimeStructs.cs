internal struct RuntimeStructs.RemoteClass // TypeDefIndex: 13
{

internal struct RuntimeStructs.RemoteClass
	internal IntPtr default_vtable; 
	internal IntPtr xdomain_vtable; 
	internal RuntimeStructs.MonoClass* proxy_class; 
	internal IntPtr proxy_class_name; 
	internal uint interface_count; 

}

internal struct RuntimeStructs.GenericParamInfo // TypeDefIndex: 15
{

internal struct RuntimeStructs.GenericParamInfo
	internal RuntimeStructs.MonoClass* pklass; 
	internal IntPtr name; 
	internal ushort flags; 
	internal uint token; 
	internal RuntimeStructs.MonoClass** constraints; 

}

internal struct RuntimeStructs.GPtrArray // TypeDefIndex: 16
{
	internal IntPtr* data; 
	internal int len; 

}

private struct RuntimeStructs.HandleStackMark // TypeDefIndex: 17
{
	private int size; 
	private int interior_size; 
	private IntPtr chunk; 

}

private struct RuntimeStructs.MonoError // TypeDefIndex: 18
{
	private ushort error_code; 
	private ushort hidden_0; 
	private IntPtr hidden_1; 
	private IntPtr hidden_2; 
	private IntPtr hidden_3; 
	private IntPtr hidden_4; 
	private IntPtr hidden_5; 
	private IntPtr hidden_6; 
	private IntPtr hidden_7; 
	private IntPtr hidden_8; 
	private IntPtr hidden_11; 
	private IntPtr hidden_12; 
	private IntPtr hidden_13; 
	private IntPtr hidden_14; 
	private IntPtr hidden_15; 
	private IntPtr hidden_16; 
	private IntPtr hidden_17; 
	private IntPtr hidden_18; 

}

