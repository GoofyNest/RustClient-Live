internal static class ExceptionBuilder // TypeDefIndex: 4201
{	// Methods

	// RVA: 0x13D9D80 Offset: 0x13D9180 VA: 0x1813D9D80
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x13D9B70 Offset: 0x13D8F70 VA: 0x1813D9B70
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x13D9C20 Offset: 0x13D9020 VA: 0x1813D9C20
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0x13D9CD0 Offset: 0x13D90D0 VA: 0x1813D9CD0
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x13DA380 Offset: 0x13D9780 VA: 0x1813DA380
	internal static Exception _Argument(string error) { }

	// RVA: 0x13DA310 Offset: 0x13D9710 VA: 0x1813DA310
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0x13DA230 Offset: 0x13D9630 VA: 0x1813DA230
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0x13DA2A0 Offset: 0x13D96A0 VA: 0x1813DA2A0
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0x13DA560 Offset: 0x13D9960 VA: 0x1813DA560
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0x13DA680 Offset: 0x13D9A80 VA: 0x1813DA680
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0x13DA620 Offset: 0x13D9A20 VA: 0x1813DA620
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: -1 Offset: -1
	private static Exception _InvalidEnumArgumentException<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B14CB0 Offset: 0x1B140B0 VA: 0x181B14CB0
	|-ExceptionBuilder._InvalidEnumArgumentException<DataRowState>
	|-ExceptionBuilder._InvalidEnumArgumentException<DataSetDateTime>
	|-ExceptionBuilder._InvalidEnumArgumentException<SerializationFormat>
	|-ExceptionBuilder._InvalidEnumArgumentException<Int32Enum>
	|
	|-RVA: 0x1B14DB0 Offset: 0x1B141B0 VA: 0x181B14DB0
	|-ExceptionBuilder._InvalidEnumArgumentException<object>
	*/

	// RVA: 0x13D9A30 Offset: 0x13D8E30 VA: 0x1813D9A30
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0x13D6AA0 Offset: 0x13D5EA0 VA: 0x1813D6AA0
	private static Exception _Data(string error) { }

	// RVA: 0x13DA3E0 Offset: 0x13D97E0 VA: 0x1813DA3E0
	private static Exception _Constraint(string error) { }

	// RVA: 0x13DA5C0 Offset: 0x13D99C0 VA: 0x1813DA5C0
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0x13DA440 Offset: 0x13D9840 VA: 0x1813DA440
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0x13DA4A0 Offset: 0x13D98A0 VA: 0x1813DA4A0
	private static Exception _DuplicateName(string error) { }

	// RVA: 0x13DA500 Offset: 0x13D9900 VA: 0x1813DA500
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0x13DA6E0 Offset: 0x13D9AE0 VA: 0x1813DA6E0
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0x13DA740 Offset: 0x13D9B40 VA: 0x1813DA740
	private static Exception _ReadOnly(string error) { }

	// RVA: 0x13DA7A0 Offset: 0x13D9BA0 VA: 0x1813DA7A0
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0x13DA800 Offset: 0x13D9C00 VA: 0x1813DA800
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0x13D1C70 Offset: 0x13D1070 VA: 0x1813D1C70
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0x13D1D10 Offset: 0x13D1110 VA: 0x1813D1D10
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x13D2070 Offset: 0x13D1470 VA: 0x1813D2070
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0x13D3550 Offset: 0x13D2950 VA: 0x1813D3550
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0x13D6F90 Offset: 0x13D6390 VA: 0x1813D6F90
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0x13D5EC0 Offset: 0x13D52C0 VA: 0x1813D5EC0
	public static Exception InvalidOffsetLength() { }

	// RVA: 0x13D3870 Offset: 0x13D2C70 VA: 0x1813D3870
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0x13D37F0 Offset: 0x13D2BF0 VA: 0x1813D37F0
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0x13D3900 Offset: 0x13D2D00 VA: 0x1813D3900
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0x13D39C0 Offset: 0x13D2DC0 VA: 0x1813D39C0
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0x13D2600 Offset: 0x13D1A00 VA: 0x1813D2600
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0x13D2690 Offset: 0x13D1A90 VA: 0x1813D2690
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0x13D2720 Offset: 0x13D1B20 VA: 0x1813D2720
	public static Exception CannotAddColumn3() { }

	// RVA: 0x13D27A0 Offset: 0x13D1BA0 VA: 0x1813D27A0
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0x13D2950 Offset: 0x13D1D50 VA: 0x1813D2950
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0x13D2830 Offset: 0x13D1C30 VA: 0x1813D2830
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0x13D28C0 Offset: 0x13D1CC0 VA: 0x1813D28C0
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0x13D2D30 Offset: 0x13D2130 VA: 0x1813D2D30
	public static Exception CannotRemoveColumn() { }

	// RVA: 0x13D2ED0 Offset: 0x13D22D0 VA: 0x1813D2ED0
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0x13D2CA0 Offset: 0x13D20A0 VA: 0x1813D2CA0
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0x13D2DB0 Offset: 0x13D21B0 VA: 0x1813D2DB0
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0x13D2E40 Offset: 0x13D2240 VA: 0x1813D2E40
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0x13D1AF0 Offset: 0x13D0EF0 VA: 0x1813D1AF0
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0x13D7200 Offset: 0x13D6600 VA: 0x1813D7200
	public static Exception NoConstraintName() { }

	// RVA: 0x13D3E90 Offset: 0x13D3290 VA: 0x1813D3E90
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0x13D6830 Offset: 0x13D5C30 VA: 0x1813D6830
	public static string KeysToString(object[] keys) { }

	// RVA: 0x13D9FB0 Offset: 0x13D93B0 VA: 0x1813D9FB0
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0x13D3F20 Offset: 0x13D3320 VA: 0x1813D3F20
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0x13D3CD0 Offset: 0x13D30D0 VA: 0x1813D3CD0
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0x13D4A10 Offset: 0x13D3E10 VA: 0x1813D4A10
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0x13D48F0 Offset: 0x13D3CF0 VA: 0x1813D48F0
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0x13D7020 Offset: 0x13D6420 VA: 0x1813D7020
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0x13DA130 Offset: 0x13D9530 VA: 0x1813DA130
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0x13D3C50 Offset: 0x13D3050 VA: 0x1813D3C50
	public static Exception ConstraintForeignTable() { }

	// RVA: 0x13D3D90 Offset: 0x13D3190 VA: 0x1813D3D90
	public static Exception ConstraintParentValues() { }

	// RVA: 0x13D3BB0 Offset: 0x13D2FB0 VA: 0x1813D3BB0
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0x13D3E10 Offset: 0x13D3210 VA: 0x1813D3E10
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0x13D5260 Offset: 0x13D4660 VA: 0x1813D5260
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0x13D52F0 Offset: 0x13D46F0 VA: 0x1813D52F0
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0x13D5380 Offset: 0x13D4780 VA: 0x1813D5380
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0x13D5430 Offset: 0x13D4830 VA: 0x1813D5430
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0x13D8680 Offset: 0x13D7A80 VA: 0x1813D8680
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0x13D6A60 Offset: 0x13D5E60 VA: 0x1813D6A60
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0x13D7510 Offset: 0x13D6910 VA: 0x1813D7510
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0x13D3310 Offset: 0x13D2710 VA: 0x1813D3310
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0x13D1EE0 Offset: 0x13D12E0 VA: 0x1813D1EE0
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0x13D1E60 Offset: 0x13D1260 VA: 0x1813D1E60
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0x13D1FF0 Offset: 0x13D13F0 VA: 0x1813D1FF0
	public static Exception AutoIncrementSeed() { }

	// RVA: 0x13D33A0 Offset: 0x13D27A0 VA: 0x1813D33A0
	public static Exception CantChangeDataType() { }

	// RVA: 0x13D75D0 Offset: 0x13D69D0 VA: 0x1813D75D0
	public static Exception NullDataType() { }

	// RVA: 0x13D3770 Offset: 0x13D2B70 VA: 0x1813D3770
	public static Exception ColumnNameRequired() { }

	// RVA: 0x13D4450 Offset: 0x13D3850 VA: 0x1813D4450
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0x13D45D0 Offset: 0x13D39D0 VA: 0x1813D45D0
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x13D44D0 Offset: 0x13D38D0 VA: 0x1813D44D0
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x13D50C0 Offset: 0x13D44C0 VA: 0x1813D50C0
	public static Exception ExpressionAndUnique() { }

	// RVA: 0x13D5040 Offset: 0x13D4440 VA: 0x1813D5040
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0x13D4F80 Offset: 0x13D4380 VA: 0x1813D4F80
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0x13D51C0 Offset: 0x13D45C0 VA: 0x1813D51C0
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0x13D5140 Offset: 0x13D4540 VA: 0x1813D5140
	public static Exception ExpressionCircular() { }

	// RVA: 0x13D7480 Offset: 0x13D6880 VA: 0x1813D7480
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0x13D7650 Offset: 0x13D6A50 VA: 0x1813D7650
	public static Exception NullKeyValues(string column) { }

	// RVA: 0x13D7760 Offset: 0x13D6B60 VA: 0x1813D7760
	public static Exception NullValues(string column) { }

	// RVA: 0x13D7B50 Offset: 0x13D6F50 VA: 0x1813D7B50
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0x13D7BD0 Offset: 0x13D6FD0 VA: 0x1813D7BD0
	public static Exception ReadOnly(string column) { }

	// RVA: 0x13D9F30 Offset: 0x13D9330 VA: 0x1813D9F30
	public static Exception UniqueAndExpression() { }

	// RVA: 0x13D90B0 Offset: 0x13D84B0 VA: 0x1813D90B0
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0x13D3270 Offset: 0x13D2670 VA: 0x1813D3270
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0x13D6930 Offset: 0x13D5D30 VA: 0x1813D6930
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0x13D3070 Offset: 0x13D2470 VA: 0x1813D3070
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0x13D2FD0 Offset: 0x13D23D0 VA: 0x1813D2FD0
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0x13D3150 Offset: 0x13D2550 VA: 0x1813D3150
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0x13D31E0 Offset: 0x13D25E0 VA: 0x1813D31E0
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0x13D2AF0 Offset: 0x13D1EF0 VA: 0x1813D2AF0
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0x13D5720 Offset: 0x13D4B20 VA: 0x1813D5720
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0x13D1F60 Offset: 0x13D1360 VA: 0x1813D1F60
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0x13D5850 Offset: 0x13D4C50 VA: 0x1813D5850
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0x13D57C0 Offset: 0x13D4BC0 VA: 0x1813D57C0
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0x13D9E10 Offset: 0x13D9210 VA: 0x1813D9E10
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0x13D5C20 Offset: 0x13D5020 VA: 0x1813D5C20
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0x13D2F50 Offset: 0x13D2350 VA: 0x1813D2F50
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0x13D5CD0 Offset: 0x13D50D0 VA: 0x1813D5CD0
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0x13D3420 Offset: 0x13D2820 VA: 0x1813D3420
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0x13D3AE0 Offset: 0x13D2EE0 VA: 0x1813D3AE0
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0x13D9020 Offset: 0x13D8420 VA: 0x1813D9020
	public static Exception SetFailed(string name) { }

	// RVA: 0x13D2500 Offset: 0x13D1900 VA: 0x1813D2500
	public static Exception CanNotUse() { }

	// RVA: 0x13D91F0 Offset: 0x13D85F0 VA: 0x1813D91F0
	public static Exception SetIListObject() { }

	// RVA: 0x13D1A70 Offset: 0x13D0E70 VA: 0x1813D1A70
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0x13D7550 Offset: 0x13D6950 VA: 0x1813D7550
	public static Exception NotOpen() { }

	// RVA: 0x13D41B0 Offset: 0x13D35B0 VA: 0x1813D41B0
	public static Exception CreateChildView() { }

	// RVA: 0x13D2200 Offset: 0x13D1600 VA: 0x1813D2200
	public static Exception CanNotDelete() { }

	// RVA: 0x13D55D0 Offset: 0x13D49D0 VA: 0x1813D55D0
	public static Exception GetElementIndex(int index) { }

	// RVA: 0x13D19F0 Offset: 0x13D0DF0 VA: 0x1813D19F0
	public static Exception AddExternalObject() { }

	// RVA: 0x13D2180 Offset: 0x13D1580 VA: 0x1813D2180
	public static Exception CanNotClear() { }

	// RVA: 0x13D5A70 Offset: 0x13D4E70 VA: 0x1813D5A70
	public static Exception InsertExternalObject() { }

	// RVA: 0x13D8600 Offset: 0x13D7A00 VA: 0x1813D8600
	public static Exception RemoveExternalObject() { }

	// RVA: 0x13D66F0 Offset: 0x13D5AF0 VA: 0x1813D66F0
	public static Exception KeyTableMismatch() { }

	// RVA: 0x13D6670 Offset: 0x13D5A70 VA: 0x1813D6670
	public static Exception KeyNoColumns() { }

	// RVA: 0x13D6770 Offset: 0x13D5B70 VA: 0x1813D6770
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0x13D64E0 Offset: 0x13D58E0 VA: 0x1813D64E0
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0x13D7F80 Offset: 0x13D7380 VA: 0x1813D7F80
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0x13D3B30 Offset: 0x13D2F30 VA: 0x1813D3B30
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0x13D6570 Offset: 0x13D5970 VA: 0x1813D6570
	public static Exception KeyLengthMismatch() { }

	// RVA: 0x13D65F0 Offset: 0x13D59F0 VA: 0x1813D65F0
	public static Exception KeyLengthZero() { }

	// RVA: 0x13D54D0 Offset: 0x13D48D0 VA: 0x1813D54D0
	public static Exception ForeignRelation() { }

	// RVA: 0x13D6460 Offset: 0x13D5860 VA: 0x1813D6460
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0x13D8180 Offset: 0x13D7580 VA: 0x1813D8180
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0x13D5690 Offset: 0x13D4A90 VA: 0x1813D5690
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x13D9270 Offset: 0x13D8670 VA: 0x1813D9270
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x13D8100 Offset: 0x13D7500 VA: 0x1813D8100
	public static Exception RelationForeignRow() { }

	// RVA: 0x13D8210 Offset: 0x13D7610 VA: 0x1813D8210
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0x13D9580 Offset: 0x13D8980 VA: 0x1813D9580
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0x13D69D0 Offset: 0x13D5DD0 VA: 0x1813D69D0
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0x13D8080 Offset: 0x13D7480 VA: 0x1813D8080
	public static Exception RelationDoesNotExist() { }

	// RVA: 0x13D77F0 Offset: 0x13D6BF0 VA: 0x1813D77F0
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0x13D58E0 Offset: 0x13D4CE0 VA: 0x1813D58E0
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0x13D5F40 Offset: 0x13D5340 VA: 0x1813D5F40
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0x13D8BC0 Offset: 0x13D7FC0 VA: 0x1813D8BC0
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0x13D8C40 Offset: 0x13D8040 VA: 0x1813D8C40
	public static Exception RowNotInTheTable() { }

	// RVA: 0x13D4CF0 Offset: 0x13D40F0 VA: 0x1813D4CF0
	public static Exception EditInRowChanging() { }

	// RVA: 0x13D4E00 Offset: 0x13D4200 VA: 0x1813D4E00
	public static Exception EndEditInRowChanging() { }

	// RVA: 0x13D2100 Offset: 0x13D1500 VA: 0x1813D2100
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0x13D2580 Offset: 0x13D1980 VA: 0x1813D2580
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0x13D46E0 Offset: 0x13D3AE0 VA: 0x1813D46E0
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0x13DA1B0 Offset: 0x13D95B0 VA: 0x1813DA1B0
	public static Exception ValueArrayLength() { }

	// RVA: 0x13D7280 Offset: 0x13D6680 VA: 0x1813D7280
	public static Exception NoCurrentData() { }

	// RVA: 0x13D7300 Offset: 0x13D6700 VA: 0x1813D7300
	public static Exception NoOriginalData() { }

	// RVA: 0x13D7380 Offset: 0x13D6780 VA: 0x1813D7380
	public static Exception NoProposedData() { }

	// RVA: 0x13D8E00 Offset: 0x13D8200 VA: 0x1813D8E00
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0x13D4760 Offset: 0x13D3B60 VA: 0x1813D4760
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0x13D87E0 Offset: 0x13D7BE0 VA: 0x1813D87E0
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0x13D89E0 Offset: 0x13D7DE0 VA: 0x1813D89E0
	public static Exception RowEmpty() { }

	// RVA: 0x13D6160 Offset: 0x13D5560 VA: 0x1813D6160
	public static Exception InvalidRowVersion() { }

	// RVA: 0x13D8D80 Offset: 0x13D8180 VA: 0x1813D8D80
	public static Exception RowOutOfRange() { }

	// RVA: 0x13D8CC0 Offset: 0x13D80C0 VA: 0x1813D8CC0
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0x13D8AF0 Offset: 0x13D7EF0 VA: 0x1813D8AF0
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0x13D8A60 Offset: 0x13D7E60 VA: 0x1813D8A60
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0x13D8960 Offset: 0x13D7D60 VA: 0x1813D8960
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0x13D6E90 Offset: 0x13D6290 VA: 0x1813D6E90
	public static Exception MultipleParents() { }

	// RVA: 0x13D6120 Offset: 0x13D5520 VA: 0x1813D6120
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0x13D60A0 Offset: 0x13D54A0 VA: 0x1813D60A0
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0x13D8FA0 Offset: 0x13D83A0 VA: 0x1813D8FA0
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0x13D8F10 Offset: 0x13D8310 VA: 0x1813D8F10
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0x13D4230 Offset: 0x13D3630 VA: 0x1813D4230
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0x13D6B00 Offset: 0x13D5F00 VA: 0x1813D6B00
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0x13D99B0 Offset: 0x13D8DB0 VA: 0x1813D99B0
	public static Exception TablesInDifferentSets() { }

	// RVA: 0x13D7CE0 Offset: 0x13D70E0 VA: 0x1813D7CE0
	public static Exception RelationAlreadyExists() { }

	// RVA: 0x13D8860 Offset: 0x13D7C60 VA: 0x1813D8860
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0x13D88E0 Offset: 0x13D7CE0 VA: 0x1813D88E0
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0x13D7C60 Offset: 0x13D7060 VA: 0x1813D7C60
	public static Exception RecordStateRange() { }

	// RVA: 0x13D5970 Offset: 0x13D4D70 VA: 0x1813D5970
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0x13D8730 Offset: 0x13D7B30 VA: 0x1813D8730
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0x13D7D60 Offset: 0x13D7160 VA: 0x1813D7D60
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0x13D7DE0 Offset: 0x13D71E0 VA: 0x1813D7DE0
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0x13D8290 Offset: 0x13D7690 VA: 0x1813D8290
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0x13D8320 Offset: 0x13D7720 VA: 0x1813D8320
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0x13D4B30 Offset: 0x13D3F30 VA: 0x1813D4B30
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0x13D8500 Offset: 0x13D7900 VA: 0x1813D8500
	public static Exception RelationTableNull() { }

	// RVA: 0x13D8000 Offset: 0x13D7400 VA: 0x1813D8000
	public static Exception RelationDataSetNull() { }

	// RVA: 0x13D8580 Offset: 0x13D7980 VA: 0x1813D8580
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0x13D7870 Offset: 0x13D6C70 VA: 0x1813D7870
	public static Exception ParentTableMismatch() { }

	// RVA: 0x13D3660 Offset: 0x13D2A60 VA: 0x1813D3660
	public static Exception ChildTableMismatch() { }

	// RVA: 0x13D4E80 Offset: 0x13D4280 VA: 0x1813D4E80
	public static Exception EnforceConstraint() { }

	// RVA: 0x13D35E0 Offset: 0x13D29E0 VA: 0x1813D35E0
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0x13D2A70 Offset: 0x13D1E70 VA: 0x1813D2A70
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0x13D29E0 Offset: 0x13D1DE0 VA: 0x1813D29E0
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0x13D6060 Offset: 0x13D5460 VA: 0x1813D6060
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0x13D9610 Offset: 0x13D8A10 VA: 0x1813D9610
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0x13D9500 Offset: 0x13D8900 VA: 0x1813D9500
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0x13D7400 Offset: 0x13D6800 VA: 0x1813D7400
	public static Exception NoTableName() { }

	// RVA: 0x13D6F10 Offset: 0x13D6310 VA: 0x1813D6F10
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0x13D6270 Offset: 0x13D5670 VA: 0x1813D6270
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0x13D4C60 Offset: 0x13D4060 VA: 0x1813D4C60
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0x13D4BC0 Offset: 0x13D3FC0 VA: 0x1813D4BC0
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0x13D8E80 Offset: 0x13D8280 VA: 0x1813D8E80
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0x13D4340 Offset: 0x13D3740 VA: 0x1813D4340
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0x13D9400 Offset: 0x13D8800 VA: 0x1813D9400
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0x13D9480 Offset: 0x13D8880 VA: 0x1813D9480
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0x13D98F0 Offset: 0x13D8CF0 VA: 0x1813D98F0
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0x13D9860 Offset: 0x13D8C60 VA: 0x1813D9860
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0x13D9750 Offset: 0x13D8B50 VA: 0x1813D9750
	public static Exception TableInRelation() { }

	// RVA: 0x13D9690 Offset: 0x13D8A90 VA: 0x1813D9690
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0x13D2380 Offset: 0x13D1780 VA: 0x1813D2380
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0x13D2300 Offset: 0x13D1700 VA: 0x1813D2300
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0x13D2480 Offset: 0x13D1880 VA: 0x1813D2480
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0x13D2400 Offset: 0x13D1800 VA: 0x1813D2400
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0x13D97D0 Offset: 0x13D8BD0 VA: 0x1813D97D0
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0x13D1B70 Offset: 0x13D0F70 VA: 0x1813D1B70
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0x13D6300 Offset: 0x13D5700 VA: 0x1813D6300
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0x13D7A60 Offset: 0x13D6E60 VA: 0x1813D7A60
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0x13D76E0 Offset: 0x13D6AE0 VA: 0x1813D76E0
	public static Exception NullRange() { }

	// RVA: 0x13D70F0 Offset: 0x13D64F0 VA: 0x1813D70F0
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0x13D7980 Offset: 0x13D6D80 VA: 0x1813D7980
	public static Exception ProblematicChars(char charValue) { }

	// RVA: 0x13D9380 Offset: 0x13D8780 VA: 0x1813D9380
	public static Exception StorageSetFailed() { }

	// RVA: 0x13D9300 Offset: 0x13D8700 VA: 0x1813D9300
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0x13D6CA0 Offset: 0x13D60A0 VA: 0x1813D6CA0
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0x13D6C10 Offset: 0x13D6010 VA: 0x1813D6C10
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0x13D5B90 Offset: 0x13D4F90 VA: 0x1813D5B90
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0x13D1DB0 Offset: 0x13D11B0 VA: 0x1813D1DB0
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0x13D4D70 Offset: 0x13D4170 VA: 0x1813D4D70
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0x13D83E0 Offset: 0x13D77E0 VA: 0x1813D83E0
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0x13D7EF0 Offset: 0x13D72F0 VA: 0x1813D7EF0
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0x13D8470 Offset: 0x13D7870 VA: 0x1813D8470
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0x13D7E60 Offset: 0x13D7260 VA: 0x1813D7E60
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0x13D9EA0 Offset: 0x13D92A0 VA: 0x1813D9EA0
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0x13D43D0 Offset: 0x13D37D0 VA: 0x1813D43D0
	public static Exception DatatypeNotDefined() { }

	// RVA: 0x13D6B90 Offset: 0x13D5F90 VA: 0x1813D6B90
	public static Exception MismatchKeyLength() { }

	// RVA: 0x13D5DA0 Offset: 0x13D51A0 VA: 0x1813D5DA0
	public static Exception InvalidField(string name) { }

	// RVA: 0x13D61E0 Offset: 0x13D55E0 VA: 0x1813D61E0
	public static Exception InvalidSelector(string name) { }

	// RVA: 0x13D36E0 Offset: 0x13D2AE0 VA: 0x1813D36E0
	public static Exception CircularComplexType(string name) { }

	// RVA: 0x13D2C10 Offset: 0x13D2010 VA: 0x1813D2C10
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0x13D5E30 Offset: 0x13D5230 VA: 0x1813D5E30
	public static Exception InvalidKey(string name) { }

	// RVA: 0x13D4860 Offset: 0x13D3C60 VA: 0x1813D4860
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0x13D47E0 Offset: 0x13D3BE0 VA: 0x1813D47E0
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0x13D4980 Offset: 0x13D3D80 VA: 0x1813D4980
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0x13D3A50 Offset: 0x13D2E50 VA: 0x1813D3A50
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0x13D2B80 Offset: 0x13D1F80 VA: 0x1813D2B80
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0x13D6D60 Offset: 0x13D6160 VA: 0x1813D6D60
	public static Exception MissingRefer(string name) { }

	// RVA: 0x13D5FD0 Offset: 0x13D53D0 VA: 0x1813D5FD0
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0x13D2280 Offset: 0x13D1680 VA: 0x1813D2280
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0x13D63E0 Offset: 0x13D57E0 VA: 0x1813D63E0
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0x13D9AF0 Offset: 0x13D8EF0 VA: 0x1813D9AF0
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0x13D7170 Offset: 0x13D6570 VA: 0x1813D7170
	public static Exception NestedCircular(string name) { }

	// RVA: 0x13D6E00 Offset: 0x13D6200 VA: 0x1813D6E00
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0x13D78F0 Offset: 0x13D6CF0 VA: 0x1813D78F0
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0x13D42C0 Offset: 0x13D36C0 VA: 0x1813D42C0
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0x13D9AA0 Offset: 0x13D8EA0 VA: 0x1813D9AA0
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0x13D4AA0 Offset: 0x13D3EA0 VA: 0x1813D4AA0
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0x13D5550 Offset: 0x13D4950 VA: 0x1813D5550
	public static Exception FoundEntity() { }

	// RVA: 0x13D6AA0 Offset: 0x13D5EA0 VA: 0x1813D6AA0
	public static Exception MergeFailed(string name) { }

	// RVA: 0x13D40E0 Offset: 0x13D34E0 VA: 0x1813D40E0
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0x13D5D10 Offset: 0x13D5110 VA: 0x1813D5D10
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0x13D5AF0 Offset: 0x13D4EF0 VA: 0x1813D5AF0
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0x13D4F00 Offset: 0x13D4300 VA: 0x1813D4F00
	public static Exception EnumeratorModified() { }

}

