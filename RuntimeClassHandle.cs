internal struct RuntimeClassHandle // TypeDefIndex: 5
{
	private RuntimeStructs.MonoClass* value;

	internal RuntimeStructs.MonoClass* Value { get; }


	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	internal void .ctor(IntPtr ptr) { }

	internal RuntimeStructs.MonoClass* get_Value() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	internal RuntimeTypeHandle GetTypeHandle() { }

}

