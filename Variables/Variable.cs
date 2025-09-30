using System;
using FishNet.Connection;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine.Events;

namespace ScheduleOne.Variables
{
	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	public class Variable<T> : BaseVariable
	{
		// Token: 0x06000DF2 RID: 3570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DF2")]
		public Variable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, T value)
		{
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF3")]
		public override object GetValue()
		{
			return null;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DF4")]
		public override void SetValue(object value, bool replicate)
		{
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000070B0 File Offset: 0x000052B0
		[Token(Token = "0x6000DF5")]
		public virtual bool TryDeserialize(string valueString, out T value)
		{
			return default(bool);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DF6")]
		public override void ReplicateValue(NetworkConnection conn)
		{
		}

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x0")]
		public T Value;

		// Token: 0x04000E3A RID: 3642
		[Token(Token = "0x4000E3A")]
		[FieldOffset(Offset = "0x0")]
		public UnityEvent<T> OnValueChanged;
	}
}
