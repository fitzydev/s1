using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000AA7 RID: 2727
	[Token(Token = "0x2000AA7")]
	public class GenericUIScreen : MonoBehaviour
	{
		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06004A20 RID: 18976 RVA: 0x00013518 File Offset: 0x00011718
		// (set) Token: 0x06004A21 RID: 18977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6A")]
		public bool IsOpen
		{
			[Token(Token = "0x6004A20")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A21")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A22")]
		[Address(RVA = "0x917340", Offset = "0x915D40", VA = "0x180917340")]
		private void Awake()
		{
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A23")]
		[Address(RVA = "0x9176B0", Offset = "0x9160B0", VA = "0x1809176B0")]
		public void Open()
		{
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A24")]
		[Address(RVA = "0x9173E0", Offset = "0x915DE0", VA = "0x1809173E0")]
		public void Close()
		{
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A25")]
		[Address(RVA = "0x917650", Offset = "0x916050", VA = "0x180917650")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A26")]
		[Address(RVA = "0x9178B0", Offset = "0x9162B0", VA = "0x1809178B0")]
		public GenericUIScreen()
		{
		}

		// Token: 0x040034EA RID: 13546
		[Token(Token = "0x40034EA")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public string Name;

		// Token: 0x040034EB RID: 13547
		[Token(Token = "0x40034EB")]
		[FieldOffset(Offset = "0x30")]
		public bool UseExitActions;

		// Token: 0x040034EC RID: 13548
		[Token(Token = "0x40034EC")]
		[FieldOffset(Offset = "0x34")]
		public int ExitActionPriority;

		// Token: 0x040034ED RID: 13549
		[Token(Token = "0x40034ED")]
		[FieldOffset(Offset = "0x38")]
		public bool CanExitWithRightClick;

		// Token: 0x040034EE RID: 13550
		[Token(Token = "0x40034EE")]
		[FieldOffset(Offset = "0x39")]
		public bool ReenableControlsOnClose;

		// Token: 0x040034EF RID: 13551
		[Token(Token = "0x40034EF")]
		[FieldOffset(Offset = "0x3A")]
		public bool ReenableInventoryOnClose;

		// Token: 0x040034F0 RID: 13552
		[Token(Token = "0x40034F0")]
		[FieldOffset(Offset = "0x3B")]
		public bool ReenableEquippingOnClose;

		// Token: 0x040034F1 RID: 13553
		[Token(Token = "0x40034F1")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onOpen;

		// Token: 0x040034F2 RID: 13554
		[Token(Token = "0x40034F2")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onClose;
	}
}
