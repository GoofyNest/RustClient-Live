internal sealed class ObjectHolder // TypeDefIndex: 1038
{
	private object m_object;
	internal long m_id;
	private int m_missingElementsRemaining;
	private int m_missingDecendents;
	internal SerializationInfo m_serInfo;
	internal ISerializationSurrogate m_surrogate;
	internal FixupHolderList m_missingElements;
	internal LongList m_dependentObjects;
	internal ObjectHolder m_next;
	internal int m_flags;
	private bool m_markForFixupWhenAvailable;
	private ValueTypeFixupInfo m_valueFixup;
	private TypeLoadExceptionHolder m_typeLoad;
	private bool m_reachable;

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


	internal void .ctor(long objID) { }

	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	private void IncrementDescendentFixups(int amount) { }

	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	internal void RemoveDependency(long id) { }

	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	internal void AddDependency(long dependentObject) { }

	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	internal void MarkForCompletionWhenAvailable() { }

	internal void SetFlags() { }

	internal bool get_IsIncompleteObjectReference() { }

	internal void set_IsIncompleteObjectReference(bool value) { }

	internal bool get_RequiresDelayedFixup() { }

	internal bool get_RequiresValueTypeFixup() { }

	internal bool get_ValueTypeFixupPerformed() { }

	internal void set_ValueTypeFixupPerformed(bool value) { }

	internal bool get_HasISerializable() { }

	internal bool get_HasSurrogate() { }

	internal bool get_CanSurrogatedObjectValueChange() { }

	internal bool get_CanObjectValueChange() { }

	internal int get_DirectlyDependentObjects() { }

	internal int get_TotalDependentObjects() { }

	internal bool get_Reachable() { }

	internal void set_Reachable(bool value) { }

	internal bool get_TypeLoadExceptionReachable() { }

	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	internal object get_ObjectValue() { }

	internal void SetObjectValue(object obj, ObjectManager manager) { }

	internal SerializationInfo get_SerializationInfo() { }

	internal void set_SerializationInfo(SerializationInfo value) { }

	internal ISerializationSurrogate get_Surrogate() { }

	internal LongList get_DependentObjects() { }

	internal void set_DependentObjects(LongList value) { }

	internal bool get_RequiresSerInfoFixup() { }

	internal void set_RequiresSerInfoFixup(bool value) { }

	internal ValueTypeFixupInfo get_ValueFixup() { }

	internal bool get_CompletelyFixed() { }

	internal long get_ContainerID() { }

}

