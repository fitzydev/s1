using System;
using System.Collections.Generic;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Cutscenes
{
	// Token: 0x02000790 RID: 1936
	[Token(Token = "0x2000790")]
	public class CutsceneManager : Singleton<CutsceneManager>
	{
		// Token: 0x06003440 RID: 13376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003440")]
		[Address(RVA = "0x79E920", Offset = "0x79D320", VA = "0x18079E920")]
		[Button]
		private void RunCutscene()
		{
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003441")]
		[Address(RVA = "0x79E770", Offset = "0x79D170", VA = "0x18079E770")]
		public void Play(string name)
		{
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003442")]
		[Address(RVA = "0x79E6C0", Offset = "0x79D0C0", VA = "0x18079E6C0")]
		private void Ended()
		{
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003443")]
		[Address(RVA = "0x79EAD0", Offset = "0x79D4D0", VA = "0x18079EAD0")]
		public CutsceneManager()
		{
		}

		// Token: 0x0400245A RID: 9306
		[Token(Token = "0x400245A")]
		[FieldOffset(Offset = "0x28")]
		public List<Cutscene> Cutscenes;

		// Token: 0x0400245B RID: 9307
		[Token(Token = "0x400245B")]
		[FieldOffset(Offset = "0x30")]
		[Header("Run cutscene by name")]
		[SerializeField]
		private string cutsceneName;

		// Token: 0x0400245C RID: 9308
		[Token(Token = "0x400245C")]
		[FieldOffset(Offset = "0x38")]
		private Cutscene playingCutscene;
	}
}
