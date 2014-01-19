using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class HorrificBeastScroll : SpellScroll
	{
		 
		public HorrificBeastScroll() : this( 1 )
		{
		}

		 
		public HorrificBeastScroll( int amount ) : base( 105, 0x2265, amount )
		{
		}

		public HorrificBeastScroll( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		
	}
}