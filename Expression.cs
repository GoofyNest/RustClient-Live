public abstract class Expression // TypeDefIndex: 3239
{
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; 
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; 

	public virtual ExpressionType NodeType { get; }


	public virtual ExpressionType get_NodeType() { }

	private static void .cctor() { }

}

private class Expression.ExtensionInfo // TypeDefIndex: 3242
{

internal class Expression.MemberExpressionProxy 

private class Expression.ExtensionInfo 
	internal readonly ExpressionType NodeType; 

}

