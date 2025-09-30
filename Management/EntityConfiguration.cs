using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x020004DA RID: 1242
	[Token(Token = "0x20004DA")]
	public class EntityConfiguration
	{
		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045F")]
		public ConfigurationReplicator Replicator
		{
			[Token(Token = "0x60018E8")]
			[Address(RVA = "0x42FFD0", Offset = "0x42E9D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018E9")]
			[Address(RVA = "0x4A4990", Offset = "0x4A3390", VA = "0x1804A4990")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000460")]
		public IConfigurable Configurable
		{
			[Token(Token = "0x60018EA")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018EB")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x00008EF8 File Offset: 0x000070F8
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000461")]
		public bool IsSelected
		{
			[Token(Token = "0x60018EC")]
			[Address(RVA = "0x4BE260", Offset = "0x4BCC60", VA = "0x1804BE260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60018ED")]
			[Address(RVA = "0x4F3A70", Offset = "0x4F2470", VA = "0x1804F3A70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x607190", Offset = "0x605B90", VA = "0x180607190")]
		public EntityConfiguration(ConfigurationReplicator replicator, IConfigurable configurable)
		{
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x5D52A0", Offset = "0x5D3CA0", VA = "0x1805D52A0")]
		protected void InvokeChanged()
		{
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x607160", Offset = "0x605B60", VA = "0x180607160")]
		public void ReplicateField(ConfigField field, [Optional] NetworkConnection conn)
		{
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x606FC0", Offset = "0x6059C0", VA = "0x180606FC0")]
		public void ReplicateAllFields([Optional] NetworkConnection conn, bool replicateDefaults = true)
		{
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x606F60", Offset = "0x605960", VA = "0x180606F60", Slot = "4")]
		public virtual void Destroy()
		{
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "5")]
		public virtual void Reset()
		{
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x607180", Offset = "0x605B80", VA = "0x180607180", Slot = "6")]
		public virtual void Selected()
		{
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x606F50", Offset = "0x605950", VA = "0x180606F50", Slot = "7")]
		public virtual void Deselected()
		{
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x60018F6")]
		[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "8")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x606F80", Offset = "0x605980", VA = "0x180606F80", Slot = "9")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x0400160F RID: 5647
		[Token(Token = "0x400160F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<ConfigField> Fields;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent onChanged;
	}
}
