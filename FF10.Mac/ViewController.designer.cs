// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FF10.Mac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSSlider sliderOverdrive { get; set; }

		[Outlet]
		AppKit.NSTableView tableViewCharacters { get; set; }

		[Outlet]
		AppKit.NSTextField txtAccuracy { get; set; }

		[Outlet]
		AppKit.NSTextField txtAttack { get; set; }

		[Outlet]
		AppKit.NSTextField txtAvoidance { get; set; }

		[Outlet]
		AppKit.NSTextField txtDefence { get; set; }

		[Outlet]
		AppKit.NSTextField txtHP { get; set; }

		[Outlet]
		AppKit.NSTextField txtLevel { get; set; }

		[Outlet]
		AppKit.NSTextField txtLuck { get; set; }

		[Outlet]
		AppKit.NSTextField txtMagic { get; set; }

		[Outlet]
		AppKit.NSTextField txtMagicDef { get; set; }

		[Outlet]
		AppKit.NSTextField txtMP { get; set; }

		[Outlet]
		AppKit.NSTextField txtSpeed { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tableViewCharacters != null) {
				tableViewCharacters.Dispose ();
				tableViewCharacters = null;
			}

			if (txtHP != null) {
				txtHP.Dispose ();
				txtHP = null;
			}

			if (txtMP != null) {
				txtMP.Dispose ();
				txtMP = null;
			}

			if (txtLevel != null) {
				txtLevel.Dispose ();
				txtLevel = null;
			}

			if (txtAttack != null) {
				txtAttack.Dispose ();
				txtAttack = null;
			}

			if (txtDefence != null) {
				txtDefence.Dispose ();
				txtDefence = null;
			}

			if (txtMagic != null) {
				txtMagic.Dispose ();
				txtMagic = null;
			}

			if (txtMagicDef != null) {
				txtMagicDef.Dispose ();
				txtMagicDef = null;
			}

			if (txtSpeed != null) {
				txtSpeed.Dispose ();
				txtSpeed = null;
			}

			if (txtLuck != null) {
				txtLuck.Dispose ();
				txtLuck = null;
			}

			if (txtAvoidance != null) {
				txtAvoidance.Dispose ();
				txtAvoidance = null;
			}

			if (txtAccuracy != null) {
				txtAccuracy.Dispose ();
				txtAccuracy = null;
			}

			if (sliderOverdrive != null) {
				sliderOverdrive.Dispose ();
				sliderOverdrive = null;
			}
		}
	}
}
