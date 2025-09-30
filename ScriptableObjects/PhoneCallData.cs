using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ScriptableObjects
{
	// Token: 0x0200081A RID: 2074
	[Token(Token = "0x200081A")]
	[CreateAssetMenu(fileName = "PhoneCallData", menuName = "ScriptableObjects/PhoneCallData", order = 1)]
	[Serializable]
	public class PhoneCallData : ScriptableObject
	{
		// Token: 0x0600392A RID: 14634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392A")]
		[Address(RVA = "0x5D52A0", Offset = "0x5D3CA0", VA = "0x1805D52A0")]
		public void Completed()
		{
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392B")]
		[Address(RVA = "0x599570", Offset = "0x597F70", VA = "0x180599570")]
		public PhoneCallData()
		{
		}

		// Token: 0x040027A8 RID: 10152
		[Token(Token = "0x40027A8")]
		[FieldOffset(Offset = "0x18")]
		public CallerID CallerID;

		// Token: 0x040027A9 RID: 10153
		[Token(Token = "0x40027A9")]
		[FieldOffset(Offset = "0x20")]
		public PhoneCallData.Stage[] Stages;

		// Token: 0x040027AA RID: 10154
		[Token(Token = "0x40027AA")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onCallCompleted;

		// Token: 0x0200081B RID: 2075
		[Token(Token = "0x200081B")]
		[Serializable]
		public class Stage
		{
			// Token: 0x0600392C RID: 14636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600392C")]
			[Address(RVA = "0x80AF60", Offset = "0x809960", VA = "0x18080AF60")]
			public void OnStageStart()
			{
			}

			// Token: 0x0600392D RID: 14637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600392D")]
			[Address(RVA = "0x80AED0", Offset = "0x8098D0", VA = "0x18080AED0")]
			public void OnStageEnd()
			{
			}

			// Token: 0x0600392E RID: 14638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600392E")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Stage()
			{
			}

			// Token: 0x040027AB RID: 10155
			[Token(Token = "0x40027AB")]
			[FieldOffset(Offset = "0x10")]
			[TextArea(3, 10)]
			public string Text;

			// Token: 0x040027AC RID: 10156
			[Token(Token = "0x40027AC")]
			[FieldOffset(Offset = "0x18")]
			public SystemTrigger[] OnStartTriggers;

			// Token: 0x040027AD RID: 10157
			[Token(Token = "0x40027AD")]
			[FieldOffset(Offset = "0x20")]
			public SystemTrigger[] OnDoneTriggers;
		}
	}
}
