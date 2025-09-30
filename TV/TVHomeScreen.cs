using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;

namespace ScheduleOne.TV
{
	// Token: 0x020002B5 RID: 693
	[Token(Token = "0x20002B5")]
	public class TVHomeScreen : TVApp
	{
		// Token: 0x06000E85 RID: 3717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0xAC6D70", Offset = "0xAC5770", VA = "0x180AC6D70", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0xAC71C0", Offset = "0xAC5BC0", VA = "0x180AC71C0", Slot = "5")]
		public override void Open()
		{
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E87")]
		[Address(RVA = "0xAC7170", Offset = "0xAC5B70", VA = "0x180AC7170", Slot = "6")]
		public override void Close()
		{
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E88")]
		[Address(RVA = "0xAC6D10", Offset = "0xAC5710", VA = "0x180AC6D10", Slot = "8")]
		protected override void ActiveMinPass()
		{
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0xAC73D0", Offset = "0xAC5DD0", VA = "0x180AC73D0")]
		private void UpdateTimeLabel()
		{
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0xAC6D20", Offset = "0xAC5720", VA = "0x180AC6D20")]
		private void AppSelected(TVApp app)
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0xAC71E0", Offset = "0xAC5BE0", VA = "0x180AC71E0")]
		private void PlayerChange(Player player)
		{
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0xAC6C80", Offset = "0xAC5680", VA = "0x180AC6C80")]
		public TVHomeScreen()
		{
		}

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public TVInterface Interface;

		// Token: 0x04000EDA RID: 3802
		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x70")]
		public TVApp[] Apps;

		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform AppButtonContainer;

		// Token: 0x04000EDC RID: 3804
		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform[] PlayerDisplays;

		// Token: 0x04000EDD RID: 3805
		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI TimeLabel;

		// Token: 0x04000EDE RID: 3806
		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x90")]
		[Header("Prefabs")]
		public GameObject AppButtonPrefab;

		// Token: 0x04000EDF RID: 3807
		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0x98")]
		private bool skipExit;
	}
}
