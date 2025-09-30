using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x02000954 RID: 2388
	[Token(Token = "0x2000954")]
	[RequireComponent(typeof(StorageEntity))]
	public class StorageEntityVisualizer : StorageVisualizer
	{
		// Token: 0x06004188 RID: 16776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004188")]
		[Address(RVA = "0x886B50", Offset = "0x885550", VA = "0x180886B50", Slot = "7")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004189")]
		[Address(RVA = "0x886CB0", Offset = "0x8856B0", VA = "0x180886CB0")]
		public StorageEntityVisualizer()
		{
		}

		// Token: 0x04002DEF RID: 11759
		[Token(Token = "0x4002DEF")]
		[FieldOffset(Offset = "0x58")]
		private StorageEntity storageEntity;
	}
}
