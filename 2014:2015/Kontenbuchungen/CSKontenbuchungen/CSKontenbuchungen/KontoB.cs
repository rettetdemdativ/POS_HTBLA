﻿// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;

namespace CSKontenbuchungen
{
	public class KontoB:Konto
	{
		public KontoB (string k, double ks):base(k, ks, -10000)
		{
		}

		public override string ToString ()
		{
			if(base._KontoStand < base.Ueberziehungsgrenze){
				OnUeberzogen ();
			}
			return string.Format (base.ToString() + "\nKontoB: Ueberziehungsgrenze:{0}", base.Ueberziehungsgrenze.ToString().Remove(0,1));
		}

		public override event Ueberzogen ue;
		public override event VerdaechtigerBetrag vb;

		public override void OnUeberzogen(){
			if(ue != null){
				ue (this, new EventArgs());
			}
		}

		public override void OnVerdaechtig(){
			if(vb != null){
				vb (this, new EventArgs());
			}
		}
	}
}
