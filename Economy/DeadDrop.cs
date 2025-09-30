using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020005E0 RID: 1504
	[Token(Token = "0x20005E0")]
	public class DeadDrop : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x0000B6A0 File Offset: 0x000098A0
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000620")]
		public Guid GUID
		{
			[Token(Token = "0x6002474")]
			[Address(RVA = "0x51F4A0", Offset = "0x51DEA0", VA = "0x18051F4A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6002475")]
			[Address(RVA = "0x6D1F40", Offset = "0x6D0940", VA = "0x1806D1F40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002476")]
		[Address(RVA = "0x6D1A10", Offset = "0x6D0410", VA = "0x1806D1A10")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002477")]
		[Address(RVA = "0x6D1590", Offset = "0x6CFF90", VA = "0x1806D1590", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x6D19E0", Offset = "0x6D03E0", VA = "0x1806D19E0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x6D1AC0", Offset = "0x6D04C0", VA = "0x1806D1AC0", Slot = "8")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247A")]
		[Address(RVA = "0x6D1A60", Offset = "0x6D0460", VA = "0x1806D1A60", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247B")]
		[Address(RVA = "0x6D1960", Offset = "0x6D0360", VA = "0x1806D1960")]
		public void OnDestroy()
		{
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x6D16B0", Offset = "0x6D00B0", VA = "0x1806D16B0")]
		public static DeadDrop GetRandomEmptyDrop(Vector3 origin)
		{
			return null;
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x6D1D00", Offset = "0x6D0700", VA = "0x1806D1D00")]
		private void UpdateDeadDrop()
		{
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247E")]
		[Address(RVA = "0x6D1ED0", Offset = "0x6D08D0", VA = "0x1806D1ED0")]
		public DeadDrop()
		{
		}

		// Token: 0x04001C59 RID: 7257
		[Token(Token = "0x4001C59")]
		[FieldOffset(Offset = "0x0")]
		public static List<DeadDrop> DeadDrops;

		// Token: 0x04001C5A RID: 7258
		[Token(Token = "0x4001C5A")]
		[FieldOffset(Offset = "0x20")]
		public string DeadDropName;

		// Token: 0x04001C5B RID: 7259
		[Token(Token = "0x4001C5B")]
		[FieldOffset(Offset = "0x28")]
		public string DeadDropDescription;

		// Token: 0x04001C5C RID: 7260
		[Token(Token = "0x4001C5C")]
		[FieldOffset(Offset = "0x30")]
		public EMapRegion Region;

		// Token: 0x04001C5D RID: 7261
		[Token(Token = "0x4001C5D")]
		[FieldOffset(Offset = "0x38")]
		public WorldStorageEntity Storage;

		// Token: 0x04001C5E RID: 7262
		[Token(Token = "0x4001C5E")]
		[FieldOffset(Offset = "0x40")]
		public POI PoI;

		// Token: 0x04001C5F RID: 7263
		[Token(Token = "0x4001C5F")]
		[FieldOffset(Offset = "0x48")]
		public OptimizedLight Light;

		// Token: 0x04001C60 RID: 7264
		[Token(Token = "0x4001C60")]
		[FieldOffset(Offset = "0x50")]
		public string ItemCountVariable;

		// Token: 0x04001C62 RID: 7266
		[Token(Token = "0x4001C62")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected string BakedGUID;
	}
}
