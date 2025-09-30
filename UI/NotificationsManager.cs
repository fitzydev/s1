using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000AC9 RID: 2761
	[Token(Token = "0x2000AC9")]
	public class NotificationsManager : Singleton<NotificationsManager>
	{
		// Token: 0x06004AF6 RID: 19190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void Update()
		{
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x921AF0", Offset = "0x9204F0", VA = "0x180921AF0")]
		public void SendNotification(string title, string subtitle, Sprite icon, float duration = 5f, bool playSound = true)
		{
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x922060", Offset = "0x920A60", VA = "0x180922060")]
		public NotificationsManager()
		{
		}

		// Token: 0x040035E8 RID: 13800
		[Token(Token = "0x40035E8")]
		public const int MAX_NOTIFICATIONS = 6;

		// Token: 0x040035E9 RID: 13801
		[Token(Token = "0x40035E9")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform EntryContainer;

		// Token: 0x040035EA RID: 13802
		[Token(Token = "0x40035EA")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController Sound;

		// Token: 0x040035EB RID: 13803
		[Token(Token = "0x40035EB")]
		[FieldOffset(Offset = "0x38")]
		[Header("Prefab")]
		public GameObject NotificationPrefab;

		// Token: 0x040035EC RID: 13804
		[Token(Token = "0x40035EC")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<RectTransform, Coroutine> coroutines;

		// Token: 0x040035ED RID: 13805
		[Token(Token = "0x40035ED")]
		[FieldOffset(Offset = "0x48")]
		private List<RectTransform> entries;
	}
}
