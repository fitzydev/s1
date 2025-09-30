using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	public class TVInterface : MonoBehaviour
	{
		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00007278 File Offset: 0x00005478
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700031D")]
		public bool IsOpen
		{
			[Token(Token = "0x6000E93")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E94")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0xAC7730", Offset = "0xAC6130", VA = "0x180AC7730")]
		public void Awake()
		{
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0xAC85C0", Offset = "0xAC6FC0", VA = "0x180AC85C0")]
		public void Start()
		{
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0xAC7E70", Offset = "0xAC6870", VA = "0x180AC7E70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E98")]
		[Address(RVA = "0xAC7CF0", Offset = "0xAC66F0", VA = "0x180AC7CF0")]
		private void MinPass()
		{
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0xAC7F90", Offset = "0xAC6990", VA = "0x180AC7F90")]
		public void Open()
		{
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0xAC7860", Offset = "0xAC6260", VA = "0x180AC7860")]
		public void Close()
		{
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0xAC7CA0", Offset = "0xAC66A0", VA = "0x180AC7CA0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0xAC7850", Offset = "0xAC6250", VA = "0x180AC7850")]
		public bool CanOpen()
		{
			return default(bool);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0xAC7630", Offset = "0xAC6030", VA = "0x180AC7630")]
		public void AddPlayer(Player player)
		{
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0xAC8510", Offset = "0xAC6F10", VA = "0x180AC8510")]
		public void RemovePlayer(Player player)
		{
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0xAC8660", Offset = "0xAC7060", VA = "0x180AC8660")]
		public TVInterface()
		{
		}

		// Token: 0x04000EE4 RID: 3812
		[Token(Token = "0x4000EE4")]
		public const float OPEN_TIME = 0.15f;

		// Token: 0x04000EE5 RID: 3813
		[Token(Token = "0x4000EE5")]
		public const float FOV = 60f;

		// Token: 0x04000EE7 RID: 3815
		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x28")]
		public List<Player> Players;

		// Token: 0x04000EE8 RID: 3816
		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04000EE9 RID: 3817
		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0x38")]
		public Transform CameraPosition;

		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x40")]
		public TVHomeScreen HomeScreen;

		// Token: 0x04000EEB RID: 3819
		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshPro TimeLabel;

		// Token: 0x04000EEC RID: 3820
		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshPro Daylabel;

		// Token: 0x04000EED RID: 3821
		[Token(Token = "0x4000EED")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent<Player> onPlayerAdded;

		// Token: 0x04000EEE RID: 3822
		[Token(Token = "0x4000EEE")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent<Player> onPlayerRemoved;
	}
}
