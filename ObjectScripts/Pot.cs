using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Growing;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Lighting;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C7A RID: 3194
	[Token(Token = "0x2000C7A")]
	public class Pot : GridItem, IUsable, IConfigurable, ITransitEntity
	{
		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06005673 RID: 22131 RVA: 0x000156A8 File Offset: 0x000138A8
		// (set) Token: 0x06005674 RID: 22132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BDD")]
		public float SoilLevel
		{
			[Token(Token = "0x6005673")]
			[Address(RVA = "0x80F540", Offset = "0x80DF40", VA = "0x18080F540")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005674")]
			[Address(RVA = "0x9D7600", Offset = "0x9D6000", VA = "0x1809D7600")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06005675 RID: 22133 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005676 RID: 22134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BDE")]
		public string SoilID
		{
			[Token(Token = "0x6005675")]
			[Address(RVA = "0x68D390", Offset = "0x68BD90", VA = "0x18068D390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005676")]
			[Address(RVA = "0x9D7560", Offset = "0x9D5F60", VA = "0x1809D7560")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06005677 RID: 22135 RVA: 0x000156C0 File Offset: 0x000138C0
		// (set) Token: 0x06005678 RID: 22136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BDF")]
		public int RemainingSoilUses
		{
			[Token(Token = "0x6005677")]
			[Address(RVA = "0x9D73E0", Offset = "0x9D5DE0", VA = "0x1809D73E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005678")]
			[Address(RVA = "0x9D74D0", Offset = "0x9D5ED0", VA = "0x1809D74D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06005679 RID: 22137 RVA: 0x000156D8 File Offset: 0x000138D8
		// (set) Token: 0x0600567A RID: 22138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BE0")]
		public float WaterLevel
		{
			[Token(Token = "0x6005679")]
			[Address(RVA = "0x9D73F0", Offset = "0x9D5DF0", VA = "0x1809D73F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600567A")]
			[Address(RVA = "0x9D7690", Offset = "0x9D6090", VA = "0x1809D7690")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600567B RID: 22139 RVA: 0x000156F0 File Offset: 0x000138F0
		[Token(Token = "0x17000BE1")]
		public float NormalizedWaterLevel
		{
			[Token(Token = "0x600567B")]
			[Address(RVA = "0x9D73B0", Offset = "0x9D5DB0", VA = "0x1809D73B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600567C RID: 22140 RVA: 0x00015708 File Offset: 0x00013908
		[Token(Token = "0x17000BE2")]
		public bool IsFilledWithSoil
		{
			[Token(Token = "0x600567C")]
			[Address(RVA = "0x9D7360", Offset = "0x9D5D60", VA = "0x1809D7360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600567D RID: 22141 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600567E RID: 22142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BE3")]
		public Plant Plant
		{
			[Token(Token = "0x600567D")]
			[Address(RVA = "0x9D73D0", Offset = "0x9D5DD0", VA = "0x1809D73D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600567E")]
			[Address(RVA = "0x9D7410", Offset = "0x9D5E10", VA = "0x1809D7410")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600567F RID: 22143 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005680 RID: 22144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BE4")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x600567F")]
			[Address(RVA = "0x689F00", Offset = "0x688900", VA = "0x180689F00", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005680")]
			[Address(RVA = "0x9D2A80", Offset = "0x9D1480", VA = "0x1809D2A80", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06005681 RID: 22145 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005682 RID: 22146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BE5")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6005681")]
			[Address(RVA = "0x689EC0", Offset = "0x6888C0", VA = "0x180689EC0", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005682")]
			[Address(RVA = "0x9D7430", Offset = "0x9D5E30", VA = "0x1809D7430", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06005683 RID: 22147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE6")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6005683")]
			[Address(RVA = "0x6D0280", Offset = "0x6CEC80", VA = "0x1806D0280", Slot = "78")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06005684 RID: 22148 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005685 RID: 22149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BE7")]
		protected PotConfiguration potConfiguration
		{
			[Token(Token = "0x6005684")]
			[Address(RVA = "0x6D0280", Offset = "0x6CEC80", VA = "0x1806D0280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005685")]
			[Address(RVA = "0x6D02B0", Offset = "0x6CECB0", VA = "0x1806D02B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06005686 RID: 22150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE8")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6005686")]
			[Address(RVA = "0x62FC90", Offset = "0x62E690", VA = "0x18062FC90", Slot = "79")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06005687 RID: 22151 RVA: 0x00015720 File Offset: 0x00013920
		[Token(Token = "0x17000BE9")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6005687")]
			[Address(RVA = "0x4AAD70", Offset = "0x4A9770", VA = "0x1804AAD70", Slot = "80")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06005688 RID: 22152 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005689 RID: 22153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BEA")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6005688")]
			[Address(RVA = "0x68D3D0", Offset = "0x68BDD0", VA = "0x18068D3D0", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005689")]
			[Address(RVA = "0x6D0290", Offset = "0x6CEC90", VA = "0x1806D0290", Slot = "82")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x0600568A RID: 22154 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600568B RID: 22155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BEB")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x600568A")]
			[Address(RVA = "0x68D3B0", Offset = "0x68BDB0", VA = "0x18068D3B0", Slot = "83")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600568B")]
			[Address(RVA = "0x9D28D0", Offset = "0x9D12D0", VA = "0x1809D28D0", Slot = "84")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600568C RID: 22156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600568C")]
		[Address(RVA = "0x9D5570", Offset = "0x9D3F70", VA = "0x1809D5570", Slot = "98")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600568D RID: 22157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEC")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x600568D")]
			[Address(RVA = "0x62FE10", Offset = "0x62E810", VA = "0x18062FE10", Slot = "86")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600568E RID: 22158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BED")]
		public Transform Transform
		{
			[Token(Token = "0x600568E")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600568F RID: 22159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEE")]
		public Transform UIPoint
		{
			[Token(Token = "0x600568F")]
			[Address(RVA = "0x716B70", Offset = "0x715570", VA = "0x180716B70", Slot = "88")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06005690 RID: 22160 RVA: 0x00015738 File Offset: 0x00013938
		[Token(Token = "0x17000BEF")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6005690")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06005691 RID: 22161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF0")]
		public string Name
		{
			[Token(Token = "0x6005691")]
			[Address(RVA = "0x9D7380", Offset = "0x9D5D80", VA = "0x1809D7380", Slot = "100")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06005692 RID: 22162 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005693 RID: 22163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF1")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6005692")]
			[Address(RVA = "0x68D3E0", Offset = "0x68BDE0", VA = "0x18068D3E0", Slot = "101")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005693")]
			[Address(RVA = "0x68D3F0", Offset = "0x68BDF0", VA = "0x18068D3F0", Slot = "102")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06005694 RID: 22164 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005695 RID: 22165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF2")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6005694")]
			[Address(RVA = "0x689F10", Offset = "0x688910", VA = "0x180689F10", Slot = "103")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005695")]
			[Address(RVA = "0x68F6B0", Offset = "0x68E0B0", VA = "0x18068F6B0", Slot = "104")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06005696 RID: 22166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF3")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6005696")]
			[Address(RVA = "0x716B70", Offset = "0x715570", VA = "0x180716B70", Slot = "105")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06005697 RID: 22167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF4")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x6005697")]
			[Address(RVA = "0x62FE00", Offset = "0x62E800", VA = "0x18062FE00", Slot = "106")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06005698 RID: 22168 RVA: 0x00015750 File Offset: 0x00013950
		[Token(Token = "0x17000BF5")]
		public bool Selectable
		{
			[Token(Token = "0x6005698")]
			[Address(RVA = "0x7E29C0", Offset = "0x7E13C0", VA = "0x1807E29C0", Slot = "107")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06005699 RID: 22169 RVA: 0x00015768 File Offset: 0x00013968
		// (set) Token: 0x0600569A RID: 22170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF6")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6005699")]
			[Address(RVA = "0x9D7350", Offset = "0x9D5D50", VA = "0x1809D7350", Slot = "108")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600569A")]
			[Address(RVA = "0x9D7400", Offset = "0x9D5E00", VA = "0x1809D7400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569B")]
		[Address(RVA = "0x9CDB90", Offset = "0x9CC590", VA = "0x1809CDB90", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569C")]
		[Address(RVA = "0x9D61F0", Offset = "0x9D4BF0", VA = "0x1809D61F0", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569D")]
		[Address(RVA = "0x9D06B0", Offset = "0x9CF0B0", VA = "0x1809D06B0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569E")]
		[Address(RVA = "0x9D5120", Offset = "0x9D3B20", VA = "0x1809D5120", Slot = "99")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569F")]
		[Address(RVA = "0x9CF180", Offset = "0x9CDB80", VA = "0x1809CF180", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A0")]
		[Address(RVA = "0x9CE250", Offset = "0x9CCC50", VA = "0x1809CE250", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A1")]
		[Address(RVA = "0x9CF610", Offset = "0x9CE010", VA = "0x1809CF610", Slot = "122")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A2")]
		[Address(RVA = "0x9D6640", Offset = "0x9D5040", VA = "0x1809D6640")]
		protected void UpdateCanvas()
		{
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A3")]
		[Address(RVA = "0x9D05C0", Offset = "0x9CEFC0", VA = "0x1809D05C0")]
		private void OnMinPass()
		{
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A4")]
		[Address(RVA = "0x9D6370", Offset = "0x9D4D70", VA = "0x1809D6370")]
		private void TimeSkipped(int minsSkippped)
		{
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A5")]
		[Address(RVA = "0x9CDFA0", Offset = "0x9CC9A0", VA = "0x1809CDFA0")]
		public void ConfigureInteraction(string message, InteractableObject.EInteractableState state, bool useHighLabelPos = false)
		{
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A6")]
		[Address(RVA = "0x9D10B0", Offset = "0x9CFAB0", VA = "0x1809D10B0")]
		public void PositionCameraContainer()
		{
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A7")]
		[Address(RVA = "0x9D5D20", Offset = "0x9D4720", VA = "0x1809D5D20", Slot = "76")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A8")]
		[Address(RVA = "0x9D5BF0", Offset = "0x9D45F0", VA = "0x1809D5BF0", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A9")]
		[Address(RVA = "0x9D1CA0", Offset = "0x9D06A0", VA = "0x1809D1CA0", Slot = "123")]
		[ObserversRpc(RunLocally = true)]
		public virtual void ResetPot()
		{
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x00015780 File Offset: 0x00013980
		[Token(Token = "0x60056AA")]
		[Address(RVA = "0x9CE960", Offset = "0x9CD360", VA = "0x1809CE960")]
		public float GetAverageLightExposure(out float growSpeedMultiplier)
		{
			return 0f;
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x00015798 File Offset: 0x00013998
		[Token(Token = "0x60056AB")]
		[Address(RVA = "0x9CDC30", Offset = "0x9CC630", VA = "0x1809CDC30")]
		public bool CanAcceptSeed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x000157B0 File Offset: 0x000139B0
		[Token(Token = "0x60056AC")]
		[Address(RVA = "0x9CF4C0", Offset = "0x9CDEC0", VA = "0x1809CF4C0")]
		public bool IsReadyForHarvest(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x000157C8 File Offset: 0x000139C8
		[Token(Token = "0x60056AD")]
		[Address(RVA = "0x9CDD80", Offset = "0x9CC780", VA = "0x1809CDD80", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056AE")]
		[Address(RVA = "0x9D0A30", Offset = "0x9CF430", VA = "0x1809D0A30")]
		public void OverrideRotation(float angle)
		{
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056AF")]
		[Address(RVA = "0x9CEE30", Offset = "0x9CD830", VA = "0x1809CEE30")]
		public Transform GetCameraPosition(Pot.ECameraPosition pos)
		{
			return null;
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B0")]
		[Address(RVA = "0x9CD820", Offset = "0x9CC220", VA = "0x1809CD820", Slot = "124")]
		public virtual void AddSoil(float amount)
		{
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B1")]
		[Address(RVA = "0x9D61D0", Offset = "0x9D4BD0", VA = "0x1809D61D0")]
		private void SoilLevelChanged(float _prev, float _new, bool asServer)
		{
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B2")]
		[Address(RVA = "0x9D6FD0", Offset = "0x9D59D0", VA = "0x1809D6FD0", Slot = "125")]
		protected virtual void UpdateSoilScale()
		{
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B3")]
		[Address(RVA = "0x9D5E50", Offset = "0x9D4850", VA = "0x1809D5E50", Slot = "126")]
		public virtual void SetSoilID(string id)
		{
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B4")]
		[Address(RVA = "0x9D6180", Offset = "0x9D4B80", VA = "0x1809D6180", Slot = "127")]
		public virtual void SetSoilUses(int uses)
		{
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B5")]
		[Address(RVA = "0x9D1450", Offset = "0x9CFE50", VA = "0x1809D1450")]
		public void PushSoilDataToServer()
		{
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B6")]
		[Address(RVA = "0x9D4520", Offset = "0x9D2F20", VA = "0x1809D4520")]
		[ServerRpc(RequireOwnership = false)]
		public void SendSoilData(string soilID, float soilLevel, int soilUses)
		{
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B7")]
		[Address(RVA = "0x9D5F60", Offset = "0x9D4960", VA = "0x1809D5F60")]
		public void SetSoilState(Pot.ESoilState state)
		{
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B8")]
		[Address(RVA = "0x9D6CF0", Offset = "0x9D56F0", VA = "0x1809D6CF0", Slot = "128")]
		protected virtual void UpdateSoilMaterial()
		{
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B9")]
		[Address(RVA = "0x9CDEE0", Offset = "0x9CC8E0", VA = "0x1809CDEE0")]
		public void ChangeWaterAmount(float change)
		{
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BA")]
		[Address(RVA = "0x9D15D0", Offset = "0x9CFFD0", VA = "0x1809D15D0")]
		public void PushWaterDataToServer()
		{
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BB")]
		[Address(RVA = "0x9D4690", Offset = "0x9D3090", VA = "0x1809D4690")]
		[ServerRpc(RequireOwnership = false)]
		public void SendWaterData(float waterLevel)
		{
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BC")]
		[Address(RVA = "0x9D70A0", Offset = "0x9D5AA0", VA = "0x1809D70A0")]
		private void WaterLevelChanged(float _prev, float _new, bool asServer)
		{
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BD")]
		[Address(RVA = "0x9D6190", Offset = "0x9D4B90", VA = "0x1809D6190")]
		public void SetTargetActive(bool active)
		{
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BE")]
		[Address(RVA = "0x9D1710", Offset = "0x9D0110", VA = "0x1809D1710")]
		public void RandomizeTarget()
		{
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BF")]
		[Address(RVA = "0x9D4FC0", Offset = "0x9D39C0", VA = "0x1809D4FC0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendAdditive(string additiveAssetPath, bool initial)
		{
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C0")]
		[Address(RVA = "0x9CD880", Offset = "0x9CC280", VA = "0x1809CD880")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ApplyAdditive(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x000157E0 File Offset: 0x000139E0
		[Token(Token = "0x60056C1")]
		[Address(RVA = "0x9CE740", Offset = "0x9CD140", VA = "0x1809CE740")]
		public float GetAdditiveGrowthMultiplier()
		{
			return 0f;
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x000157F8 File Offset: 0x000139F8
		[Token(Token = "0x60056C2")]
		[Address(RVA = "0x9CEFA0", Offset = "0x9CD9A0", VA = "0x1809CEFA0")]
		public float GetNetYieldChange()
		{
			return 0f;
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x00015810 File Offset: 0x00013A10
		[Token(Token = "0x60056C3")]
		[Address(RVA = "0x9CEE70", Offset = "0x9CD870", VA = "0x1809CEE70")]
		public float GetNetQualityChange()
		{
			return 0f;
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C4")]
		[Address(RVA = "0x9CE880", Offset = "0x9CD280", VA = "0x1809CE880")]
		public Additive GetAdditive(string additiveName)
		{
			return null;
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C5")]
		[Address(RVA = "0x9CE620", Offset = "0x9CD020", VA = "0x1809CE620")]
		[ObserversRpc(RunLocally = true)]
		public void FullyGrowPlant()
		{
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C6")]
		[Address(RVA = "0x9D53B0", Offset = "0x9D3DB0", VA = "0x1809D53B0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C7")]
		[Address(RVA = "0x9D0A40", Offset = "0x9CF440", VA = "0x1809D0A40")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void PlantSeed(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C8")]
		[Address(RVA = "0x9D3E00", Offset = "0x9D2800", VA = "0x1809D3E00")]
		[ObserversRpc]
		private void SetGrowProgress(float progress)
		{
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C9")]
		[Address(RVA = "0x9D0D70", Offset = "0x9CF770", VA = "0x1809D0D70")]
		private void PlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056CA")]
		[Address(RVA = "0x9D5940", Offset = "0x9D4340", VA = "0x1809D5940")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetHarvestableActive(NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056CB")]
		[Address(RVA = "0x9D56A0", Offset = "0x9D40A0", VA = "0x1809D56A0")]
		public void SetHarvestableActive_Local(int harvestableIndex, bool active)
		{
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056CC")]
		[Address(RVA = "0x9D5240", Offset = "0x9D3C40", VA = "0x1809D5240")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendHarvestableActive(int harvestableIndex, bool active)
		{
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056CD")]
		[Address(RVA = "0x9D5230", Offset = "0x9D3C30", VA = "0x1809D5230")]
		public void SendHarvestableActive_Local(int harvestableIndex, bool active)
		{
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CE")]
		[Address(RVA = "0x9CE020", Offset = "0x9CCA20", VA = "0x1809CE020", Slot = "92")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056CF")]
		[Address(RVA = "0x9CE590", Offset = "0x9CCF90", VA = "0x1809CE590", Slot = "93")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D0")]
		[Address(RVA = "0x9CEB20", Offset = "0x9CD520", VA = "0x1809CEB20", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D1")]
		[Address(RVA = "0x9CF0D0", Offset = "0x9CDAD0", VA = "0x1809CF0D0", Slot = "59")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D2")]
		[Address(RVA = "0x9CF960", Offset = "0x9CE360", VA = "0x1809CF960", Slot = "129")]
		public virtual void LoadPlant(PlantData data)
		{
		}

		// Token: 0x060056D3 RID: 22227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D3")]
		[Address(RVA = "0x9D7130", Offset = "0x9D5B30", VA = "0x1809D7130")]
		public Pot()
		{
		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D4")]
		[Address(RVA = "0x9CFB40", Offset = "0x9CE540", VA = "0x1809CFB40", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060056D5 RID: 22229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D5")]
		[Address(RVA = "0x9CFA20", Offset = "0x9CE420", VA = "0x1809CFA20", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D6")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D7")]
		[Address(RVA = "0x9D47D0", Offset = "0x9D31D0", VA = "0x1809D47D0")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D8")]
		[Address(RVA = "0x9D28D0", Offset = "0x9D12D0", VA = "0x1809D28D0", Slot = "130")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D9")]
		[Address(RVA = "0x9D3520", Offset = "0x9D1F20", VA = "0x1809D3520")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060056DA RID: 22234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DA")]
		[Address(RVA = "0x9D4A30", Offset = "0x9D3430", VA = "0x1809D4A30")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DB")]
		[Address(RVA = "0x9D2B20", Offset = "0x9D1520", VA = "0x1809D2B20", Slot = "131")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DC")]
		[Address(RVA = "0x9D3620", Offset = "0x9D2020", VA = "0x1809D3620")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DD")]
		[Address(RVA = "0x9D4900", Offset = "0x9D3300", VA = "0x1809D4900")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DE")]
		[Address(RVA = "0x9D2A80", Offset = "0x9D1480", VA = "0x1809D2A80", Slot = "132")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060056DF RID: 22239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DF")]
		[Address(RVA = "0x9D35A0", Offset = "0x9D1FA0", VA = "0x1809D35A0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E0")]
		[Address(RVA = "0x9D3CE0", Offset = "0x9D26E0", VA = "0x1809D3CE0")]
		private void RpcWriter___Observers_ResetPot_2166136261()
		{
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E1")]
		[Address(RVA = "0x9D2380", Offset = "0x9D0D80", VA = "0x1809D2380", Slot = "133")]
		public virtual void RpcLogic___ResetPot_2166136261()
		{
		}

		// Token: 0x060056E2 RID: 22242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E2")]
		[Address(RVA = "0x9D2EB0", Offset = "0x9D18B0", VA = "0x1809D2EB0")]
		private void RpcReader___Observers_ResetPot_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060056E3 RID: 22243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E3")]
		[Address(RVA = "0x9D4520", Offset = "0x9D2F20", VA = "0x1809D4520")]
		private void RpcWriter___Server_SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E4")]
		[Address(RVA = "0x9D2760", Offset = "0x9D1160", VA = "0x1809D2760")]
		public void RpcLogic___SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E5")]
		[Address(RVA = "0x9D3310", Offset = "0x9D1D10", VA = "0x1809D3310")]
		private void RpcReader___Server_SendSoilData_3104499779(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060056E6 RID: 22246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E6")]
		[Address(RVA = "0x9D4690", Offset = "0x9D3090", VA = "0x1809D4690")]
		private void RpcWriter___Server_SendWaterData_431000436(float waterLevel)
		{
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E7")]
		[Address(RVA = "0x9D28C0", Offset = "0x9D12C0", VA = "0x1809D28C0")]
		public void RpcLogic___SendWaterData_431000436(float waterLevel)
		{
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E8")]
		[Address(RVA = "0x9D34C0", Offset = "0x9D1EC0", VA = "0x1809D34C0")]
		private void RpcReader___Server_SendWaterData_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E9")]
		[Address(RVA = "0x9D40D0", Offset = "0x9D2AD0", VA = "0x1809D40D0")]
		private void RpcWriter___Server_SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
		}

		// Token: 0x060056EA RID: 22250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056EA")]
		[Address(RVA = "0x9D26E0", Offset = "0x9D10E0", VA = "0x1809D26E0")]
		public void RpcLogic___SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
		}

		// Token: 0x060056EB RID: 22251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056EB")]
		[Address(RVA = "0x9D30B0", Offset = "0x9D1AB0", VA = "0x1809D30B0")]
		private void RpcReader___Server_SendAdditive_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060056EC RID: 22252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056EC")]
		[Address(RVA = "0x9D38B0", Offset = "0x9D22B0", VA = "0x1809D38B0")]
		private void RpcWriter___Observers_ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056ED")]
		[Address(RVA = "0x9D1DC0", Offset = "0x9D07C0", VA = "0x1809D1DC0")]
		public void RpcLogic___ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056EE")]
		[Address(RVA = "0x9D2D00", Offset = "0x9D1700", VA = "0x1809D2D00")]
		private void RpcReader___Observers_ApplyAdditive_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056EF")]
		[Address(RVA = "0x9D4B60", Offset = "0x9D3560", VA = "0x1809D4B60")]
		private void RpcWriter___Target_ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F0")]
		[Address(RVA = "0x9D36A0", Offset = "0x9D20A0", VA = "0x1809D36A0")]
		private void RpcReader___Target_ApplyAdditive_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F1")]
		[Address(RVA = "0x9D3A20", Offset = "0x9D2420", VA = "0x1809D3A20")]
		private void RpcWriter___Observers_FullyGrowPlant_2166136261()
		{
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F2")]
		[Address(RVA = "0x9D2270", Offset = "0x9D0C70", VA = "0x1809D2270")]
		public void RpcLogic___FullyGrowPlant_2166136261()
		{
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F3")]
		[Address(RVA = "0x9D2DB0", Offset = "0x9D17B0", VA = "0x1809D2DB0")]
		private void RpcReader___Observers_FullyGrowPlant_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F4")]
		[Address(RVA = "0x9D43A0", Offset = "0x9D2DA0", VA = "0x1809D43A0")]
		private void RpcWriter___Server_SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F5")]
		[Address(RVA = "0x9D2720", Offset = "0x9D1120", VA = "0x1809D2720")]
		public void RpcLogic___SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F6")]
		[Address(RVA = "0x9D3240", Offset = "0x9D1C40", VA = "0x1809D3240")]
		private void RpcReader___Server_SendPlantSeed_2530605204(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F7")]
		[Address(RVA = "0x9D3B40", Offset = "0x9D2540", VA = "0x1809D3B40")]
		private void RpcWriter___Observers_PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F8")]
		[Address(RVA = "0x9D2350", Offset = "0x9D0D50", VA = "0x1809D2350")]
		public void RpcLogic___PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		// Token: 0x060056F9 RID: 22265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F9")]
		[Address(RVA = "0x9D2DF0", Offset = "0x9D17F0", VA = "0x1809D2DF0")]
		private void RpcReader___Observers_PlantSeed_709433087(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060056FA RID: 22266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FA")]
		[Address(RVA = "0x9D4CC0", Offset = "0x9D36C0", VA = "0x1809D4CC0")]
		private void RpcWriter___Target_PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		// Token: 0x060056FB RID: 22267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FB")]
		[Address(RVA = "0x9D3740", Offset = "0x9D2140", VA = "0x1809D3740")]
		private void RpcReader___Target_PlantSeed_709433087(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060056FC RID: 22268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FC")]
		[Address(RVA = "0x9D3E00", Offset = "0x9D2800", VA = "0x1809D3E00")]
		private void RpcWriter___Observers_SetGrowProgress_431000436(float progress)
		{
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FD")]
		[Address(RVA = "0x9D2970", Offset = "0x9D1370", VA = "0x1809D2970")]
		private void RpcLogic___SetGrowProgress_431000436(float progress)
		{
		}

		// Token: 0x060056FE RID: 22270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FE")]
		[Address(RVA = "0x9D2EF0", Offset = "0x9D18F0", VA = "0x1809D2EF0")]
		private void RpcReader___Observers_SetGrowProgress_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FF")]
		[Address(RVA = "0x9D3F50", Offset = "0x9D2950", VA = "0x1809D3F50")]
		private void RpcWriter___Observers_SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005700")]
		[Address(RVA = "0x9D2A60", Offset = "0x9D1460", VA = "0x1809D2A60")]
		public void RpcLogic___SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		// Token: 0x06005701 RID: 22273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005701")]
		[Address(RVA = "0x9D3000", Offset = "0x9D1A00", VA = "0x1809D3000")]
		private void RpcReader___Observers_SetHarvestableActive_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005702")]
		[Address(RVA = "0x9D4E50", Offset = "0x9D3850", VA = "0x1809D4E50")]
		private void RpcWriter___Target_SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005703")]
		[Address(RVA = "0x9D3800", Offset = "0x9D2200", VA = "0x1809D3800")]
		private void RpcReader___Target_SetHarvestableActive_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005704")]
		[Address(RVA = "0x9D4230", Offset = "0x9D2C30", VA = "0x1809D4230")]
		private void RpcWriter___Server_SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005705")]
		[Address(RVA = "0x9D2700", Offset = "0x9D1100", VA = "0x1809D2700")]
		public void RpcLogic___SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005706")]
		[Address(RVA = "0x9D3170", Offset = "0x9D1B70", VA = "0x1809D3170")]
		private void RpcReader___Server_SendHarvestableActive_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06005707 RID: 22279 RVA: 0x00015828 File Offset: 0x00013A28
		// (set) Token: 0x06005708 RID: 22280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF7")]
		public float SyncAccessor_<SoilLevel>k__BackingField
		{
			[Token(Token = "0x6005707")]
			[Address(RVA = "0x80F540", Offset = "0x80DF40", VA = "0x18080F540")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005708")]
			[Address(RVA = "0x9D7AD0", Offset = "0x9D64D0", VA = "0x1809D7AD0")]
			set
			{
			}
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x00015840 File Offset: 0x00013A40
		[Token(Token = "0x6005709")]
		[Address(RVA = "0x9D1940", Offset = "0x9D0340", VA = "0x1809D1940", Slot = "134")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.Pot(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x0600570A RID: 22282 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600570B RID: 22283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF8")]
		public string SyncAccessor_<SoilID>k__BackingField
		{
			[Token(Token = "0x600570A")]
			[Address(RVA = "0x68D390", Offset = "0x68BD90", VA = "0x18068D390")]
			get
			{
				return null;
			}
			[Token(Token = "0x600570B")]
			[Address(RVA = "0x9D7A10", Offset = "0x9D6410", VA = "0x1809D7A10")]
			set
			{
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600570C RID: 22284 RVA: 0x00015858 File Offset: 0x00013A58
		// (set) Token: 0x0600570D RID: 22285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF9")]
		public int SyncAccessor_<RemainingSoilUses>k__BackingField
		{
			[Token(Token = "0x600570C")]
			[Address(RVA = "0x9D73E0", Offset = "0x9D5DE0", VA = "0x1809D73E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600570D")]
			[Address(RVA = "0x9D7960", Offset = "0x9D6360", VA = "0x1809D7960")]
			set
			{
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600570E RID: 22286 RVA: 0x00015870 File Offset: 0x00013A70
		// (set) Token: 0x0600570F RID: 22287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BFA")]
		public float SyncAccessor_<WaterLevel>k__BackingField
		{
			[Token(Token = "0x600570E")]
			[Address(RVA = "0x9D73F0", Offset = "0x9D5DF0", VA = "0x1809D73F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600570F")]
			[Address(RVA = "0x9D7B90", Offset = "0x9D6590", VA = "0x1809D7B90")]
			set
			{
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06005710 RID: 22288 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005711 RID: 22289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BFB")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6005710")]
			[Address(RVA = "0x689F00", Offset = "0x688900", VA = "0x180689F00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005711")]
			[Address(RVA = "0x9D77E0", Offset = "0x9D61E0", VA = "0x1809D77E0")]
			set
			{
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005713 RID: 22291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BFC")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6005712")]
			[Address(RVA = "0x689EC0", Offset = "0x6888C0", VA = "0x180689EC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005713")]
			[Address(RVA = "0x9D78A0", Offset = "0x9D62A0", VA = "0x1809D78A0")]
			set
			{
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06005714 RID: 22292 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005715 RID: 22293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BFD")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6005714")]
			[Address(RVA = "0x68D3B0", Offset = "0x68BDB0", VA = "0x18068D3B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005715")]
			[Address(RVA = "0x9D7720", Offset = "0x9D6120", VA = "0x1809D7720")]
			set
			{
			}
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005716")]
		[Address(RVA = "0x9CDB20", Offset = "0x9CC520", VA = "0x1809CDB20", Slot = "135")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.Pot_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04004010 RID: 16400
		[Token(Token = "0x4004010")]
		public const float DryThreshold = 0f;

		// Token: 0x04004011 RID: 16401
		[Token(Token = "0x4004011")]
		public const float WaterloggedThreshold = 1f;

		// Token: 0x04004012 RID: 16402
		[Token(Token = "0x4004012")]
		public const float ROTATION_SPEED = 10f;

		// Token: 0x04004013 RID: 16403
		[Token(Token = "0x4004013")]
		public const float MAX_CAMERA_DISTANCE = 2.75f;

		// Token: 0x04004014 RID: 16404
		[Token(Token = "0x4004014")]
		public const float MIN_CAMERA_DISTANCE = 0.5f;

		// Token: 0x04004015 RID: 16405
		[Token(Token = "0x4004015")]
		[FieldOffset(Offset = "0x218")]
		[Header("References")]
		public Transform ModelTransform;

		// Token: 0x04004016 RID: 16406
		[Token(Token = "0x4004016")]
		[FieldOffset(Offset = "0x220")]
		public InteractableObject IntObj;

		// Token: 0x04004017 RID: 16407
		[Token(Token = "0x4004017")]
		[FieldOffset(Offset = "0x228")]
		public Transform PourableStartPoint;

		// Token: 0x04004018 RID: 16408
		[Token(Token = "0x4004018")]
		[FieldOffset(Offset = "0x230")]
		public Transform SeedStartPoint;

		// Token: 0x04004019 RID: 16409
		[Token(Token = "0x4004019")]
		[FieldOffset(Offset = "0x238")]
		public Transform SeedRestingPoint;

		// Token: 0x0400401A RID: 16410
		[Token(Token = "0x400401A")]
		[FieldOffset(Offset = "0x240")]
		public GameObject WaterLoggedVisuals;

		// Token: 0x0400401B RID: 16411
		[Token(Token = "0x400401B")]
		[FieldOffset(Offset = "0x248")]
		public Transform LookAtPoint;

		// Token: 0x0400401C RID: 16412
		[Token(Token = "0x400401C")]
		[FieldOffset(Offset = "0x250")]
		public Transform AdditivesContainer;

		// Token: 0x0400401D RID: 16413
		[Token(Token = "0x400401D")]
		[FieldOffset(Offset = "0x258")]
		public Transform PlantContainer;

		// Token: 0x0400401E RID: 16414
		[Token(Token = "0x400401E")]
		[FieldOffset(Offset = "0x260")]
		public Transform IntObjLabel_Low;

		// Token: 0x0400401F RID: 16415
		[Token(Token = "0x400401F")]
		[FieldOffset(Offset = "0x268")]
		public Transform IntObjLabel_High;

		// Token: 0x04004020 RID: 16416
		[Token(Token = "0x4004020")]
		[FieldOffset(Offset = "0x270")]
		public Transform uiPoint;

		// Token: 0x04004021 RID: 16417
		[Token(Token = "0x4004021")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04004022 RID: 16418
		[Token(Token = "0x4004022")]
		[FieldOffset(Offset = "0x280")]
		public Transform[] accessPoints;

		// Token: 0x04004023 RID: 16419
		[Token(Token = "0x4004023")]
		[FieldOffset(Offset = "0x288")]
		public Transform TaskBounds;

		// Token: 0x04004024 RID: 16420
		[Token(Token = "0x4004024")]
		[FieldOffset(Offset = "0x290")]
		public PotSoilCover SoilCover;

		// Token: 0x04004025 RID: 16421
		[Token(Token = "0x4004025")]
		[FieldOffset(Offset = "0x298")]
		public Transform LeafDropPoint;

		// Token: 0x04004026 RID: 16422
		[Token(Token = "0x4004026")]
		[FieldOffset(Offset = "0x2A0")]
		public ParticleSystem PoofParticles;

		// Token: 0x04004027 RID: 16423
		[Token(Token = "0x4004027")]
		[FieldOffset(Offset = "0x2A8")]
		public AudioSourceController PoofSound;

		// Token: 0x04004028 RID: 16424
		[Token(Token = "0x4004028")]
		[FieldOffset(Offset = "0x2B0")]
		[Header("UI")]
		public Transform WaterCanvasContainer;

		// Token: 0x04004029 RID: 16425
		[Token(Token = "0x4004029")]
		[FieldOffset(Offset = "0x2B8")]
		public Canvas WaterLevelCanvas;

		// Token: 0x0400402A RID: 16426
		[Token(Token = "0x400402A")]
		[FieldOffset(Offset = "0x2C0")]
		public CanvasGroup WaterLevelCanvasGroup;

		// Token: 0x0400402B RID: 16427
		[Token(Token = "0x400402B")]
		[FieldOffset(Offset = "0x2C8")]
		public Slider WaterLevelSlider;

		// Token: 0x0400402C RID: 16428
		[Token(Token = "0x400402C")]
		[FieldOffset(Offset = "0x2D0")]
		public GameObject NoWaterIcon;

		// Token: 0x0400402D RID: 16429
		[Token(Token = "0x400402D")]
		[FieldOffset(Offset = "0x2D8")]
		public PotUIElement WorldspaceUIPrefab;

		// Token: 0x0400402E RID: 16430
		[Token(Token = "0x400402E")]
		[FieldOffset(Offset = "0x2E0")]
		public Sprite typeIcon;

		// Token: 0x0400402F RID: 16431
		[Token(Token = "0x400402F")]
		[FieldOffset(Offset = "0x2E8")]
		[Header("Camera References")]
		public Transform CameraContainer;

		// Token: 0x04004030 RID: 16432
		[Token(Token = "0x4004030")]
		[FieldOffset(Offset = "0x2F0")]
		public Transform MidshotPosition;

		// Token: 0x04004031 RID: 16433
		[Token(Token = "0x4004031")]
		[FieldOffset(Offset = "0x2F8")]
		public Transform CloseupPosition;

		// Token: 0x04004032 RID: 16434
		[Token(Token = "0x4004032")]
		[FieldOffset(Offset = "0x300")]
		public Transform FullshotPosition;

		// Token: 0x04004033 RID: 16435
		[Token(Token = "0x4004033")]
		[FieldOffset(Offset = "0x308")]
		public Transform BirdsEyePosition;

		// Token: 0x04004034 RID: 16436
		[Token(Token = "0x4004034")]
		[FieldOffset(Offset = "0x310")]
		public bool AutoRotateCameraContainer;

		// Token: 0x04004035 RID: 16437
		[Token(Token = "0x4004035")]
		[FieldOffset(Offset = "0x318")]
		[Header("Dirt references")]
		public Transform Dirt_Flat;

		// Token: 0x04004036 RID: 16438
		[Token(Token = "0x4004036")]
		[FieldOffset(Offset = "0x320")]
		public Transform Dirt_Parted;

		// Token: 0x04004037 RID: 16439
		[Token(Token = "0x4004037")]
		[FieldOffset(Offset = "0x328")]
		public SoilChunk[] SoilChunks;

		// Token: 0x04004038 RID: 16440
		[Token(Token = "0x4004038")]
		[FieldOffset(Offset = "0x330")]
		public List<MeshRenderer> DirtRenderers;

		// Token: 0x04004039 RID: 16441
		[Token(Token = "0x4004039")]
		[FieldOffset(Offset = "0x338")]
		[Header("Pot Settings")]
		public float PotRadius;

		// Token: 0x0400403A RID: 16442
		[Token(Token = "0x400403A")]
		[FieldOffset(Offset = "0x33C")]
		[Range(0.2f, 2f)]
		public float YieldMultiplier;

		// Token: 0x0400403B RID: 16443
		[Token(Token = "0x400403B")]
		[FieldOffset(Offset = "0x340")]
		[Range(0.2f, 2f)]
		public float GrowSpeedMultiplier;

		// Token: 0x0400403C RID: 16444
		[Token(Token = "0x400403C")]
		[FieldOffset(Offset = "0x344")]
		[Range(0.2f, 2f)]
		public float MoistureDrainMultiplier;

		// Token: 0x0400403D RID: 16445
		[Token(Token = "0x400403D")]
		[FieldOffset(Offset = "0x348")]
		public bool AlignLeafDropToPlayer;

		// Token: 0x0400403E RID: 16446
		[Token(Token = "0x400403E")]
		[FieldOffset(Offset = "0x34C")]
		[Header("Capacity Settings")]
		public float SoilCapacity;

		// Token: 0x0400403F RID: 16447
		[Token(Token = "0x400403F")]
		[FieldOffset(Offset = "0x350")]
		public float WaterCapacity;

		// Token: 0x04004040 RID: 16448
		[Token(Token = "0x4004040")]
		[FieldOffset(Offset = "0x354")]
		public float WaterDrainPerHour;

		// Token: 0x04004041 RID: 16449
		[Token(Token = "0x4004041")]
		[FieldOffset(Offset = "0x358")]
		[Header("Dirt Settings")]
		[SerializeField]
		protected Vector3 DirtMinScale;

		// Token: 0x04004042 RID: 16450
		[Token(Token = "0x4004042")]
		[FieldOffset(Offset = "0x364")]
		[SerializeField]
		protected Vector3 DirtMaxScale;

		// Token: 0x04004043 RID: 16451
		[Token(Token = "0x4004043")]
		[FieldOffset(Offset = "0x370")]
		[Header("Pour Target")]
		public Transform Target;

		// Token: 0x04004044 RID: 16452
		[Token(Token = "0x4004044")]
		[FieldOffset(Offset = "0x378")]
		[Header("Lighting")]
		public UsableLightSource LightSourceOverride;

		// Token: 0x0400404A RID: 16458
		[Token(Token = "0x400404A")]
		[FieldOffset(Offset = "0x3A0")]
		public List<Additive> AppliedAdditives;

		// Token: 0x04004054 RID: 16468
		[Token(Token = "0x4004054")]
		[FieldOffset(Offset = "0x3E2")]
		private bool intObjSetThisFrame;

		// Token: 0x04004055 RID: 16469
		[Token(Token = "0x4004055")]
		[FieldOffset(Offset = "0x3E8")]
		private ItemSlot outputSlot;

		// Token: 0x04004056 RID: 16470
		[Token(Token = "0x4004056")]
		[FieldOffset(Offset = "0x3F0")]
		private float rotation;

		// Token: 0x04004057 RID: 16471
		[Token(Token = "0x4004057")]
		[FieldOffset(Offset = "0x3F4")]
		private bool rotationOverridden;

		// Token: 0x04004058 RID: 16472
		[Token(Token = "0x4004058")]
		[FieldOffset(Offset = "0x3F8")]
		private SoilDefinition appliedSoilDefinition;

		// Token: 0x04004059 RID: 16473
		[Token(Token = "0x4004059")]
		[FieldOffset(Offset = "0x400")]
		private Material appliedSoilMaterial;

		// Token: 0x0400405A RID: 16474
		[Token(Token = "0x400405A")]
		[FieldOffset(Offset = "0x408")]
		public SyncVar<float> syncVar___<SoilLevel>k__BackingField;

		// Token: 0x0400405B RID: 16475
		[Token(Token = "0x400405B")]
		[FieldOffset(Offset = "0x410")]
		public SyncVar<string> syncVar___<SoilID>k__BackingField;

		// Token: 0x0400405C RID: 16476
		[Token(Token = "0x400405C")]
		[FieldOffset(Offset = "0x418")]
		public SyncVar<int> syncVar___<RemainingSoilUses>k__BackingField;

		// Token: 0x0400405D RID: 16477
		[Token(Token = "0x400405D")]
		[FieldOffset(Offset = "0x420")]
		public SyncVar<float> syncVar___<WaterLevel>k__BackingField;

		// Token: 0x0400405E RID: 16478
		[Token(Token = "0x400405E")]
		[FieldOffset(Offset = "0x428")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x0400405F RID: 16479
		[Token(Token = "0x400405F")]
		[FieldOffset(Offset = "0x430")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04004060 RID: 16480
		[Token(Token = "0x4004060")]
		[FieldOffset(Offset = "0x438")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04004061 RID: 16481
		[Token(Token = "0x4004061")]
		[FieldOffset(Offset = "0x440")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted;

		// Token: 0x04004062 RID: 16482
		[Token(Token = "0x4004062")]
		[FieldOffset(Offset = "0x441")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted;

		// Token: 0x02000C7B RID: 3195
		[Token(Token = "0x2000C7B")]
		public enum ECameraPosition
		{
			// Token: 0x04004064 RID: 16484
			[Token(Token = "0x4004064")]
			Closeup,
			// Token: 0x04004065 RID: 16485
			[Token(Token = "0x4004065")]
			Midshot,
			// Token: 0x04004066 RID: 16486
			[Token(Token = "0x4004066")]
			Fullshot,
			// Token: 0x04004067 RID: 16487
			[Token(Token = "0x4004067")]
			BirdsEye
		}

		// Token: 0x02000C7C RID: 3196
		[Token(Token = "0x2000C7C")]
		public enum ESoilState
		{
			// Token: 0x04004069 RID: 16489
			[Token(Token = "0x4004069")]
			Flat,
			// Token: 0x0400406A RID: 16490
			[Token(Token = "0x400406A")]
			Parted,
			// Token: 0x0400406B RID: 16491
			[Token(Token = "0x400406B")]
			Packed
		}
	}
}
