using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EPOOutline;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Construction.Features;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.ConstructableScripts
{
	// Token: 0x020009DA RID: 2522
	[Token(Token = "0x20009DA")]
	public class Constructable : NetworkBehaviour
	{
		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x00012138 File Offset: 0x00010338
		[Token(Token = "0x17000994")]
		public bool IsStatic
		{
			[Token(Token = "0x60044E4")]
			[Address(RVA = "0x542F10", Offset = "0x541910", VA = "0x180542F10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000995")]
		public string ConstructableName
		{
			[Token(Token = "0x60044E5")]
			[Address(RVA = "0x62FD10", Offset = "0x62E710", VA = "0x18062FD10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000996")]
		public string ConstructableDescription
		{
			[Token(Token = "0x60044E6")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000997")]
		public string ConstructableAssetPath
		{
			[Token(Token = "0x60044E7")]
			[Address(RVA = "0x672D40", Offset = "0x671740", VA = "0x180672D40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000998")]
		public string PrefabID
		{
			[Token(Token = "0x60044E8")]
			[Address(RVA = "0x672D50", Offset = "0x671750", VA = "0x180672D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060044E9 RID: 17641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000999")]
		public Sprite ConstructableIcon
		{
			[Token(Token = "0x60044E9")]
			[Address(RVA = "0x66EEE0", Offset = "0x66D8E0", VA = "0x18066EEE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099A")]
		public GameObject _constructionHandler_Asset
		{
			[Token(Token = "0x60044EA")]
			[Address(RVA = "0x63D950", Offset = "0x63C350", VA = "0x18063D950")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x00012150 File Offset: 0x00010350
		// (set) Token: 0x060044EC RID: 17644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700099B")]
		public bool isVisible
		{
			[Token(Token = "0x60044EB")]
			[Address(RVA = "0x659820", Offset = "0x658220", VA = "0x180659820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60044EC")]
			[Address(RVA = "0x659A20", Offset = "0x658420", VA = "0x180659A20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044ED")]
		[Address(RVA = "0x8B2080", Offset = "0x8B0A80", VA = "0x1808B2080", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00012168 File Offset: 0x00010368
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0x8B2100", Offset = "0x8B0B00", VA = "0x1808B2100", Slot = "20")]
		public virtual bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x00012180 File Offset: 0x00010380
		[Token(Token = "0x60044F0")]
		[Address(RVA = "0x8B20D0", Offset = "0x8B0AD0", VA = "0x1808B20D0", Slot = "21")]
		public virtual bool CanBeDestroyed()
		{
			return default(bool);
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F1")]
		[Address(RVA = "0x8B2290", Offset = "0x8B0C90", VA = "0x1808B2290", Slot = "22")]
		public virtual void DestroyConstructable(bool callOnServer = true)
		{
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F2")]
		[Address(RVA = "0x8B2420", Offset = "0x8B0E20", VA = "0x1808B2420")]
		[ServerRpc(RequireOwnership = false)]
		private void Destroy_Networked()
		{
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0x8B2170", Offset = "0x8B0B70", VA = "0x1808B2170")]
		[ObserversRpc]
		private void DestroyConstructableWrapper()
		{
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x00012198 File Offset: 0x00010398
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "23")]
		public virtual bool CanBeModified()
		{
			return default(bool);
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x000121B0 File Offset: 0x000103B0
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "24")]
		public virtual bool CanBePickedUpByHand()
		{
			return default(bool);
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x000121C8 File Offset: 0x000103C8
		[Token(Token = "0x60044F6")]
		[Address(RVA = "0x8B2160", Offset = "0x8B0B60", VA = "0x1808B2160", Slot = "25")]
		public virtual bool CanBeSelected()
		{
			return default(bool);
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F7")]
		[Address(RVA = "0x8B25B0", Offset = "0x8B0FB0", VA = "0x1808B25B0", Slot = "26")]
		public virtual string GetBuildableVersionAssetPath()
		{
			return null;
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F8")]
		[Address(RVA = "0x8B71F0", Offset = "0x8B5BF0", VA = "0x1808B71F0")]
		public void ShowOutline(BuildableItem.EOutlineColor color)
		{
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F9")]
		[Address(RVA = "0x8B67E0", Offset = "0x8B51E0", VA = "0x1808B67E0")]
		public void HideOutline()
		{
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x000121E0 File Offset: 0x000103E0
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0x7247F0", Offset = "0x7231F0", VA = "0x1807247F0", Slot = "27")]
		public virtual Vector3 GetCosmeticCenter()
		{
			return default(Vector3);
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x000121F8 File Offset: 0x000103F8
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x8B2530", Offset = "0x8B0F30", VA = "0x1808B2530")]
		public float GetBoundingBoxLongestSide()
		{
			return 0f;
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FC")]
		[Address(RVA = "0x8B6F40", Offset = "0x8B5940", VA = "0x1808B6F40", Slot = "28")]
		public virtual void SetInvisible()
		{
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FD")]
		[Address(RVA = "0x8B6940", Offset = "0x8B5340", VA = "0x1808B6940", Slot = "29")]
		public virtual void RestoreVisibility()
		{
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FE")]
		[Address(RVA = "0x8B6FB0", Offset = "0x8B59B0", VA = "0x1808B6FB0")]
		public void SetLayerRecursively(GameObject go, int layerNumber)
		{
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FF")]
		[Address(RVA = "0x8B76A0", Offset = "0x8B60A0", VA = "0x1808B76A0")]
		public Constructable()
		{
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004500")]
		[Address(RVA = "0x8B6860", Offset = "0x8B5260", VA = "0x1808B6860", Slot = "30")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004501")]
		[Address(RVA = "0x7DFF00", Offset = "0x7DE900", VA = "0x1807DFF00", Slot = "31")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004502")]
		[Address(RVA = "0x8434B0", Offset = "0x841EB0", VA = "0x1808434B0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004503")]
		[Address(RVA = "0x8B2420", Offset = "0x8B0E20", VA = "0x1808B2420")]
		private void RpcWriter___Server_Destroy_Networked_2166136261()
		{
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004504")]
		[Address(RVA = "0x8B6B60", Offset = "0x8B5560", VA = "0x1808B6B60")]
		private void RpcLogic___Destroy_Networked_2166136261()
		{
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004505")]
		[Address(RVA = "0x8B6D90", Offset = "0x8B5790", VA = "0x1808B6D90")]
		private void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004506")]
		[Address(RVA = "0x8B2170", Offset = "0x8B0B70", VA = "0x1808B2170")]
		private void RpcWriter___Observers_DestroyConstructableWrapper_2166136261()
		{
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004507")]
		[Address(RVA = "0x8B6AE0", Offset = "0x8B54E0", VA = "0x1808B6AE0")]
		private void RpcLogic___DestroyConstructableWrapper_2166136261()
		{
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004508")]
		[Address(RVA = "0x8B6D00", Offset = "0x8B5700", VA = "0x1808B6D00")]
		private void RpcReader___Observers_DestroyConstructableWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004509")]
		[Address(RVA = "0x8B1F20", Offset = "0x8B0920", VA = "0x1808B1F20", Slot = "32")]
		protected virtual void Awake_UserLogic_ScheduleOne.ConstructableScripts.Constructable_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003061 RID: 12385
		[Token(Token = "0x4003061")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Header("Basic settings")]
		protected bool isStatic;

		// Token: 0x04003062 RID: 12386
		[Token(Token = "0x4003062")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		protected string constructableName;

		// Token: 0x04003063 RID: 12387
		[Token(Token = "0x4003063")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected string constructableDescription;

		// Token: 0x04003064 RID: 12388
		[Token(Token = "0x4003064")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected string constructableAssetPath;

		// Token: 0x04003065 RID: 12389
		[Token(Token = "0x4003065")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		protected string ID;

		// Token: 0x04003066 RID: 12390
		[Token(Token = "0x4003066")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		protected Sprite constructableIcon;

		// Token: 0x04003067 RID: 12391
		[Token(Token = "0x4003067")]
		[FieldOffset(Offset = "0x148")]
		[Header("Bounds settings")]
		public BoxCollider boundingBox;

		// Token: 0x04003068 RID: 12392
		[Token(Token = "0x4003068")]
		[FieldOffset(Offset = "0x150")]
		[Header("Construction Handler")]
		[SerializeField]
		protected GameObject constructionHandler_Asset;

		// Token: 0x04003069 RID: 12393
		[Token(Token = "0x4003069")]
		[FieldOffset(Offset = "0x158")]
		[Header("Outline settings")]
		[SerializeField]
		protected List<GameObject> outlineRenderers;

		// Token: 0x0400306A RID: 12394
		[Token(Token = "0x400306A")]
		[FieldOffset(Offset = "0x160")]
		protected Outlinable outlineEffect;

		// Token: 0x0400306B RID: 12395
		[Token(Token = "0x400306B")]
		[FieldOffset(Offset = "0x168")]
		[Header("Features")]
		public List<Feature> features;

		// Token: 0x0400306D RID: 12397
		[Token(Token = "0x400306D")]
		[FieldOffset(Offset = "0x171")]
		private bool isDestroyed;

		// Token: 0x0400306E RID: 12398
		[Token(Token = "0x400306E")]
		[FieldOffset(Offset = "0x178")]
		private Dictionary<Transform, LayerMask> originalLayers;

		// Token: 0x0400306F RID: 12399
		[Token(Token = "0x400306F")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted;

		// Token: 0x04003070 RID: 12400
		[Token(Token = "0x4003070")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted;
	}
}
