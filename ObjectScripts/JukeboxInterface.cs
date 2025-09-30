using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C70 RID: 3184
	[Token(Token = "0x2000C70")]
	public class JukeboxInterface : MonoBehaviour
	{
		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060055F6 RID: 22006 RVA: 0x00015558 File Offset: 0x00013758
		// (set) Token: 0x060055F7 RID: 22007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD1")]
		public bool IsOpen
		{
			[Token(Token = "0x60055F6")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60055F7")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F8")]
		[Address(RVA = "0x9C5E00", Offset = "0x9C4800", VA = "0x1809C5E00")]
		private void Awake()
		{
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F9")]
		[Address(RVA = "0x9C64C0", Offset = "0x9C4EC0", VA = "0x1809C64C0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FA")]
		[Address(RVA = "0x9C7680", Offset = "0x9C6080", VA = "0x1809C7680")]
		private void UpdateAmbientDisplay()
		{
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FB")]
		[Address(RVA = "0x9C6FD0", Offset = "0x9C59D0", VA = "0x1809C6FD0")]
		private void SetupSongEntries()
		{
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FC")]
		[Address(RVA = "0x9C74B0", Offset = "0x9C5EB0", VA = "0x1809C74B0")]
		public void Start()
		{
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FD")]
		[Address(RVA = "0x9C6570", Offset = "0x9C4F70", VA = "0x1809C6570")]
		private void OnDestroy()
		{
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FE")]
		[Address(RVA = "0x9C6470", Offset = "0x9C4E70", VA = "0x1809C6470")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FF")]
		[Address(RVA = "0x9C6600", Offset = "0x9C5000", VA = "0x1809C6600")]
		public void Open()
		{
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005600")]
		[Address(RVA = "0x9C6180", Offset = "0x9C4B80", VA = "0x1809C6180")]
		public void Close()
		{
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005601")]
		[Address(RVA = "0x9C64D0", Offset = "0x9C4ED0", VA = "0x1809C64D0")]
		private void Hovered()
		{
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005602")]
		[Address(RVA = "0x9C6540", Offset = "0x9C4F40", VA = "0x1809C6540")]
		private void Interacted()
		{
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005603")]
		[Address(RVA = "0x9C6A30", Offset = "0x9C5430", VA = "0x1809C6A30")]
		public void PlayPausePressed()
		{
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005604")]
		[Address(RVA = "0x9C60C0", Offset = "0x9C4AC0", VA = "0x1809C60C0")]
		public void BackPressed()
		{
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005605")]
		[Address(RVA = "0x9C6550", Offset = "0x9C4F50", VA = "0x1809C6550")]
		public void NextPressed()
		{
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005606")]
		[Address(RVA = "0x9C73C0", Offset = "0x9C5DC0", VA = "0x1809C73C0")]
		public void ShufflePressed()
		{
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005607")]
		[Address(RVA = "0x9C6F40", Offset = "0x9C5940", VA = "0x1809C6F40")]
		public void RepeatPressed()
		{
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005608")]
		[Address(RVA = "0x9C7610", Offset = "0x9C6010", VA = "0x1809C7610")]
		public void SyncPressed()
		{
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005609")]
		[Address(RVA = "0x9C73E0", Offset = "0x9C5DE0", VA = "0x1809C73E0")]
		public void SongEntryClicked(RectTransform entry)
		{
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560A")]
		[Address(RVA = "0x9C6AE0", Offset = "0x9C54E0", VA = "0x1809C6AE0")]
		private void RefreshSongEntries()
		{
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560B")]
		[Address(RVA = "0x9C6CD0", Offset = "0x9C56D0", VA = "0x1809C6CD0")]
		private void RefreshUI()
		{
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560C")]
		[Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
		private void RefreshAmbientDisplay()
		{
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560D")]
		[Address(RVA = "0x9C7B30", Offset = "0x9C6530", VA = "0x1809C7B30")]
		public JukeboxInterface()
		{
		}

		// Token: 0x04003FB1 RID: 16305
		[Token(Token = "0x4003FB1")]
		public const float OPEN_TIME = 0.15f;

		// Token: 0x04003FB3 RID: 16307
		[Token(Token = "0x4003FB3")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Jukebox Jukebox;

		// Token: 0x04003FB4 RID: 16308
		[Token(Token = "0x4003FB4")]
		[FieldOffset(Offset = "0x30")]
		public Canvas Canvas;

		// Token: 0x04003FB5 RID: 16309
		[Token(Token = "0x4003FB5")]
		[FieldOffset(Offset = "0x38")]
		public Transform CameraPosition;

		// Token: 0x04003FB6 RID: 16310
		[Token(Token = "0x4003FB6")]
		[FieldOffset(Offset = "0x40")]
		public InteractableObject IntObj;

		// Token: 0x04003FB7 RID: 16311
		[Token(Token = "0x4003FB7")]
		[FieldOffset(Offset = "0x48")]
		public Image PausePlayImage;

		// Token: 0x04003FB8 RID: 16312
		[Token(Token = "0x4003FB8")]
		[FieldOffset(Offset = "0x50")]
		public Button ShuffleButton;

		// Token: 0x04003FB9 RID: 16313
		[Token(Token = "0x4003FB9")]
		[FieldOffset(Offset = "0x58")]
		public Button RepeatButton;

		// Token: 0x04003FBA RID: 16314
		[Token(Token = "0x4003FBA")]
		[FieldOffset(Offset = "0x60")]
		public Button SyncButton;

		// Token: 0x04003FBB RID: 16315
		[Token(Token = "0x4003FBB")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform EntryContainer;

		// Token: 0x04003FBC RID: 16316
		[Token(Token = "0x4003FBC")]
		[FieldOffset(Offset = "0x70")]
		public GameObject AmbientDisplayContainer;

		// Token: 0x04003FBD RID: 16317
		[Token(Token = "0x4003FBD")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshPro AmbientDisplaySongLabel;

		// Token: 0x04003FBE RID: 16318
		[Token(Token = "0x4003FBE")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshPro AmbientDisplayTimeLabel;

		// Token: 0x04003FBF RID: 16319
		[Token(Token = "0x4003FBF")]
		[FieldOffset(Offset = "0x88")]
		[Header("Settings")]
		public Sprite PlaySprite;

		// Token: 0x04003FC0 RID: 16320
		[Token(Token = "0x4003FC0")]
		[FieldOffset(Offset = "0x90")]
		public Sprite PauseSprite;

		// Token: 0x04003FC1 RID: 16321
		[Token(Token = "0x4003FC1")]
		[FieldOffset(Offset = "0x98")]
		public Sprite SongEntryPlaySprite;

		// Token: 0x04003FC2 RID: 16322
		[Token(Token = "0x4003FC2")]
		[FieldOffset(Offset = "0xA0")]
		public Sprite SongEntryPauseSprite;

		// Token: 0x04003FC3 RID: 16323
		[Token(Token = "0x4003FC3")]
		[FieldOffset(Offset = "0xA8")]
		public Sprite RepeatModeSprite_None;

		// Token: 0x04003FC4 RID: 16324
		[Token(Token = "0x4003FC4")]
		[FieldOffset(Offset = "0xB0")]
		public Sprite RepeatModeSprite_Track;

		// Token: 0x04003FC5 RID: 16325
		[Token(Token = "0x4003FC5")]
		[FieldOffset(Offset = "0xB8")]
		public Sprite RepeatModeSprite_Queue;

		// Token: 0x04003FC6 RID: 16326
		[Token(Token = "0x4003FC6")]
		[FieldOffset(Offset = "0xC0")]
		public Color DeselectedColor;

		// Token: 0x04003FC7 RID: 16327
		[Token(Token = "0x4003FC7")]
		[FieldOffset(Offset = "0xD0")]
		public Color SelectedColor;

		// Token: 0x04003FC8 RID: 16328
		[Token(Token = "0x4003FC8")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject SongEntryPrefab;

		// Token: 0x04003FC9 RID: 16329
		[Token(Token = "0x4003FC9")]
		[FieldOffset(Offset = "0xE8")]
		private List<RectTransform> songEntries;
	}
}
