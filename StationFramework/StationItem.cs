using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000978 RID: 2424
	[Token(Token = "0x2000978")]
	public class StationItem : MonoBehaviour
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600427C RID: 17020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700094F")]
		public List<ItemModule> ActiveModules
		{
			[Token(Token = "0x600427B")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600427C")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427D")]
		[Address(RVA = "0x8855E0", Offset = "0x883FE0", VA = "0x1808855E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427E")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "5")]
		public virtual void Initialize(StorableItemDefinition itemDefinition)
		{
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427F")]
		public void ActivateModule<T>() where T : ItemModule
		{
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004280")]
		[Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
		public void Destroy()
		{
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x00011778 File Offset: 0x0000F978
		[Token(Token = "0x6004281")]
		public bool HasModule<T>() where T : ItemModule
		{
			return default(bool);
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004282")]
		public T GetModule<T>() where T : ItemModule
		{
			return null;
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004283")]
		[Address(RVA = "0x8856A0", Offset = "0x8840A0", VA = "0x1808856A0")]
		public StationItem()
		{
		}

		// Token: 0x04002EA2 RID: 11938
		[Token(Token = "0x4002EA2")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemModule> Modules;

		// Token: 0x04002EA3 RID: 11939
		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0x30")]
		public TrashItem TrashPrefab;
	}
}
