using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Audio
{
	// Token: 0x02000844 RID: 2116
	[Token(Token = "0x2000844")]
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(EventTrigger))]
	[RequireComponent(typeof(AudioSourceController))]
	public class ButtonSound : MonoBehaviour
	{
		// Token: 0x06003A13 RID: 14867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A13")]
		[Address(RVA = "0x80CEA0", Offset = "0x80B8A0", VA = "0x18080CEA0")]
		public void Awake()
		{
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A14")]
		[Address(RVA = "0x80D0F0", Offset = "0x80BAF0", VA = "0x18080D0F0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A15")]
		[Address(RVA = "0x80CCF0", Offset = "0x80B6F0", VA = "0x18080CCF0")]
		public void AddEventTrigger(EventTrigger eventTrigger, EventTriggerType eventTriggerType, Action action)
		{
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A16")]
		[Address(RVA = "0x80D060", Offset = "0x80BA60", VA = "0x18080D060", Slot = "4")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A17")]
		[Address(RVA = "0x80CFE0", Offset = "0x80B9E0", VA = "0x18080CFE0", Slot = "5")]
		protected virtual void Clicked()
		{
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A18")]
		[Address(RVA = "0x80D1D0", Offset = "0x80BBD0", VA = "0x18080D1D0")]
		public ButtonSound()
		{
		}

		// Token: 0x0400286D RID: 10349
		[Token(Token = "0x400286D")]
		[FieldOffset(Offset = "0x20")]
		public AudioSourceController AudioSource;

		// Token: 0x0400286E RID: 10350
		[Token(Token = "0x400286E")]
		[FieldOffset(Offset = "0x28")]
		public EventTrigger EventTrigger;

		// Token: 0x0400286F RID: 10351
		[Token(Token = "0x400286F")]
		[FieldOffset(Offset = "0x30")]
		public bool PlaySoundOnClickStart;

		// Token: 0x04002870 RID: 10352
		[Token(Token = "0x4002870")]
		[FieldOffset(Offset = "0x38")]
		[Header("Clips")]
		public AudioClip HoverClip;

		// Token: 0x04002871 RID: 10353
		[Token(Token = "0x4002871")]
		[FieldOffset(Offset = "0x40")]
		public float HoverSoundVolume;

		// Token: 0x04002872 RID: 10354
		[Token(Token = "0x4002872")]
		[FieldOffset(Offset = "0x48")]
		public AudioClip ClickClip;

		// Token: 0x04002873 RID: 10355
		[Token(Token = "0x4002873")]
		[FieldOffset(Offset = "0x50")]
		public float ClickSoundVolume;

		// Token: 0x04002874 RID: 10356
		[Token(Token = "0x4002874")]
		[FieldOffset(Offset = "0x58")]
		private Button Button;
	}
}
