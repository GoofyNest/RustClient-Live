internal sealed class ObjectHolder // TypeDefIndex: 1038
{	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x128EC30 Offset: 0x128E030 VA: 0x18128EC30
	internal void .ctor(long objID) { }

	// RVA: 0x128E9E0 Offset: 0x128DDE0 VA: 0x18128E9E0
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x128E8C0 Offset: 0x128DCC0 VA: 0x18128E8C0
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x128E440 Offset: 0x128D840 VA: 0x18128E440
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x128E3E0 Offset: 0x128D7E0 VA: 0x18128E3E0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x128E460 Offset: 0x128D860 VA: 0x18128E460
	internal void RemoveDependency(long id) { }

	// RVA: 0x128E2F0 Offset: 0x128D6F0 VA: 0x18128E2F0
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x128E860 Offset: 0x128DC60 VA: 0x18128E860
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x128E170 Offset: 0x128D570 VA: 0x18128E170
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x128E690 Offset: 0x128DA90 VA: 0x18128E690
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x128E450 Offset: 0x128D850 VA: 0x18128E450
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x128E4F0 Offset: 0x128D8F0 VA: 0x18128E4F0
	internal void SetFlags() { }

	// RVA: 0xD80DD0 Offset: 0xD801D0 VA: 0x180D80DD0
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x128EE40 Offset: 0x128E240 VA: 0x18128EE40
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x128EDD0 Offset: 0x128E1D0 VA: 0x18128EDD0
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0xD80DC0 Offset: 0xD801C0 VA: 0x180D80DC0
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x128EE10 Offset: 0x128E210 VA: 0x18128EE10
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x128EE80 Offset: 0x128E280 VA: 0x18128EE80
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0xE65BF0 Offset: 0xE64FF0 VA: 0x180E65BF0
	internal bool get_HasISerializable() { }

	// RVA: 0x128EDC0 Offset: 0x128E1C0 VA: 0x18128EDC0
	internal bool get_HasSurrogate() { }

	// RVA: 0x128ED00 Offset: 0x128E100 VA: 0x18128ED00
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x128ECE0 Offset: 0x128E0E0 VA: 0x18128ECE0
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x128EE00 Offset: 0x128E200 VA: 0x18128EE00
	internal int get_TotalDependentObjects() { }

	// RVA: 0x82A660 Offset: 0x829A60 VA: 0x18082A660
	internal bool get_Reachable() { }

	// RVA: 0xE64690 Offset: 0xE63A90 VA: 0x180E64690
	internal void set_Reachable(bool value) { }

	// RVA: 0x11793F0 Offset: 0x11787F0 VA: 0x1811793F0
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal object get_ObjectValue() { }

	// RVA: 0x128E570 Offset: 0x128D970 VA: 0x18128E570
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal LongList get_DependentObjects() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x128EDE0 Offset: 0x128E1E0 VA: 0x18128EDE0
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x128EE60 Offset: 0x128E260 VA: 0x18128EE60
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x128ED90 Offset: 0x128E190 VA: 0x18128ED90
	internal bool get_CompletelyFixed() { }

	// RVA: 0x128EDB0 Offset: 0x128E1B0 VA: 0x18128EDB0
	internal long get_ContainerID() { }

}

