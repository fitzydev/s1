using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x02000962 RID: 2402
	[Token(Token = "0x2000962")]
	public class StorageDoorAnimation : MonoBehaviour
	{
		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06004208 RID: 16904 RVA: 0x00011568 File Offset: 0x0000F768
		// (set) Token: 0x06004209 RID: 16905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093D")]
		public bool IsOpen
		{
			[Token(Token = "0x6004208")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004209")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420A")]
		[Address(RVA = "0x8868A0", Offset = "0x8852A0", VA = "0x1808868A0")]
		private void Start()
		{
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420B")]
		[Address(RVA = "0x886680", Offset = "0x885080", VA = "0x180886680")]
		[Button]
		public void Open()
		{
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420C")]
		[Address(RVA = "0x8865D0", Offset = "0x884FD0", VA = "0x1808865D0")]
		[Button]
		public void Close()
		{
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420D")]
		[Address(RVA = "0x8866A0", Offset = "0x8850A0", VA = "0x1808866A0")]
		public void SetIsOpen(bool open)
		{
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420E")]
		[Address(RVA = "0x8865E0", Offset = "0x884FE0", VA = "0x1808865E0")]
		private void DisableItems()
		{
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420F")]
		[Address(RVA = "0x886690", Offset = "0x885090", VA = "0x180886690")]
		public void OverrideState(bool open)
		{
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004210")]
		[Address(RVA = "0x81D8B0", Offset = "0x81C2B0", VA = "0x18081D8B0")]
		public void ResetOverride()
		{
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004211")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public StorageDoorAnimation()
		{
		}

		// Token: 0x04002E2F RID: 11823
		[Token(Token = "0x4002E2F")]
		[FieldOffset(Offset = "0x21")]
		private bool overriddeIsOpen;

		// Token: 0x04002E30 RID: 11824
		[Token(Token = "0x4002E30")]
		[FieldOffset(Offset = "0x22")]
		private bool overrideState;

		// Token: 0x04002E31 RID: 11825
		[Token(Token = "0x4002E31")]
		[FieldOffset(Offset = "0x28")]
		public Transform ItemContainer;

		// Token: 0x04002E32 RID: 11826
		[Token(Token = "0x4002E32")]
		[FieldOffset(Offset = "0x30")]
		[Header("Animations")]
		public Animation[] Anims;

		// Token: 0x04002E33 RID: 11827
		[Token(Token = "0x4002E33")]
		[FieldOffset(Offset = "0x38")]
		public AnimationClip OpenAnim;

		// Token: 0x04002E34 RID: 11828
		[Token(Token = "0x4002E34")]
		[FieldOffset(Offset = "0x40")]
		public AnimationClip CloseAnim;

		// Token: 0x04002E35 RID: 11829
		[Token(Token = "0x4002E35")]
		[FieldOffset(Offset = "0x48")]
		public AudioSourceController OpenSound;

		// Token: 0x04002E36 RID: 11830
		[Token(Token = "0x4002E36")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController CloseSound;
	}
}
