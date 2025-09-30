using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CB9 RID: 3257
	[Token(Token = "0x2000CB9")]
	public class MixingStationMk2 : MixingStation
	{
		// Token: 0x06005B60 RID: 23392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B60")]
		[Address(RVA = "0xA3ECF0", Offset = "0xA3D6F0", VA = "0x180A3ECF0", Slot = "131")]
		protected override void MinPass()
		{
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B61")]
		[Address(RVA = "0xA3ED80", Offset = "0xA3D780", VA = "0x180A3ED80", Slot = "133")]
		public override void MixingStart()
		{
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B62")]
		[Address(RVA = "0xA3ED10", Offset = "0xA3D710", VA = "0x180A3ED10", Slot = "134")]
		public override void MixingDone()
		{
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B63")]
		[Address(RVA = "0xA3EAE0", Offset = "0xA3D4E0", VA = "0x180A3EAE0")]
		private void EnableScreen()
		{
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B64")]
		[Address(RVA = "0xA3EE20", Offset = "0xA3D820", VA = "0x180A3EE20")]
		private void UpdateScreen()
		{
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B65")]
		[Address(RVA = "0xA3EAB0", Offset = "0xA3D4B0", VA = "0x180A3EAB0")]
		private void DisableScreen()
		{
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B66")]
		[Address(RVA = "0xA3EEC0", Offset = "0xA3D8C0", VA = "0x180A3EEC0")]
		public MixingStationMk2()
		{
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B67")]
		[Address(RVA = "0xA3EE00", Offset = "0xA3D800", VA = "0x180A3EE00", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B68")]
		[Address(RVA = "0xA3EDE0", Offset = "0xA3D7E0", VA = "0x180A3EDE0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B69")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6A")]
		[Address(RVA = "0xA3EA60", Offset = "0xA3D460", VA = "0x180A3EA60", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x040042B1 RID: 17073
		[Token(Token = "0x40042B1")]
		[FieldOffset(Offset = "0x3C8")]
		public Animation Animation;

		// Token: 0x040042B2 RID: 17074
		[Token(Token = "0x40042B2")]
		[FieldOffset(Offset = "0x3D0")]
		[Header("Screen")]
		public Canvas ScreenCanvas;

		// Token: 0x040042B3 RID: 17075
		[Token(Token = "0x40042B3")]
		[FieldOffset(Offset = "0x3D8")]
		public Image OutputIcon;

		// Token: 0x040042B4 RID: 17076
		[Token(Token = "0x40042B4")]
		[FieldOffset(Offset = "0x3E0")]
		public RectTransform QuestionMark;

		// Token: 0x040042B5 RID: 17077
		[Token(Token = "0x40042B5")]
		[FieldOffset(Offset = "0x3E8")]
		public TextMeshProUGUI QuantityLabel;

		// Token: 0x040042B6 RID: 17078
		[Token(Token = "0x40042B6")]
		[FieldOffset(Offset = "0x3F0")]
		public TextMeshProUGUI ProgressLabel;

		// Token: 0x040042B7 RID: 17079
		[Token(Token = "0x40042B7")]
		[FieldOffset(Offset = "0x3F8")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted;

		// Token: 0x040042B8 RID: 17080
		[Token(Token = "0x40042B8")]
		[FieldOffset(Offset = "0x3F9")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted;
	}
}
