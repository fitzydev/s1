using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Misc;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CB0 RID: 3248
	[Token(Token = "0x2000CB0")]
	public class LabOvenButton : MonoBehaviour
	{
		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06005A82 RID: 23170 RVA: 0x000161A0 File Offset: 0x000143A0
		// (set) Token: 0x06005A83 RID: 23171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9E")]
		public bool Pressed
		{
			[Token(Token = "0x6005A82")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005A83")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005A84 RID: 23172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A84")]
		[Address(RVA = "0xA28510", Offset = "0xA26F10", VA = "0x180A28510")]
		private void Start()
		{
		}

		// Token: 0x06005A85 RID: 23173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A85")]
		[Address(RVA = "0xA28450", Offset = "0xA26E50", VA = "0x180A28450")]
		public void SetInteractable(bool interactable)
		{
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A86")]
		[Address(RVA = "0xA283D0", Offset = "0xA26DD0", VA = "0x180A283D0")]
		public void Press(RaycastHit hit)
		{
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A87")]
		[Address(RVA = "0xA28470", Offset = "0xA26E70", VA = "0x180A28470")]
		public void SetPressed(bool pressed)
		{
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A88")]
		[Address(RVA = "0xA28620", Offset = "0xA27020", VA = "0x180A28620")]
		private void Update()
		{
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A89")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public LabOvenButton()
		{
		}

		// Token: 0x04004234 RID: 16948
		[Token(Token = "0x4004234")]
		private const float ANIMATION_TIME = 0.2f;

		// Token: 0x04004236 RID: 16950
		[Token(Token = "0x4004236")]
		[FieldOffset(Offset = "0x28")]
		public Transform Button;

		// Token: 0x04004237 RID: 16951
		[Token(Token = "0x4004237")]
		[FieldOffset(Offset = "0x30")]
		public Transform PressedTransform;

		// Token: 0x04004238 RID: 16952
		[Token(Token = "0x4004238")]
		[FieldOffset(Offset = "0x38")]
		public Transform DepressedTransform;

		// Token: 0x04004239 RID: 16953
		[Token(Token = "0x4004239")]
		[FieldOffset(Offset = "0x40")]
		public ToggleableLight Light;

		// Token: 0x0400423A RID: 16954
		[Token(Token = "0x400423A")]
		[FieldOffset(Offset = "0x48")]
		public Clickable Clickable;

		// Token: 0x0400423B RID: 16955
		[Token(Token = "0x400423B")]
		[FieldOffset(Offset = "0x50")]
		private float animationTimer;

		// Token: 0x0400423C RID: 16956
		[Token(Token = "0x400423C")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 animationStartPos;

		// Token: 0x0400423D RID: 16957
		[Token(Token = "0x400423D")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 animationEndPos;
	}
}
