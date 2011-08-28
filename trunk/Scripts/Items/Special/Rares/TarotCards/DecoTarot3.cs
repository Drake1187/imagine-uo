using System;

namespace Server.Items
{
	public class DecoTarot3 : Item
	{

		[Constructable]
		public DecoTarot3() : base( 0x12A7 )
		{
			Movable = true;
			Stackable = false;
			ItemValue = ItemValue.Rare;
		}

		public DecoTarot3( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
