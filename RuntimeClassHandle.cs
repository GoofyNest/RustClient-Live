internal struct RuntimeClassHandle // TypeDefIndex: 5
{	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x1F66B0 Offset: 0x1F5AB0 VA: 0x1801F66B0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x1F6570 Offset: 0x1F5970 VA: 0x1801F6570 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F6670 Offset: 0x1F5A70 VA: 0x1801F6670 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1644D50 Offset: 0x1644150 VA: 0x181644D50
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x1F66A0 Offset: 0x1F5AA0 VA: 0x1801F66A0
	internal RuntimeTypeHandle GetTypeHandle() { }

}

