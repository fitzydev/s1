using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000CDD RID: 3293
	[Token(Token = "0x2000CDD")]
	public class DigitalAlarm : MonoBehaviour
	{
		// Token: 0x06005D53 RID: 23891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D53")]
		[Address(RVA = "0xA58C80", Offset = "0xA57680", VA = "0x180A58C80")]
		private void Start()
		{
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D54")]
		[Address(RVA = "0xA58A30", Offset = "0xA57430", VA = "0x180A58A30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005D55 RID: 23893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D55")]
		[Address(RVA = "0xA58BB0", Offset = "0xA575B0", VA = "0x180A58BB0")]
		public void SetScreenLit(bool lit)
		{
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D56")]
		[Address(RVA = "0xA58840", Offset = "0xA57240", VA = "0x180A58840")]
		public void DisplayText(string text)
		{
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D57")]
		[Address(RVA = "0xA58760", Offset = "0xA57160", VA = "0x180A58760")]
		public void DisplayMinutes(int mins)
		{
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D58")]
		[Address(RVA = "0xA58970", Offset = "0xA57370", VA = "0x180A58970")]
		private void MinPass()
		{
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D59")]
		[Address(RVA = "0xA58870", Offset = "0xA57270", VA = "0x180A58870")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06005D5A RID: 23898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5A")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public DigitalAlarm()
		{
		}

		// Token: 0x040043B4 RID: 17332
		[Token(Token = "0x40043B4")]
		public const float FLASH_FREQUENCY = 4f;

		// Token: 0x040043B5 RID: 17333
		[Token(Token = "0x40043B5")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer ScreenMesh;

		// Token: 0x040043B6 RID: 17334
		[Token(Token = "0x40043B6")]
		[FieldOffset(Offset = "0x28")]
		public int ScreenMeshMaterialIndex;

		// Token: 0x040043B7 RID: 17335
		[Token(Token = "0x40043B7")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshPro ScreenText;

		// Token: 0x040043B8 RID: 17336
		[Token(Token = "0x40043B8")]
		[FieldOffset(Offset = "0x38")]
		public bool FlashScreen;

		// Token: 0x040043B9 RID: 17337
		[Token(Token = "0x40043B9")]
		[FieldOffset(Offset = "0x39")]
		[Header("Settings")]
		public bool DisplayCurrentTime;

		// Token: 0x040043BA RID: 17338
		[Token(Token = "0x40043BA")]
		[FieldOffset(Offset = "0x40")]
		public Material ScreenOffMat;

		// Token: 0x040043BB RID: 17339
		[Token(Token = "0x40043BB")]
		[FieldOffset(Offset = "0x48")]
		public Material ScreenOnMat;

		// Token: 0x040043BC RID: 17340
		[Token(Token = "0x40043BC")]
		[FieldOffset(Offset = "0x50")]
		private bool isLit;
	}
}
