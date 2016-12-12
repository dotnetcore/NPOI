#if !NET46
namespace System
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
	public sealed class SerializableAttribute : Attribute
	{
		public SerializableAttribute() { }
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Field | AttributeTargets.Delegate, Inherited = false)]
    public sealed class NonSerializedAttribute : Attribute
	{
		public NonSerializedAttribute() { }
	}
}
#endif
