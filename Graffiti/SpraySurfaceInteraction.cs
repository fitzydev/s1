using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Graffiti
{
	// Token: 0x0200058E RID: 1422
	[Token(Token = "0x200058E")]
	[RequireComponent(typeof(SpraySurface))]
	public class SpraySurfaceInteraction : MonoBehaviour
	{
		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x0000A710 File Offset: 0x00008910
		// (set) Token: 0x06002040 RID: 8256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058A")]
		public bool IsOpen
		{
			[Token(Token = "0x600203F")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002040")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x1700058B")]
		private bool confirmationPanelOpen
		{
			[Token(Token = "0x6002041")]
			[Address(RVA = "0x67F840", Offset = "0x67E240", VA = "0x18067F840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002042")]
		[Address(RVA = "0x67BBF0", Offset = "0x67A5F0", VA = "0x18067BBF0")]
		private void Awake()
		{
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002043")]
		[Address(RVA = "0x67F300", Offset = "0x67DD00", VA = "0x18067F300")]
		private void Start()
		{
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002044")]
		[Address(RVA = "0x67EA70", Offset = "0x67D470", VA = "0x18067EA70")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002045")]
		[Address(RVA = "0x67E0E0", Offset = "0x67CAE0", VA = "0x18067E0E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002046")]
		[Address(RVA = "0x67E260", Offset = "0x67CC60", VA = "0x18067E260")]
		private void OnValidate()
		{
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002047")]
		[Address(RVA = "0x67ECE0", Offset = "0x67D6E0", VA = "0x18067ECE0")]
		private void ResizeCanvas()
		{
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002048")]
		[Address(RVA = "0x67F600", Offset = "0x67E000", VA = "0x18067F600")]
		private void Update()
		{
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002049")]
		[Address(RVA = "0x67F4B0", Offset = "0x67DEB0", VA = "0x18067F4B0")]
		private void UpdateCursor()
		{
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x67CFF0", Offset = "0x67B9F0", VA = "0x18067CFF0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x67F270", Offset = "0x67DC70", VA = "0x18067F270")]
		private void StartStroke()
		{
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204C")]
		[Address(RVA = "0x67C8B0", Offset = "0x67B2B0", VA = "0x18067C8B0")]
		private void EndStroke(bool stopSpraySound)
		{
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x600204D")]
		[Address(RVA = "0x67D670", Offset = "0x67C070", VA = "0x18067D670")]
		private bool GetCursorPositionOnSurface(out ushort pixelX, out ushort pixelY)
		{
			return default(bool);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0000A758 File Offset: 0x00008958
		[Token(Token = "0x600204E")]
		[Address(RVA = "0x67DB20", Offset = "0x67C520", VA = "0x18067DB20")]
		private Ray GetCursorRay()
		{
			return default(Ray);
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204F")]
		[Address(RVA = "0x67DBF0", Offset = "0x67C5F0", VA = "0x18067DBF0")]
		private void Hovered()
		{
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002050")]
		[Address(RVA = "0x67DD20", Offset = "0x67C720", VA = "0x18067DD20")]
		private void Interacted()
		{
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002051")]
		[Address(RVA = "0x67F6A0", Offset = "0x67E0A0", VA = "0x18067F6A0")]
		private void UseGraffitiCleaner()
		{
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002052")]
		[Address(RVA = "0x67CF10", Offset = "0x67B910", VA = "0x18067CF10")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002053")]
		[Address(RVA = "0x67E270", Offset = "0x67CC70", VA = "0x18067E270")]
		private void Open()
		{
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002054")]
		[Address(RVA = "0x67BE20", Offset = "0x67A820", VA = "0x18067BE20")]
		private void Close()
		{
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002055")]
		[Address(RVA = "0x67F100", Offset = "0x67DB00", VA = "0x18067F100")]
		private void Reward()
		{
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002056")]
		[Address(RVA = "0x67CE70", Offset = "0x67B870", VA = "0x18067CE70")]
		private void EquippedSlotChanged(int equippedSlotIndex)
		{
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002057")]
		[Address(RVA = "0x67F260", Offset = "0x67DC60", VA = "0x18067F260")]
		private void SetColor(ESprayColor color)
		{
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002058")]
		[Address(RVA = "0x67BD80", Offset = "0x67A780", VA = "0x18067BD80")]
		private void Clear()
		{
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x6002059")]
		[Address(RVA = "0x67DFE0", Offset = "0x67C9E0", VA = "0x18067DFE0")]
		private static bool IsSprayCanEquipped()
		{
			return default(bool);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x67DEE0", Offset = "0x67C8E0", VA = "0x18067DEE0")]
		private static bool IsGraffitiCleanerEquipped()
		{
			return default(bool);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205B")]
		[Address(RVA = "0x67F7C0", Offset = "0x67E1C0", VA = "0x18067F7C0")]
		public SpraySurfaceInteraction()
		{
		}

		// Token: 0x04001A4E RID: 6734
		[Token(Token = "0x4001A4E")]
		public const float CAMERA_MOVE_TIME = 0.15f;

		// Token: 0x04001A4F RID: 6735
		[Token(Token = "0x4001A4F")]
		public const int MAX_PIXELS_BEFORE_NEW_STROKE = 1000;

		// Token: 0x04001A50 RID: 6736
		[Token(Token = "0x4001A50")]
		public const int MANHATTAN_DISTANCE_BETWEEN_PAINTED_PIXELS = 3;

		// Token: 0x04001A51 RID: 6737
		[Token(Token = "0x4001A51")]
		public const int XP_GAIN = 50;

		// Token: 0x04001A52 RID: 6738
		[Token(Token = "0x4001A52")]
		public const float CARTEL_INFLUENCE_REDUCTION = 0.05f;

		// Token: 0x04001A53 RID: 6739
		[Token(Token = "0x4001A53")]
		public const int PAINTED_PIXEL_LIMIT = 25000;

		// Token: 0x04001A55 RID: 6741
		[Token(Token = "0x4001A55")]
		[FieldOffset(Offset = "0x28")]
		public SpraySurface SpraySurface;

		// Token: 0x04001A56 RID: 6742
		[Token(Token = "0x4001A56")]
		[FieldOffset(Offset = "0x30")]
		public InteractableObject IntObj;

		// Token: 0x04001A57 RID: 6743
		[Token(Token = "0x4001A57")]
		[FieldOffset(Offset = "0x38")]
		public Transform CameraPosition;

		// Token: 0x04001A58 RID: 6744
		[Token(Token = "0x4001A58")]
		[FieldOffset(Offset = "0x40")]
		public Canvas Canvas;

		// Token: 0x04001A59 RID: 6745
		[Token(Token = "0x4001A59")]
		[FieldOffset(Offset = "0x48")]
		public Image SprayImg;

		// Token: 0x04001A5A RID: 6746
		[Token(Token = "0x4001A5A")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController SpraySound;

		// Token: 0x04001A5B RID: 6747
		[Token(Token = "0x4001A5B")]
		[FieldOffset(Offset = "0x58")]
		public AudioSourceController CleanSound;

		// Token: 0x04001A5C RID: 6748
		[Token(Token = "0x4001A5C")]
		[FieldOffset(Offset = "0x60")]
		private ESprayColor selectedColor;

		// Token: 0x04001A5D RID: 6749
		[Token(Token = "0x4001A5D")]
		[FieldOffset(Offset = "0x62")]
		private UShort2 lastPaintedPixelCoord;

		// Token: 0x04001A5E RID: 6750
		[Token(Token = "0x4001A5E")]
		[FieldOffset(Offset = "0x66")]
		private bool paintedLastFrame;

		// Token: 0x04001A5F RID: 6751
		[Token(Token = "0x4001A5F")]
		[FieldOffset(Offset = "0x68")]
		private List<UShort2> currentStrokePixels;

		// Token: 0x04001A60 RID: 6752
		[Token(Token = "0x4001A60")]
		[FieldOffset(Offset = "0x70")]
		private bool isPaintingStroke;

		// Token: 0x04001A61 RID: 6753
		[Token(Token = "0x4001A61")]
		[FieldOffset(Offset = "0x74")]
		private float timeSinceStrokeStart;
	}
}
